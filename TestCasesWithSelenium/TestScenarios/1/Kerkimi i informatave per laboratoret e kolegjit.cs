using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCasesWithSelenium.TestScenarios._1
{
    class Kerkimi_i_informatave_per_laboratoret_e_kolegjit
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
            Driver.driver.FindElement(By.ClassName("mega-menu-link")).Click();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.riinvest.net/zyra-e-financave/']"));

            Thread.Sleep(1000);

            Assert.IsTrue(Driver.driver.PageSource.Contains(mesazhi));
        }
    }
}
