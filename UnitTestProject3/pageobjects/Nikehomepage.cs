using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject3.utils;

namespace UnitTestProject3.pageobjects
{
     public class Nikehomepage : pagebases
     {
        
            private Global global;
            public Nikehomepage(Global global) : base(global)
            {
                this.global = global;
            }


            [FindsBy(How = How.XPath, Using = "//a[@aria-label='Men']")]
            private IWebElement men;

           [FindsBy(How = How.XPath, Using = "//a[@data-path='men:shoes:all shoes']")]
            private IWebElement allshoes;

        public IWebDriver driver;

        public void navigatetonike()
        {

            var url = Globalvariables.ArmpageUrl;
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }

        public void selectingallshoes()
        {
            Actions a = new Actions(Driver);
            a.MoveToElement(men).Build().Perform();
            a.Click(allshoes).Build().Perform();
            Thread.Sleep(2000);
            
        }

        




        }

}
