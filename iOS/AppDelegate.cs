using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using FormsTest;
using Foundation;
using UIKit;

namespace FormsTestSample.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            // Code for starting up the Xamarin Test Cloud Agent
#if DEBUG
			Xamarin.Calabash.Start();
#endif

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        [Export("FormsPropertyGet:")] // notice the colon at the end of the method name
        public NSString FormsPropertyGet(NSString value)
        {
            DependencyService.Get<IFormsTest>().GetProperty(value.ToString());
            return new NSString();
        }
    }
}
