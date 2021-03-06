﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace seleniumDemo
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driverFF;
        static IWebDriver driverGC;

        [AssemblyInitialize]
        public static void Setup(TestContext context)
        {
            driverFF = new FirefoxDriver();
            driverGC = new ChromeDriver(@"C:\chromedriver_win32");
        }

        [TestMethod]
        public void TestChromeDriver()
        {
            driverGC.Navigate().GoToUrl("http://www.google.com");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverGC.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }

        [TestMethod]
        public void TestFirefoxDriver()
        {
            driverFF.Navigate().GoToUrl("http://www.google.com");
            driverFF.FindElement(By.Id("lst-ib")).SendKeys("Selenium");
            driverFF.FindElement(By.Id("lst-ib")).SendKeys(Keys.Enter);
        }
    }
}
