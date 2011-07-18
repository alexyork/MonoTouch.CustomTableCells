using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomTableCellApp
{
    public class Application
    {
        static void Main(string[] args)
        {
            UIApplication.Main(args);
        }
    }

    public partial class AppDelegate : UIApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            window.MakeKeyAndVisible();
            return true;
        }
    }
}
