using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject3.utils
{
    public class Global
    {
        public IWebDriver Driver { get; set; }
        public string FeatureName { get; set; }
    }
}
