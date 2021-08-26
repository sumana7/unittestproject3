using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.utils
{
    public class baseclass
    {
        public baseclass(IWebDriver Driver)
        {
            this.Driver = Driver;
        }
        public IWebDriver Driver { get; set; }
    }
}
