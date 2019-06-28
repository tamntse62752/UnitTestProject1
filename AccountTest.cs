using System;
using System.Collections.ObjectModel;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Winium;

namespace UnitTestProject1
{
    [TestClass]
    public class AccountTest : LoginTest
    {
        ReadOnlyCollection<IWebElement> textBox = driver.FindElementsById("textBox");
        ReadOnlyCollection<IWebElement> btnLogin = driver.FindElementsById("btnLogin");

        /// <summary>
        /// /////////////////////////// Account Test Case ////////////////////////////////////////////
        /// </summary>

        [TestMethod]
        public void Login_Successful_with_Quanly()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
        }
        [TestMethod]
        public void Login_Successful_with_Cachieu()
        {
            textBox[1].SendKeys("cachieuqtsc");
            Thread.Sleep(2000);
            textBox[0].SendKeys("Passio@123");
            driver.FindElementByName("Đăng nhập").Click();
        }
        [TestMethod]
        public void Login_Successful_with_Casang()
        {
            textBox[1].SendKeys("casangqtsc");
            Thread.Sleep(2000);
            textBox[0].SendKeys("Passio@123");
            driver.FindElementByName("Đăng nhập").Click();
        }
        [TestMethod]
        public void Login_Successful_with_testmobile()
        {
            textBox[1].SendKeys("testmobile");
            Thread.Sleep(2000);
            textBox[0].SendKeys("Passio@123");
            driver.FindElementByName("Đăng nhập").Click();
        }
        [TestMethod]
        public void InputIncorrect()
        {
            textBox[1].SendKeys("abc");
            Thread.Sleep(2000);
            textBox[0].SendKeys("xyz");
            driver.FindElementByName("Đăng nhập").Click();
        }
        [TestMethod]
        public void UsernameRequired()
        {
            textBox[1].SendKeys("");
            Thread.Sleep(2000);
            textBox[0].SendKeys("xyz");
            driver.FindElementByName("Đăng nhập").Click();
        }
        [TestMethod]
        public void PasswordRequired()
        {
            textBox[1].SendKeys("abc");
            Thread.Sleep(2000);
            textBox[0].SendKeys("");
            driver.FindElementByName("Đăng nhập").Click();
        }


        /// <summary>
        /// /////////////////////////// Customer Test Case ////////////////////////////////////////////
        /// </summary>
        [TestMethod]
        public void CreateCustomer()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
            driver.FindElementById("btnConfig").Click();
            driver.FindElementById("btnPaymentMember").Click();
            driver.FindElementById("btnRegister").Click();
            driver.FindElementById("btnAddNewCustomer").Click();
            ReadOnlyCollection<IWebElement> txtCusName = driver.FindElementsById("txtCustomerName");
            txtCusName[0].SendKeys("abc");
            Thread.Sleep(2000);


            IWebElement txtPhone = driver.FindElementById("txtPhone");
            txtPhone.SendKeys("1231232132");


            //ReadOnlyCollection<IWebElement> ddlType = driver.FindElementsById("ddlType");
            //ddlType[0]
            Thread.Sleep(2000);
            IWebElement txtAddress = driver.FindElementById("txtAddress");
            txtAddress.SendKeys("Wisky Ho Chi Minh");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> txtDistrict = driver.FindElementsById("txtDistrict");
            txtDistrict[0].SendKeys("12");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> txtEmail = driver.FindElementsById("txtEmail");
            txtEmail[0].SendKeys("TestEmail@wisky.vn");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> txtCMND = driver.FindElementsById("txtCMND");
            txtCMND[0].SendKeys("12345678900");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> rdbMale = driver.FindElementsById("rdbMale");
            ReadOnlyCollection<IWebElement> rdbFemale = driver.FindElementsById("rdbFemale");
            rdbFemale[0].Click();

            rdbMale[0].Click();

            ReadOnlyCollection<IWebElement> txtCity = driver.FindElementsById("txtCity");
            txtCity[0].SendKeys("Ho CHi Minh");
            Thread.Sleep(2000);
            IWebElement btnRefresh = driver.FindElementById("btnRefreshInfo");
            btnRefresh.Click();
            IWebElement btnCancel = driver.FindElementById("btnCancel");
            btnCancel.Click();
            IWebElement btnCance2 = driver.FindElementById("btnCancel");
            btnCance2.Click();
            IWebElement btnBack2 = driver.FindElementById("btnBack2");
            btnBack2.Click();
            IWebElement btnLogOut = driver.FindElementById("btnLogout");
            btnLogOut.Click();
            IWebElement btnCance3 = driver.FindElementById("btnCancel");
            btnCance3.Click();

        }
        [TestMethod]
        public void SearchMembershipByPhone()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
            driver.FindElementById("btnConfig").Click();
            driver.FindElementById("btnPaymentMember").Click();
            driver.FindElementById("btnRegister").Click();
            IWebElement phone = driver.FindElementById("phone");
            phone.SendKeys("0582387005" + 058555);
            driver.FindElementById("btnSearchPhone").Click();
        }
        [TestMethod]
        public void SearchMembershipByID()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
            driver.FindElementById("btnConfig").Click();
            driver.FindElementById("btnPaymentMember").Click();
            driver.FindElementById("btnRegister").Click();
            IWebElement txtCardCode = driver.FindElementById("txtCardCode");
            driver.FindElementById("btnSearchMember").Click();
        }
        [TestMethod]
        public void VerifyMembership()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
            driver.FindElementById("btnConfig").Click();
            driver.FindElementById("btnPaymentMember").Click();
            IWebElement txtCardCode = driver.FindElementById("txtCardCode");
            txtCardCode.SendKeys("0582387005");
            driver.FindElementById("btnSearchMember").Click();
        }
        [TestMethod]
        public void VerifyMembership_notActivated()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
            driver.FindElementById("btnConfig").Click();
            driver.FindElementById("btnPaymentMember").Click();
            IWebElement txtCardCode = driver.FindElementById("txtCardCode");
            txtCardCode.SendKeys("112");
            driver.FindElementById("btnSearchMember").Click();
        }
        [TestMethod]
        public void VerifyUI()
        {
            textBox[1].SendKeys("quanly");
            Thread.Sleep(2000);
            textBox[0].SendKeys("passio2019");
            driver.FindElementByName("Đăng nhập").Click();
            driver.FindElementById("btnConfig").Click();
            driver.FindElementById("btnPaymentMember").Click();
            IWebElement txtCardCode = driver.FindElementById("txtCardCode");
            txtCardCode.SendKeys("0582387005");
        }
        [ClassInitialize]
        public static void loadForm(TestContext context)
        {
            LoadApp(context);
            IWebElement txtUsername = driver.FindElementById("txtUsername");
            IWebElement txtPassword = driver.FindElementById("txtPassword");
            //Assert.IsNotNull(txtUsername);
        }
    }
}
