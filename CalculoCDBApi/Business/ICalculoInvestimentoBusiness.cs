using CalculoCDBApi.Model;

namespace CalculoCDBApi.Business
{
    public interface ICalculoInvestimentoBusiness
    {
        ResultadoInvestimentoModel CalcularInvestimento(InvestimentoModel investimento);
    }
}
