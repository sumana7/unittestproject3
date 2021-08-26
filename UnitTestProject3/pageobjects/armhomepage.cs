using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject3.utils;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace UnitTestProject3.pageobjects
{
    public class armhomepage :pagebases
    {
        private Global global;
        public armhomepage(Global global) : base(global)
        {
            this.global = global;
        }

        [FindsBy(How = How.XPath, Using = "//a[@title='Accept and hide this message ']")]
        private IWebElement cookies;

        [FindsBy(How = How.XPath,Using = "(//div[@class='c-footer__section column'])[2]")]
        private IWebElement text;


        
        public void navigatetoarm()
        {
          
            var url = Globalvariables.ArmpageUrl;
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(3000);
        }
        public void acceptingcookies()
        {
            cookies.Click();
            Thread.Sleep(3000);
        }

      
        public void testingcopygrighttextandlinks()
        {
            string s = text.Text;
            try
            {
                Assert.AreEqual(s, "Copyright © 1995-2021 Arm Limited (or its affiliates). All rights reserved.");
                Console.WriteLine("-----user is be able to view the copyright section text and links----");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        
    }
}

    

