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
    public sealed class NikeStepDefinition : basepageobject

    {

        Global DriverContext;
        public NikeStepDefinition(Global DriverContext) : base(DriverContext)
        {
            this.DriverContext = DriverContext;
        }
        [Given(@"User launched Nike portal")]
        public void GivenUserLaunchedNikePortal()
        {
            Nhp.navigatetonike();
        }

        [When(@"User Navigate to All Shoes from Men")]
        public void WhenUserNavigateToAllShoesFromMen()
        {
            Nhp.selectingallshoes();
        }

        [Then(@"Verify the Men shoes page is Displayed")]
        public void ThenVerifyTheMenShoesPageIsDisplayed()
        {
            Nas.sortingtheprice();
        }

        [When(@"User sort the shoes from High to Low")]
        public void WhenUserSortTheShoesFromHighToLow()
        {
            Nas.selectingshoe();
        }

        [When(@"User selects any shoe")]
        public void WhenUserSelectsAnyShoe()
        {
            Abp.selecting();
        }

        [When(@"User select the size and click on Add to Bag")]
        public void WhenUserSelectTheSizeAndClickOnAddToBag()
        {
            Vts.clickoncart();
        }

        [Then(@"verify if selected product has been added to cart successfully")]
        public void ThenVerifyIfSelectedProductHasBeenAddedToCartSuccessfully()
        {
            Vts.verifyingtheproduct();
        }
    }
}
