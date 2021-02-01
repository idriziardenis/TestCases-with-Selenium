using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestCasesWithSelenium
{
    public static class Action
    {
        public static void InititalizeDriver(string driver, string url = "")
        {
            if (driver == "Chrome")
            {
                Driver.driver = new ChromeDriver();
            }
            else if (driver == "Firefox")
            {
                Driver.driver = new FirefoxDriver();
            }

            if (string.IsNullOrEmpty(url)) { url = Config.BaseUrl; }

            Driver.driver.Navigate().GoToUrl(url);
        }

        public static void MakeScreenshot(string filename)
        {
            string ScreenshotDirectory = Config.ScreenshotDir;
            Screenshot browserScreenshot = ((ITakesScreenshot)Driver.driver).GetScreenshot();
            browserScreenshot.SaveAsFile(ScreenshotDirectory + @"\" + filename + ".png", ScreenshotImageFormat.Png);
        }
    }
}
