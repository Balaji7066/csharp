using AvivaGSAssesment.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivaGSAssesment.Pages
{
    class AvivaSearchPage
    {
        public AvivaSearchPage()
        {
            PageFactory.InitElements(SupportClass.driver, this);
        }
        [FindsBy(How = How.XPath, Using = ".//h3/a")]
        public IList<IWebElement> totallinks { get; set; }

        public void resultsPage(int linknumber)
        {
            Console.WriteLine("Link text of 5 th link is:" + totallinks.ElementAt(linknumber).Text);
        }
    }
}
