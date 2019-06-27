using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    
    public class LoginTest
    {
        //private const string PosAppId = @"E:\Wisky\NewPos\POS\POS\bin\Debug\SkyPOS.exe";

        private const string PosAppId = @"C:\Program Files (x86)\SkyPOS\SkyPOS.exe";
        

        protected static WiniumDriver driver;
        public static void LoadApp(TestContext context)
        {
            //var service = WiniumDriverService.CreateDesktopService(@"C:\Users\bom4e\Downloads\Winium.Desktop.Driver");
            var service = WiniumDriverService.CreateDesktopService(@"C:\Users\HungDang\Downloads\Winium.Desktop.Driver");
        

         DesktopOptions option = new DesktopOptions
            {
                ApplicationPath = PosAppId
            };
            driver = new WiniumDriver(service, option, TimeSpan.FromSeconds(60));
        }
        
    }
}
