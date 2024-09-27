using CalculoCDBApi.Business;
using CalculoCDBApi.Controllers;
using CalculoCDBApi.Data.VO;
using CalculoCDBApi.Model;

namespace CalculoCDBApi.Test
{
    public class CalculoInvestimentoTest
    {
        ICalculoInvestimentoBusiness CalculoInvestimentoBusiness = new CalculoInvestimentoBusiness();

        [Fact]
        public void Test_Calcular_ResultadoRetornoValores_InvestimentoCDB_Com_Menos_De_Seis_Meses()
        {
            InvestimentoModel investimento = new InvestimentoModel();
            //Arrange
            investimento.QtdMeses = 3;
            investimento.ValorInicial = 1000;
            double ValorBrutoEsperado = 1029.44;
            double ValorLiquidoEsperado = 1022.82;

            //Act
            var Resultado = CalculoInvestimentoBusiness.CalcularInvestimento(investimento);

            //Assert
            Assert.Equal(ValorBrutoEsperado, Resultado.ValorBruto);
            Assert.Equal(ValorLiquidoEsperado, Resultado.ValorLiquido);
        }

        [Fact]
        public void Test_Calcular_ResultadoRetornoValores_InvestimentoCDB_Com_Menos_De_Doze_Meses()
        {
            InvestimentoModel investimento = new InvestimentoModel();
            //Arrange
            investimento.QtdMeses = 10;
            investimento.ValorInicial = 1000;
            double ValorBrutoEsperado = 1101.56;
            double ValorLiquidoEsperado = 1081.25;

            //Act
            var Resultado = CalculoInvestimentoBusiness.CalcularInvestimento(investimento);

            //Assert
            Assert.Equal(ValorBrutoEsperado, Resultado.ValorBruto);
            Assert.Equal(ValorLiquidoEsperado, Resultado.ValorLiquido);
        }

        [Fact]
        public void Test_Calcular_ResultadoRetornoValores_InvestimentoCDB_Com_Menos_De_Vinte_E_Quatro_Meses()
        {
            InvestimentoModel investimento = new InvestimentoModel();
            //Arrange
            investimento.QtdMeses = 20;
            investimento.ValorInicial = 1500;
            double ValorBrutoEsperado = 1820.16;
            double ValorLiquidoEsperado = 1764.13;

            //Act
            var Resultado = CalculoInvestimentoBusiness.CalcularInvestimento(investimento);

            //Assert
            Assert.Equal(ValorBrutoEsperado, Resultado.ValorBruto);
            Assert.Equal(ValorLiquidoEsperado, Resultado.ValorLiquido);
        }

        [Fact]
        public void Test_Calcular_ResultadoRetornoValores_InvestimentoCDB_Com_Mais_De_Vinte_E_Quatro_Meses()
        {
            InvestimentoModel investimento = new InvestimentoModel();
            //Arrange
            investimento.QtdMeses = 35;
            investimento.ValorInicial = 1500;
            double ValorBrutoEsperado = 2104.38;
            double ValorLiquidoEsperado = 2013.72;

            //Act
            var Resultado = CalculoInvestimentoBusiness.CalcularInvestimento(investimento);

            //Assert
            Assert.Equal(ValorBrutoEsperado, Resultado.ValorBruto);
            Assert.Equal(ValorLiquidoEsperado, Resultado.ValorLiquido);
        }
    }
}