using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Support.UI;

namespace WebDriverSelectors
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = FirefoxDriverService.CreateDefaultService();
            var driver = new FirefoxDriver(service);
            var notExpected = string.Empty;

            driver.Url = @"file:///C:/Code/Selenium/WebDriverDemo/WebDriverSelectors/SelectOptionPage.html";
            var colorOption = driver.FindElement(By.Id("color1"));

            var colorSelectOption = new SelectElement(colorOption);

            colorSelectOption.SelectByValue("yellow");
            colorOption.Click();
        }

        static void SelectOptionOldWay(string[] args)
        {
            // Arrange
            var service = FirefoxDriverService.CreateDefaultService();
            var driver = new FirefoxDriver(service);
            var notExpected = string.Empty;

            // Act
            driver.Url = @"file:///C:/Code/Selenium/WebDriverDemo/WebDriverSelectors/SelectOptionPage.html";
            var colorOption = driver.FindElement(By.Id("color1"));
            var actual = colorOption.GetAttribute("value");

            // Assert
            Assert.AreNotEqual(actual, notExpected);
        }

        static void RadioButton(string[] args)
        {

            var service = FirefoxDriverService.CreateDefaultService();
            var driver = new FirefoxDriver(service);
            driver.Url = @"file:///C:/Code/Selenium/WebDriverDemo/WebDriverSelectors/RadioButtonPage.html";

            var radioButton = driver.FindElements(By.Name("color"))[1];
            radioButton.Click();


        }
    }
}

