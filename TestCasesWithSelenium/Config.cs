using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCasesWithSelenium
{
    public class Config
    {
        public static string BaseUrl = "https://www.riinvest.net/";
        public static string ScreenshotDir = @"C:\Users\Ardenis\Desktop\Schreenshoots";


        public static class AlertMessages
        {
            public static string ValidLink = "Linku eshte valid";
            public static string InvalidLink = "Linku eshte invalid";
            public static string MesazhiiMire = "Kohëzgjatja e përafërt 1 orë e 3 minuta";
        }
    }
}
