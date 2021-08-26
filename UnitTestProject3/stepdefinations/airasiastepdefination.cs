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
    public sealed class airasiastepdefination : basepageobject
    {


        Global DriverContext;
        public airasiastepdefination(Global DriverContext) : base(DriverContext)
        {
            this.DriverContext = DriverContext;
        }

        [Given(@"User Launched airasia portal")]
        public void GivenUserLaunchedAirasiaPortal()
        {
           hp.airahomepage();
        }

        [When(@"User selects To and From destination")]
        public void WhenUserSelectsToAndFromDestination()
        {
            hp.selectingplaces();
        }

        [When(@"User search for Flights")]
        public void WhenUserSearchForFlights()
        {
            hp.searchforflight();
        }

        [When(@"User selects any flight")]
        public void WhenUserSelectsAnyFlight()
        {
            gp.selectprice();
        }

        [When(@"User click on continue")]
        public void WhenUserClickOnContinue()
        {
            gp.clickonconti();
        }

        [Then(@"Verify user redirect to guest details page")]
        public void ThenVerifyUserRedirectToGuestDetailsPage()
        {
            gp.verifyingtheguestpage();
        }
    }
}

