using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace qa_mobile_regresion_tests
{
    [SetUpFixture]
    public class Setup
    {

        public static IWebDriver webDriver;

        [OneTimeSetUp]
        public void SetUp()
        {
            WebSetupLocalRun();
        }

        public void WebSetupLocalRun()
        {
            if (webDriver == null)
            {
                webDriver = new ChromeDriver
                {
                    Url = "http://automationpractice.com/index.php"
                };
                webDriver.Manage().Window.Maximize();
            }            
        }      

        [OneTimeTearDown]
        public static void TearDown()
        {
            webDriver.Quit();
        }
    }
}
