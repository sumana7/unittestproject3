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
    public class linksverify : pagebases
    {
        private Global global;
        public linksverify(Global global) : base(global)
        {
            this.global = global;
        }
        //linkstoverifyarmcookies

        [FindsBy(How = How.XPath, Using = "(//li[@class='o-list__item c-footer__legal-link'])[1]")]
        public IWebElement Cookiespolicy;

        [FindsBy(How = How.XPath, Using = "(//li[@class='o-list__item c-footer__legal-link'])[2]")]
        public IWebElement Termsofuse;

        [FindsBy(How = How.XPath, Using = "(//li[@class='o-list__item c-footer__legal-link'])[3]")]
        public IWebElement Privacypolicy;

        //verifyxpath
        [FindsBy(How = How.XPath, Using = "//div[@class='c-masthead__slider__item__content__theme__title']")]
        public IWebElement Verifylink;

        public void verifyinglinkcookiepolicy()
        {
            Cookiespolicy.Click();
            Thread.Sleep(2000);
            string t = Verifylink.Text;
            try
            {
                Assert.AreEqual(t, "COOKIE POLICY");
                Console.WriteLine("Cookie link is verified");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Thread.Sleep(3000);
        }
        public void verifyinglinktermsofuse()
        {
            Termsofuse.Click();
            Thread.Sleep(2000);
            string t = Verifylink.Text;
            try
            {
                Assert.AreEqual(t, "TERMS AND CONDITIONS");
                Console.WriteLine(" Terms And Conditions link verified");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Thread.Sleep(3000);
        }
        public void verifyinglinkprivacypolicy()
        {
            Privacypolicy.Click();
            Thread.Sleep(2000);
            string t = Verifylink.Text;
            try
            {
                Assert.AreEqual(t, "PRIVACY POLICY");
                Console.WriteLine("Privacy policy link is verified");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

    }
}
    

