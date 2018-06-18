using System;
using System.Threading;
using Microsoft.Win32.SafeHandles;
using NAudio.Wave;

namespace SoundCapture
{
    /// <summary>
    /// Base class to capture audio samples.
    /// </summary>
    public abstract class SoundCaptureBase : IDisposable
    {
        const int BufferSeconds = 3;
        const int NotifyPointsInSecond = 2;

        // change in next two will require also code change
        const int BitsPerSample = 16; 
        const int ChannelCount = 1;

        int sampleRate = 192000;
        bool isCapturing = false;
        bool disposed = false;

        public WaveIn wi;
        public BufferedWaveProvider bwp;
        public Int32 envelopeMax;
        private System.Timers.Timer timer1;
        System.Threading.Thread thread;

        private int RATE = 192000; // sample rate of the sound card
        private int BUFFERSIZE = (int)Math.Pow(2, 14); // must be a multiple of 2

        public bool IsCapturing
        {
            get { return isCapturing; }
        }

        public int SampleRate
        {
            get { return sampleRate; }
            set 
            {
                if (sampleRate <= 0) throw new ArgumentOutOfRangeException();

                EnsureIdle();

                sampleRate = value; 
            }
        }


        ManualResetEvent terminated;


        public SoundCaptureBase()
        {
            terminated = new ManualResetEvent(true);
        }

        private void EnsureIdle()
        {
            if (IsCapturing)
                throw new Exception("Capture is in process");
        }

        /// <summary>
        /// Start capture process.
        /// </summary>
        public void Start()
        {
            EnsureIdle();
            isCapturing = true;
            terminated.Reset();
            thread = new Thread(new ThreadStart(ThreadLoop));
            thread.Name = "Sound capture";
            thread.Start();

            timer1 = new System.Timers.Timer(10);
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Start();

        }

        private void ThreadLoop()
        {
            //buffer.Start(true);
            try
            {
                // see what audio devices are available
                int devcount = WaveIn.DeviceCount;
                Console.Out.WriteLine("Device Count: {0}.", devcount);

                // get the WaveIn class started
                WaveInEvent wi = new WaveInEvent();
                wi.DeviceNumber = 0;
                wi.WaveFormat = new NAudio.Wave.WaveFormat(RATE, 1);
                wi.BufferMilliseconds = (int)((double)BUFFERSIZE / (double)RATE * 1000.0);

                // create a wave buffer and start the recording
                wi.DataAvailable += new EventHandler<WaveInEventArgs>(wi_DataAvailable);
                bwp = new BufferedWaveProvider(wi.WaveFormat);
                bwp.BufferLength = BUFFERSIZE * 2;

                bwp.DiscardOnBufferOverflow = true;
                wi.StartRecording();
            }
            finally
            {
            }
        }

        // adds data to the audio recording buffer
        void wi_DataAvailable(object sender, WaveInEventArgs e)
        {
            bwp.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        private void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (bwp == null)
                return;
            // read the bytes from the stream
            int frameSize = BUFFERSIZE;
            var frames = new byte[frameSize];
            bwp.Read(frames, 0, frameSize);
            if (frames.Length == 0) return;
            if (frames[frameSize - 2] == 0) return;

          
            timer1.Enabled = false;

            // convert it to int32 manually (and a double for scottplot)
            int SAMPLE_RESOLUTION = 16;
            int BYTES_PER_POINT = SAMPLE_RESOLUTION / 8;
            short[] vals = new short[frames.Length / BYTES_PER_POINT];

            for (int i = 0; i < vals.Length; i++)
            {
                // bit shift the byte buffer into the right variable format
                byte hByte = frames[i * 2 + 1];
                byte lByte = frames[i * 2 + 0];
                vals[i] = (short)((hByte << 8) | lByte);
            }


            ProcessData(vals);

            timer1.Enabled = true;

        }

        /// <summary>
        /// Process the captured data.
        /// </summary>
        /// <param name="data">Captured data</param>
        protected abstract void ProcessData(short[] data);

        /// <summary>
        /// Stop capture process.
        /// </summary>
        public void Stop()
        {
            if (isCapturing)
            {
                isCapturing = false;
                timer1.Stop();
                terminated.Set();
                thread.Join();
            }
        }

        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        ~SoundCaptureBase()
        {
            Dispose(false);
        }

        private void Dispose(bool disposing)
        {
            if (disposed) return;

            disposed = true;
            GC.SuppressFinalize(this);
            if (IsCapturing) Stop();
            terminated.Close();            
        }
    }
}
