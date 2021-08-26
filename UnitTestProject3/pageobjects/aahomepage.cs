using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject3.utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace UnitTestProject3.pageobjects
{
    public class aahomepage : pagebases
    { 
            private Global global;
            public aahomepage(Global global) : base(global)
            {
                this.global = global;
            }

            [FindsBy(How = How.XPath, Using = "(//div[@class='flight-search-source-code'])[1]")]
            public IWebElement from;

            [FindsBy(How = How.XPath, Using = "(//button[@id='list-item'])[1]")]
            public IWebElement fromcity;

            [FindsBy(How = How.XPath, Using = "(//button[@id='list-item'])[2]")]
             public IWebElement tocity;

            [FindsBy(How = How.XPath, Using = "//div[@id='start-date-input-button']")]
            public IWebElement cale;

            [FindsBy(How = How.XPath, Using = "(//div[text()='25'])[2]")]
             public IWebElement dt;

            [FindsBy(How = How.XPath, Using = "//button[@class='btn-flight']")]
            public IWebElement searchflight;

            public void airahomepage()
            {
                var url = Globalvariables.ArmpageUrl;
                Driver.Navigate().GoToUrl(url);
                Driver.Manage().Window.Maximize();
                Thread.Sleep(3000);
            }

            public void selectingplaces()
            {
                from.Click();
                Thread.Sleep(2000);
                fromcity.Click();
                Thread.Sleep(2000);
                tocity.Click();
                cale.Click();
                Thread.Sleep(1000);
                dt.Click();
                Thread.Sleep(2000);
            }

            public void searchforflight()
            {
                searchflight.Click();
                Thread.Sleep(5000);

            }

        
    }
}
