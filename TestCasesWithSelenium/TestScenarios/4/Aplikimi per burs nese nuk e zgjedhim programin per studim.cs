﻿using NUnit.Framework;
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
    class Aplikimi_per_burs_nese_nuk_e_zgjedhim_programin_per_studim
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
            //nuk i gjajke qito elemente 
            Useri user = new Useri();
            Useri useriqeduhettapranojm = new Useri();
            Driver.driver.FindElement(By.XPath($"//a[@href='https://international.riinvest.net/']")).Click();
            Thread.Sleep(4000);
            Driver.driver.FindElement(By.XPath($"//a[@href='https://international.riinvest.net/admissions/']")).Click();
            Thread.Sleep(8000);
            Driver.driver.FindElement(By.XPath($"//input[@placeholder='First']")).SendKeys(user.Name);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781308-5']")).SendKeys(user.surname);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781308-2']")).SendKeys(user.Email);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781310']")).SendKeys(user.BDay);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781313-1']")).SendKeys("123");
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781313-2']")).SendKeys("123");
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781313-3']")).SendKeys("123");
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($" //input[@name='control8797202']")).SendKeys("asd");
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath($"//input[@name='control8781319-0']")).Click();


            //input[@name="control8797202"]
            Assert.AreSame(useriqeduhettapranojm, user);
        }
    }
}
