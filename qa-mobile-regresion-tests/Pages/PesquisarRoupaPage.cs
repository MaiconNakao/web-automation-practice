using qa_mobile_regresion_tests.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace qa_mobile_regresion_tests.Pages
{
    public class PesquisarRoupaPage
    {
        public void AdicionarRoupaAoCarrinho(string vestido)
        {
            PesquisarRoupaElements.TxtPesquisar().SendKeys(vestido);
            PesquisarRoupaElements.BtnPesquisar().Click();
            PesquisarRoupaElements.BtnVisualizar().Click();
            PesquisarRoupaElements.BtnAdicionarAoCarrinho().Click();
            PesquisarRoupaElements.BtnContinuarComprando().Click();

        }
    }
}
