using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using UnitTestProject3.utils;

namespace UnitTestProject3.stepdefinations
{
    [Binding]
    public class Hooks
    {
        private Global browser;

        public Hooks(Global browser)
        {
            this.browser = browser;
        }

        [BeforeScenario]
        public void BeforeScenario(FeatureContext fcontext, ScenarioContext scontext)
        {
            browser.Driver = browsersupport.Initialize();
            browser.FeatureName = fcontext.FeatureInfo.Title;
        }

        [AfterScenario]
        public void AfterScenario()
        {

            browser.Driver?.Quit();
        }
    }
}
