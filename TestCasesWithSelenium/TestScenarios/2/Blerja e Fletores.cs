using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestCasesWithSelenium.TestScenarios._2
{
    class Blerja_e_Fletores
    {
        string mesazhi = "Mesazhi duhet te jet pagesa eshte perfunduar me sukses ";
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
          Driver.driver.FindElement(By.XPath($"//a[@href='https://www.riinvest.net/riinvest-shop/']")).Click();
            Thread.Sleep(4000);
            

            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.riinvest.net/product/fletore/']")).Click(); 
            Thread.Sleep(4000);
            Driver.driver.FindElement(By.ClassName("single_add_to_cart_button"));
            Thread.Sleep(4000);
            Driver.driver.FindElement(By.XPath($"//button[@value]")).Click();
            Thread.Sleep(4000);
            Driver.driver.FindElement(By.XPath($"//a[@href='https://www.riinvest.net/shop/checkout/']")).Click();
            Thread.Sleep(4000);
            Driver.driver.FindElement(By.Id("billing_first_name")).SendKeys("Ardenis");
            Driver.driver.FindElement(By.Id("billing_last_name")).SendKeys("Idrizi");
            Driver.driver.FindElement(By.Id("billing_address_1")).SendKeys("te rruga");
            Driver.driver.FindElement(By.Id("billing_city")).SendKeys("Ferizaj");
            Driver.driver.FindElement(By.Id("billing_postcode")).SendKeys("1241414");
            Driver.driver.FindElement(By.Id("billing_phone")).SendKeys("09312");
            Driver.driver.FindElement(By.Id("billing_email")).SendKeys("ardenis.idrizi@riinvst.net");

            Driver.driver.FindElement(By.Id("place_order"));// edhe klikohet po nuk po du me bo order 







            Assert.IsTrue(Driver.driver.PageSource.Contains("Payment"));
        }
    }
}
