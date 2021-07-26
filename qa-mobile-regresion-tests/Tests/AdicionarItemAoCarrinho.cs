using NUnit.Framework;
using qa_mobile_regresion_tests.Pages;
using System;
using System.Collections.Generic;
using System.Text;

namespace qa_mobile_regresion_tests.Tests
{
    [TestFixture]
    public class AdicionarItemAoCarrinho
    {
        public PesquisarRoupaPage pesquisarRoupaPage = new PesquisarRoupaPage();
        

        [TestCase]
        public void AdicionarRoupa()
        {
            //Arrange
            string vestido = "dresses";

            //Act
            pesquisarRoupaPage.AdicionarRoupaAoCarrinho(vestido);

            //Assertb
            //Assert.Multiple(() =>
            //{
            //    minhaConta.ValidarMinhaConta();
            //    Assert.IsTrue(MinhaContaElements.TxtMeusDadosPessoais().Displayed);
            //});

        }
    }
}