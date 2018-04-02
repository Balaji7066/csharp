using AvivaGSAssesment.Base;
using AvivaGSAssesment.Pages;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;

namespace AvivaGSAssesment.StepDefinition
{
    
    [Binding]
    
    public  class GoogleSearchSteps
    {
        GoogleHomePage hpage = new GoogleHomePage();
        AvivaSearchPage spage = new AvivaSearchPage();

        [Given(@"Open the google site")]
        public void GivenOpenTheGoogleSite()
        {
            Console.WriteLine("Navigate to Application URL");
            SupportClass.NavigateToUrl("https://www.google.com");
        }

        [Given(@"I have entered '(.*)' into the google text box")]
        public void GivenIHaveEnteredIntoTheGoogleTextBox(string keyword)
        {
            
            hpage.EnterText(keyword);

        }

        [When(@"I click the search button")]
        public void WhenIClickTheSearchButton()
        {
            hpage.ClickSearch();
        }

        [Then(@"the resulted (.*)th link should be printed")]
        public void ThenTheResultedThLinkShouldBePrinted(int link)
        {

            spage.resultsPage(5);
            
        }

        [Then(@"Aviva results should be displayed")]
        public void ThenAvivaResultsShouldBeDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
