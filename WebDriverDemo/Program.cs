using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

using System.Linq;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firefoxDriverService = FirefoxDriverService.CreateDefaultService();
            var driver = new FirefoxDriver(firefoxDriverService);
            driver.Url = "http://www.google.com/";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Ziaullah Khan Github");
            searchBox.Submit();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));

            var imagesLink = driver.FindElements(By.ClassName("r"))[0];
            imagesLink.Click();
        }
    }
}
