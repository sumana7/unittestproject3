using Microsoft.VisualStudio.TestTools.UnitTesting;
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
     public class verifiyingtheshoe : pagebases
    {
        private Global global;
        public verifiyingtheshoe(Global global) : base(global)
        {
            this.global = global;
        }


        [FindsBy(How = How.XPath, Using = "(//a[@data-type='click_navCart'])[2]")]
        public IWebElement cart;


        public void clickoncart()
        {
            cart.Click();
            Thread.Sleep(3000);
        }
        public void verifyingtheproduct()
        {
            string s = cart.Text;
            try
            {
                Assert.AreEqual(s, "Nike Mercurial Superfly 8 Elite CR7 FG");
                Console.WriteLine("selected product has successfully added to cart");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
     }
}
