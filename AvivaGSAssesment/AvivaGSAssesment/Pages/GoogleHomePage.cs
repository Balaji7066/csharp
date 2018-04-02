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
     class GoogleHomePage
    {
        public GoogleHomePage()
        {
            PageFactory.InitElements(SupportClass.driver, this);
        }

        [FindsBy(How = How.Id, Using = "q")]
        public IWebElement SearchText { get; set; }


        [FindsBy(How = How.Name, Using = "btnG")]
        public IWebElement SearchButton { get; set; }

        public void EnterText(String keyword)
        {
            SearchText.SendKeys(keyword);
        }


            public void ClickSearch()
        {
            SearchButton.Click();
        }
    }
}
