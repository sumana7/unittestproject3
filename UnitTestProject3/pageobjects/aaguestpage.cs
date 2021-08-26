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
   
        public class  aaguestpage : pagebases
        {
            private Global global;
            public aaguestpage(Global global) : base(global)
            {
                this.global = global;
            }

            [FindsBy(How = How.XPath, Using = "(//span[@class='input-box'])[1]")]
            public IWebElement price;

            [FindsBy(How = How.XPath, Using = "//button[text()='Continue']")]
            public IWebElement conti;

            [FindsBy(How = How.XPath, Using = "//span[text()='Guest Details']")]
            public IWebElement nextpage;

            public void selectprice()
            {
                price.Click();
                Thread.Sleep(2000);
            }
            public void clickonconti()
            {
                conti.Click();
                Thread.Sleep(3000);
            }
            public void verifyingtheguestpage()
            {
                string s = nextpage.Text;
                try
                {
                    Assert.AreEqual(s, "Guest Details");
                    Console.WriteLine("user is able redirect to guest page");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    
}

