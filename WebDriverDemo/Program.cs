﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var firefoxDriverService = FirefoxDriverService.CreateDefaultService();
            var driver = new FirefoxDriver(firefoxDriverService);
            driver.Url = "http://www.google.com/";
        }
    }
}
