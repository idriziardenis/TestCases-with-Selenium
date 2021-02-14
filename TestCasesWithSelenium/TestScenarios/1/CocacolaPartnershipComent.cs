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

namespace TestCasesWithSelenium.TestScenarios._1
{
    class CocacolaPartnershipComent
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
        public void Valid()
        {

          
            Driver.driver.Navigate().GoToUrl(UrlClass.CocacolaUrl);
            Thread.Sleep(2000);
           
            Driver.driver.FindElement(By.Id("comment-author")).SendKeys(CocacolaComment.Name);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("comment-email")).SendKeys(CocacolaComment.Email);
            Thread.Sleep(1000);
        //    Driver.driver.FindElement(By.Id("cptch_input")).SendKeys(CocacolaComment.Solve); nuk po mund te mbushet as me tastier captcha input
          //  Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("comment")).SendKeys(CocacolaComment.message);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("comment-submit")).Click();
          
            Assert.IsTrue(Driver.driver.PageSource.Contains(CocacolaComment.expected));
        }
    }
}
