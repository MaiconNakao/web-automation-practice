using OpenQA.Selenium;

namespace qa_mobile_regresion_tests.Elements
{
    public class LoginElements : Services
    {
        public static IWebElement MenuLogin()
        {
            return WaitForElementByXPath("//*/div[2]/div/div/nav/div[1]/a");
        }

        public static IWebElement InserirSenha()
        {
            return WaitForElement("passwd");
        }

        public static IWebElement InserirEmail()
        {
            return WaitForElement("email");
        }

        public static IWebElement BotaoEntrar()
        {
            return WaitForElement("SubmitLogin");
        }

    }
}
