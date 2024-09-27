using CalculoCDBApi.Model;

namespace CalculoCDBApi.Business
{
    public class CalculoInvestimentoBusiness : ICalculoInvestimentoBusiness
    {
        private const double TB = 1.08;
        private const double CDI = 0.009;
        public ResultadoInvestimentoModel CalcularInvestimento(InvestimentoModel investimento)
        {
            ResultadoInvestimentoModel resultado = new ResultadoInvestimentoModel();
            double ResultadoMesAtual = 0.0;

            for (int i = 0; i < investimento.QtdMeses; i++)
            {
                double ResultadoMesAnterior;
                if (i == 0)
                    ResultadoMesAnterior = investimento.ValorInicial;
                else
                    ResultadoMesAnterior = ResultadoMesAtual;

                ResultadoMesAtual = ResultadoMesAnterior * (1 + (CDI * TB));

                resultado.ValorBruto = Math.Round(ResultadoMesAtual, 2);
            }

            var Lucro = resultado.ValorBruto - investimento.ValorInicial;

            var taxa = Tabela.Tabela.Taxa(investimento.QtdMeses);

            var Imposto = Lucro * taxa;

            resultado.ValorLiquido = Math.Round(investimento.ValorInicial + (Lucro - Imposto), 2);

            return resultado;
        }
    }
}
