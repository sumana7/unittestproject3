using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UnitTestProject3.utils;

namespace UnitTestProject3.pageobjects
{
    public class addtobagepage :pagebases
    {
        private Global global;
        public addtobagepage(Global global) : base(global)
        {
            this.global = global;
        }


        [FindsBy(How = How.XPath, Using = "//label[text()='UK 9']")]
        public IWebElement size;
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Add to Bag']")]
        public IWebElement addtobag;

        public void selecting()
        {
            size.Click();
            Thread.Sleep(3000);
            addtobag.Click();
            Thread.Sleep(3000);

        }
            
    }
}
