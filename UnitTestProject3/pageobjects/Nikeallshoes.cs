using OpenQA.Selenium;
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
     public class Nikeallshoes : pagebases
     {
        private Global global;
        public Nikeallshoes(Global global) : base(global)
        {
            this.global = global;
        }
        
        [FindsBy(How = How.XPath, Using = "//button[@aria-label='Sort By']")]
        public IWebElement sortby;
        [FindsBy(How = How.XPath, Using = "//button[text()='Price: High-Low']")]
        public IWebElement price;
        [FindsBy(How = How.XPath, Using = "(//a[@aria-label='Nike Air Zoom Alphafly NEXT%'])[1]")]
        public IWebElement shoess;
        public void sortingtheprice()
        {
            sortby.Click();
            Thread.Sleep(3000);
            price.Click();
            Thread.Sleep(7000);

        }
        public void selectingshoe()
        {
            
            shoess.Click();
            
        }   

     }
}
