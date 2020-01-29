using Gauge.CSharp.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaugeDemoCsharp.Pages.Util
{
    class BaseClass
    {
        public static IWebDriver driver;

        public void SendKeys(By locator, string text)
        {
            WaitUntilElementToBeClickable(locator);
            IWebElement element = driver.FindElement(locator);
            element.Clear();
            element.SendKeys(text);
        }

        public void Click(By locator)
        {
            WaitUntilElementToBeClickable(locator);
            IWebElement element = driver.FindElement(locator);
            element.Click();

        }

        public string GetVisibleText(By locator)
        {
            WaitUntilElementToBeClickable(locator);
            IWebElement element = driver.FindElement(locator);
            return element.Text;
        }

        public void SwitchToIFrame(string frameId)
        {
            driver.SwitchTo().Frame(frameId);
        }

        public void WaitUntilElementToBeClickable(By locator)
        {   
            new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        public void AreEqual(DateTime expected, DateTime actual, string message)
        {
            WriteMessage("Expected: " + expected + "  Actual: " + actual + "  Message: " + message);
            Assert.AreEqual(expected, actual, message);
        }

        public void AreEqual(bool expected, bool actual, string message)
        {
            WriteMessage("Expected: " + expected + "  Actual: " + actual + "  Message: " + message);
            Assert.AreEqual(expected, actual, message);
        }

        public void AreEqual(string expected, object actual, string message)
        {
            WriteMessage("Expected: " + expected + "  Actual: " + actual + "  Message: " + message);
            Assert.AreEqual(expected, actual, message);
        }

        public void AreEqual(int expected, int actual, string message)
        {
            WriteMessage("Expected: " + expected + "  Actual: " + actual + "  Message: " + message);
            Assert.AreEqual(expected, actual, message);
        }

        public void WriteMessage(string message)
        {
            Console.WriteLine(message);
            GaugeMessages.WriteMessage(message);
        }

    }

}
