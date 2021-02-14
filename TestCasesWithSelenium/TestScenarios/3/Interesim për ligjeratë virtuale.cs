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

namespace TestCasesWithSelenium.TestScenarios._3
{
    class Interesim_për_ligjeratë_virtuale
    {

        //nuk i gjajke qito elemente 
        string mesazhi = "Something is not right! Errors are highlighted below.";
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
            //nuk i gjajke qito elemente 
            Driver.driver.Navigate().GoToUrl("https://www.riinvest.net/ligjerate-virtuale/");
            Thread.Sleep(8000);
            Driver.driver.FindElement(By.XPath($"//input[@placeholder='First']")).SendKeys(Aplikimi.Emri);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954975-2")).SendKeys(Aplikimi.Mbiemri);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954976")).SendKeys(Aplikimi.Datlindja);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954978")).SendKeys(Aplikimi.Emaili);
            Thread.Sleep(1000);

            Driver.driver.FindElement(By.Id("id123-control8954979-1")).SendKeys(Aplikimi.Nrtel1);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954979-2")).SendKeys(Aplikimi.Nrtel2);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954979-3")).SendKeys(Aplikimi.Nrtel3);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954983")).SendKeys(Aplikimi.Shkollaemesm);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954984")).SendKeys(Aplikimi.Komuna);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.Id("id123-control8954985")).SendKeys(Aplikimi.Kukenidegjuar);
            Thread.Sleep(1000);

            try
            {
                Driver.driver.FindElement(By.XPath($"//input[@name='control8781319-0']"));
                Assert.IsTrue(true);
            }
            catch (NoSuchElementException e)
            {

                throw e;
            }
        }
    }
}
