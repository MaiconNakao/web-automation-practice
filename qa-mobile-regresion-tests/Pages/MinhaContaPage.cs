using NUnit.Framework;
using qa_mobile_regresion_tests.Elements;

namespace qa_mobile_regresion_tests.Pages
{
    public class MinhaContaPage
    {
        public void ValidarMinhaConta()
        {
            Assert.IsTrue(MinhaContaElements.TxtMeusDadosPessoais().Displayed);
        }

    }
}
