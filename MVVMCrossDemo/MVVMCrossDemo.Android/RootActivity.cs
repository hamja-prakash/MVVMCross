using Android.App;
using Android.Content.PM;
using MvvmCross.Forms.Platforms.Android.Core;
using MvvmCross.Forms.Platforms.Android.Views;

namespace MVVMCrossDemo.Droid
{
    [Activity(Label = "MVVMCrossDemo", Icon = "@mipmap/icon", Theme = "@style/MainTheme",
    MainLauncher = true,
    ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    //public class RootActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    //{
    //    protected override void OnCreate(Bundle savedInstanceState)
    //    {
    //        base.OnCreate(savedInstanceState);

    //        Xamarin.Essentials.Platform.Init(this, savedInstanceState);
    //        global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
    //        LoadApplication(new App());
    //    }
    //    public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
    //    {
    //        Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

    //        base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
    //    }
    //}

    public class RootActivity : MvxFormsAppCompatActivity<MvxFormsAndroidSetup<MvxForms.Core.App, App>, MvxForms.Core.App, App>
    {

    }
}