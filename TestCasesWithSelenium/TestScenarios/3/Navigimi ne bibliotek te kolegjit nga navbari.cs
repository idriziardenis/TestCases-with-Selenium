using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCasesWithSelenium.TestScenarios._3
{
    class Navigimi_ne_bibliotek_te_kolegjit_nga_navbari
    {
        string mesazhi = "Laboratoret";
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
        public void Valid()
        {

            // Me prit derisa tloadohet faqja
          
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.riinvest.net/library/']")).Click();

            Thread.Sleep(1000);

            Assert.IsTrue(Driver.driver.PageSource.Contains("Biblioteka"));
        }
    }
}
