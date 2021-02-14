using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TestCasesWithSelenium.Classes;

namespace TestCasesWithSelenium.TestScenarios._4
{
    class Ndryshimi_i_Gjuhes
    {
        string mesazhi1 = "My Riinvest";
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

            Driver.driver.FindElement(By.XPath($"(//img[@width=22][@height=16])[1]")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.riinvest.net/en/']")).Click();


            Thread.Sleep(1000);

            Assert.IsTrue(Driver.driver.PageSource.Contains(mesazhi1));
        }


    }
}
