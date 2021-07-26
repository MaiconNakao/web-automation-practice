using qa_mobile_regresion_tests.Elements;

namespace qa_mobile_regresion_tests.Pages
{
    public class LoginPage
    {
        public void LoginWeb(string email, string senha)
        {
            LoginElements.MenuLogin().Click();
            LoginElements.InserirEmail().SendKeys(email);
            LoginElements.InserirSenha().SendKeys(senha);
            LoginElements.BotaoEntrar().Click();
        }
    }
}
