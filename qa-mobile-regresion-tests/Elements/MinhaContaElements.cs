using OpenQA.Selenium;

namespace qa_mobile_regresion_tests.Elements
{
    public class MinhaContaElements : Services
    {        
        public static IWebElement TxtMeusDadosPessoais()
        {
            return WaitForElementByXPath("//*[@id='center_column']/div/div[1]/ul/li[4]/a");
        }
    }
}
