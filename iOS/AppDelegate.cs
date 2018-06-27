using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using MvvmCross.Forms.Platforms.Ios.Core;
using UIKit;
using TestDemo.Core;

namespace TestDemo.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : MvxFormsApplicationDelegate<Setup, CoreApp, App>
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            UINavigationBar.Appearance.BarTintColor = UIColor.FromRGB(65, 105, 225);
            UINavigationBar.Appearance.TintColor = UIColor.FromRGB(255, 255, 255);

            return base.FinishedLaunching(app, options);
        }
    }
}
