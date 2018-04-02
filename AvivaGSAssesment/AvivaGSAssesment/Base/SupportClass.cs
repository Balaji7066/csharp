using AvivaGSAssesment.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvivaGSAssesment.Base
{
    public class SupportClass
    {

        public static IWebDriver driver { get; set; }

        public static void OpenBwoser(string browser)
        {
            switch (browser)
            {
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Console.WriteLine("IE Initiated and Lanuched Browser");
                    break;
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Console.WriteLine("Chrome Driver Initiated and Lanuched Browser");
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
                    Console.WriteLine("Chrome Driver Initiated and Lanuched Browser");
                    break;
                default:
                    Console.WriteLine("Invalid Browser!!");
                    break;
            }
        }
        public static void TakeScreenshot(IWebDriver driver)
        {
            ITakesScreenshot ssdriver = driver as ITakesScreenshot;
            Screenshot screenshot = ssdriver.GetScreenshot();
            var tempFileName = Path.Combine(Directory.GetCurrentDirectory(), Path.GetFileNameWithoutExtension(Path.GetTempFileName())) + ".jpg";
            screenshot.SaveAsFile(tempFileName, ScreenshotImageFormat.Jpeg);
        }

        public static void NavigateToUrl(String url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public static void CloseBrowser()
        {
            driver.Quit();

        }
    }
}
