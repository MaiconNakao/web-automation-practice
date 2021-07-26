using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace qa_mobile_regresion_tests
{
    public class Services : Setup
    {
        public static IWebElement WaitForElement(string elementId)
        {
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 30));
            IWebElement elementToBeClickable = null;
            var element = wait.Until(condition =>
            {
                try
                {
                    elementToBeClickable = webDriver.FindElement(By.Id(elementId));
                    return elementToBeClickable.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            return elementToBeClickable;
        }

        public static IWebElement WaitForElementByXPath(string elementId)
        {
            var wait = new WebDriverWait(webDriver, new TimeSpan(0, 0, 15));
            IWebElement elementToBeClickable = null;
            var element = wait.Until(condition =>
            {
                try
                {
                    elementToBeClickable = webDriver.FindElement(By.XPath(elementId));
                    return elementToBeClickable.Displayed;
                }
                catch (StaleElementReferenceException)
                {
                    return false;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            });

            return elementToBeClickable;
        }
    }
}
