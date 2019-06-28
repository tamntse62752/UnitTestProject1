using System;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Winium;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest : LoginTest
    {
        //private const string ClassName = "WindowsForms10.EDIT.app.0.205b375_r9_ad1";
        private const string ClassName = "WindowsForms10.Window.8.app.0.205b375_r9_ad1";
       
        public IWebElement btnLogin;

               
        [TestMethod]
        public void UpdateProduct()
        {
            //ReadOnlyCollection<IWebElement> UpdateBtn = driver.FindElementsById("btnConfig");
            driver.FindElementById("btnConfig").Click();
            //driver.FindElementByName("").Click();
            Thread.Sleep(2000);
            driver.FindElementById("btnUpdate").Click();
            Thread.Sleep(2000);
            driver.FindElementById("btnUpdateProduct").Click();
            
        }

        [TestMethod]
        public void UpdateCategory()
        {
            //ReadOnlyCollection<IWebElement> UpdateBtn = driver.FindElementsById("btnConfig");
            driver.FindElementById("btnConfig").Click();
            //driver.FindElementByName("").Click();
            Thread.Sleep(2000);
            driver.FindElementById("btnUpdate").Click();
            Thread.Sleep(2000);
            driver.FindElementById("btnUpdateCategory").Click();

        }
        
        
      
        [ClassInitialize]
        public static void loadForm(TestContext context)
        {
            LoadApp(context);
            IWebElement btnConfig = driver.FindElementById("btnConfig");
 
            //IWebElement txtUsername = driver.FindElementById("txtUsername");
            //IWebElement txtPassword = driver.FindElementById("txtPassword");
            //Assert.IsNotNull(btnConfig);
        }
    }
}
