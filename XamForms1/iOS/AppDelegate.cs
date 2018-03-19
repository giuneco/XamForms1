using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using FreshMvvm;
using UIKit;
using XamForms1.iOS.Services;
using XamForms1.Services;

namespace XamForms1.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            FreshIOC.Container.Register<IBlocker, IosBlocker>().AsSingleton();
            FreshIOC.Container.Register<ITextToSpeech, TextToSpeechImplementation>().AsMultiInstance();


            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
