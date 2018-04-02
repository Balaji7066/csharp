using AvivaGSAssesment.Base;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace AvivaGSAssesment.Hooks
{
    [Binding]
    public class GSHooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        
        [BeforeScenario]
        public void Initialize(string browser)
        {
            SupportClass.OpenBwoser(browser);
            
        }

        [AfterScenario]
        public void AfterScenario()
        {
            SupportClass.CloseBrowser();
        }
    }
}
