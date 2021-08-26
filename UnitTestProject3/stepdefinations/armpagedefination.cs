using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTestProject3.pageobjects;
using UnitTestProject3.utils;


namespace UnitTestProject3.stepdefinations
{
    [Binding]
    public sealed class armpagedefination : basepageobject
    {
        Global DriverContext;
        public armpagedefination(Global DriverContext) : base(DriverContext)
        {
            this.DriverContext = DriverContext;
        }

        [Given(@"user is on arm home page")]
        public void GivenUserIsOnArmHomePage()
        {
            Console.WriteLine("-------hi-----");
            Ahp.navigatetoarm();
        }

        [When(@"user accepts the cookie bar")]
        public void WhenUserAcceptsTheCookieBar()
        {
            Ahp.acceptingcookies();
        }

        [Then(@"user should be able to view the copyright section text and links")]
        public void ThenUserShouldBeAbleToViewTheCopyrightSectionTextAndLinks()
        {
            Ahp.testingcopygrighttextandlinks();
        }

        [Then(@"user should be able to view the Legal section text and links")]
        public void ThenUserShouldBeAbleToViewTheLegalSectionTextAndLinks()
        {
            lvp.verifyinglinkcookiepolicy();
            lvp.verifyinglinktermsofuse();
            lvp.verifyinglinkprivacypolicy();
        }

        [Then(@"user should be able to view the Home page title")]
        public void ThenUserShouldBeAbleToViewTheHomePageTitle()
        {
            Tvc.armtitle();
        }

    }
}