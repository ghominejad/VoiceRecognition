# <p dir='rtl' align='right'> تشخیص صدا به زبان <span dir=ltr>C#</span></p>
<p dir='rtl'>
این پروژه در سال 1389 پیاده سازی شده و بنا به درخواست دوستان برخی اصلاحات مهم اعمال شده و اکنون داخل گیت هاب قرار داده شده
</p>

## <p dir='rtl' align='right'>هدف از پروژه</p>

<p dir='rtl' align='right'>هدف اصلي اين ارائه آشنايي دانشجوياني که به اين بحث علاقه بسياري دارند ولي دانش پايه ندارند و يا نمي دانند از کجا شروع کنند مي باشد.
گرچه در اين ارائه هيچ نو آوري ديده نميشود ولي فکر ميکنم براي باز شدن ذهن دانشجويان در زمينه پردازش زبان طبيعي انشالله موثر خواهد بود.
تا جاي ممکن سعي شده تا مطالب با بياني ساده آماده شوند و از همه مهمتر از عنوان مطالب رياضي و آمار اجتناب شده است.

</p>

<p dir='rtl' align='right' style="padding-right:20px">•
اين ارائه شامل مطالبي جهت شناخت اصطلاحات و اطلاعات پيش نياز اصوات و روش هاي دريافت صوت و همچنين پردازش و تشخيص آن مي باشد.

</p>

<p dir='rtl' align='right' style="padding-right:20px">•
 پياده سازي پروژه نيز در بستر دات نت و به زبان c# سی شارپ بدون استفاده از هيچ گونه ابزار جانبي انجام شده است.

</p>

<p dir='rtl' align='right' style="padding-right:20px">•
لطفا قبل به اجرا در آوردن فايلهاي اجرايي نگاهي به مستندات بيندازيد. 
</p>

## <p dir='rtl' align='right'> نمای برنامه </p>
##### <p dir='rtl' align='right' style="padding-right:20px">• برنامه آزمایشگاه - LabApp</p>

![](https://raw.githubusercontent.com/ghominejad/VoiceRecognition/master/Doc/lab.gif)

##### <p dir='rtl' align='right' style="padding-right:20px">• برنامه تشخیص حروف - RecognizerApp</p>
![](https://raw.githubusercontent.com/ghominejad/VoiceRecognition/master/Doc/recognizer.gif)

## <p dir='rtl' align='right'> مستندات </p>
<p dir='rtl' align='right' style="padding-right:20px" > این ارائه متشکل از چهار پروژه به شرح زیر می باشد : </p>
<p dir='rtl' align='right' style="padding-right:20px" >
<b>1 - پروژه آزمایشگاه - LabApp</b> :    این پروژه ابزارهایی مانند ابزار طیف نگاری اصوات در اختیار کاربران قرار میدهد تا کابران بتوانند از طریق میکروفون اصوات را مورد بررسی قرار دهند
</p>
<p dir='rtl' align='right' style="padding-right:20px" >
<b>2 - پروژه تشخیص حروف - RecognizerApp</b> :    این پروژه چند حروف بخصوص (آ، اَ، اِ، س، ش، ز، ژ) که کاربر از طریق میکروفون بیان میکند را تشخیص داده و بر روی صفحه، نمایش میدهد
</p>
<p dir='rtl' align='right' style="padding-right:20px" >
<b>3 - پروژه  تحلیل حروف - SoundAnalysis</b> :    تشخیص حروف (آ، اَ، اِ، س، ش، ز، ژ) و یک سری فیلتر مانند حذف نویز، تشیص سرعت، نرمال سازی و سایر تحلیل ها نیز در پروژه قرار گرفته شده است
</p>
<p dir='rtl' align='right' style="padding-right:20px" >
<b>4 - پروژه  دریافت نمونه صوتی - SoundCapture</b> :    دریافت نمونه های صوتی از طریق میکروفون توسط این پروژه انجام میشود. در نسخه پیشین این عمل بوسیله ی  <b>DirectX</b> انجام میشد که جهت سادگی و سازگاری بیشتر دریافت نمونه های صوتی در ورژن جدید توسط کتابخانه <b>NAudio</b> انجام می شود
</p>

[<p dir='rtl' align='right' style="padding-right:20px" >📖 دانلود فایل راهنمای پروژه (PDF)</p>](https://github.com/ghominejad/VoiceRecognition/blob/master/Doc/Thesis.pdf)
<p dir="rtl" alight="right" style="padding:20px"><b>فایل راهنما شامل توضیحاتی پیرامون مباحث زیر نیز میباشد :</b>
<br/><br/>
&nbsp; • انواع نمودار هاي ترسيم صدا (دامنه زمان، دامنه فرکانس يا اسپکتروم و اسپکتروگرام)<br/>
&nbsp; • صداهاي هنچار و ناهنجار<br/>
&nbsp; • انواع موج ها<br/>
&nbsp; • دستگاه شنواييي و تکلم انسان<br/>
&nbsp; • نمونه گيري صوتي<br/>
&nbsp; • تبديل سريع فوريه (FFT)<br/>
&nbsp; • طول پنجره در تبديل فوريه<br/>
&nbsp; • توابع پنجره (Window Function)<br/>
&nbsp; • باند پهن و باند باريک (Wide Band و Narrow Band)<br/>
&nbsp; • فرکانس پايه و سازنده (Fundamental Frequency و Formants)<br/>
&nbsp; • fft bin<br/>
&nbsp; • تشخيص صدا، تشخيص حروف، حروف صدا دار و بي صدا<br/>
&nbsp; • تشخيص زيري و بمي صدا<br/>
&nbsp; • جداسازي (Segmentation)<br/>
&nbsp; • تشخيص صحبت و سکوت<br/>
&nbsp; • نرخ عبور از صفر (ZCR)<br/>
</p>

## <p dir='rtl' align='right'> اجرای برنامه </p>
##### <p dir='rtl' align='right' style="padding-right:20px">کامپایل</p>

<p dir='rtl' align='right' style="padding-right:20px" >
شما میتواید سورس کد کامل این پروژه را از طریق گیت هاب دریافت و کامپایل کنید
</p>

[دانلود سورس های پروژه](https://github.com/ghominejad/VoiceRecognition/releases)





##### <p dir='rtl' align='right' style="padding-right:20px">اجرا</p>
<p dir='rtl' align='right' style="padding-right:20px"> 
شما میتوانید بدون نیاز به کامپایل این پروژه فایل های اجرایی از پیش کامپایل شده را از آدرس زیر دریافت کنید
</p>

[دانلود فایل های اجرایی پروژه](https://github.com/ghominejad/VoiceRecognition/releases)




## <p dir='rtl' align='right' >تماس </p>
<p dir='rtl' align='right' style="padding-right:20px" >در صورتی که به مشکلی برخوردید لطفا آن را در قسمت Issues بیان کنید</p>


* ghominejad@gmail.com
* https://www.linkedin.com/in/ghominejad/

