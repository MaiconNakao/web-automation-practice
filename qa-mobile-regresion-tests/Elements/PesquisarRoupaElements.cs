using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace qa_mobile_regresion_tests.Elements
{
    public class PesquisarRoupaElements : Services
    {
        public static IWebElement BtnAdicionarAoCarrinho()
        {
            return WaitForElementByXPath("//*[@id='add_to_cart']/button");
        }
        public static IWebElement BtnContinuarComprando()
        {
            return WaitForElementByXPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/span");
        }
        public static IWebElement TxtPesquisar()
        {
            return WaitForElement("search_query_top");
        }
        public static IWebElement BtnPesquisar()
        {
            return WaitForElementByXPath("//*[@id='searchbox']/button");
        }
        public static IWebElement BtnVisualizar()
        {
            return WaitForElementByXPath("//*[@id='center_column']/ul/li[2]/div/div[1]/div");
        }
        public static IWebElement TxtQuantidade()
        {
            return WaitForElement("quantity_wanted");
        }
        public static IWebElement BtnQuantidadeMais()
        {
            return WaitForElementByXPath("//*[@id='quantity_wanted_p']/a[2]");
        }

    }
}
