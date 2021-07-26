using NUnit.Framework;
using qa_mobile_regresion_tests.Elements;
using qa_mobile_regresion_tests.Pages;

namespace qa_mobile_regresion_tests.Tests
{
    [TestFixture]
    public class Login 
    {
        public LoginPage login = new LoginPage();
        public MinhaContaPage minhaConta = new MinhaContaPage();

        [TestCase]
        public void Login_Web()
        {
            //Arrange
            string email = "nakao.mds@gmail.com";
            string senha = "@Lol123";

            //Act
            login.LoginWeb(email, senha);

            //Assertb
            Assert.Multiple(() =>
            {
                minhaConta.ValidarMinhaConta();
                Assert.IsTrue(MinhaContaElements.TxtMeusDadosPessoais().Displayed);
            });
            
        }
    }
}
