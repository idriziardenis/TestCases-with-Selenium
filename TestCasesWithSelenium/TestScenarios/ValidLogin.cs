using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCasesWithSelenium.TestScenarios
{
    class ValidLogin
    {

        [SetUp]
        public void SetupBeforeEachTest()
        {
            Action.InititalizeDriver("Chrome", Config.BaseUrl);
        }

        [TearDown]
        public void AfterEachTest()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Action.MakeScreenshot(TestContext.CurrentContext.Test.Name);
            }
            Driver.driver.Quit();
        }

        [Test]
        public void Valid_Login()
        {
            IWebElement riinvestiIm = Driver.driver.FindElement(By.ClassName("menu-item-5"));

            riinvestiIm.Click();
            Thread.Sleep(5000); // Me prit derisa tloadohet faqja
            Driver.driver.FindElement(By.Id("LoginControl_UserName")).SendKeys(Config.Credentials.Invalid.Username);
            Driver.driver.FindElement(By.Id("LoginControl_Password")).SendKeys(Config.Credentials.Invalid.Password);
            Driver.driver.FindElement(By.Id("LoginControl_btnLogin")).Click();

            Assert.IsTrue(Driver.driver.PageSource.Contains(Config.AlertMessages.InvalidCredentials));
        }
    }
}
