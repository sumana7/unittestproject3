using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.utils
{
    public class browsersupport
    {
        public static IWebDriver Initialize()
        {
            IWebDriver Driver = new ChromeDriver();
            return Driver;
        }
    }
}
