﻿using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace Report_Asapp.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            //UIApplication.Main(args, null, "AppDelegate"); - deprecated
            UIApplication.Main(args, null, typeof(AppDelegate));
        }
    }
}
