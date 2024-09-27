using System;

namespace CalculoCDBApi.Business.Tabela
{
    public static class Tabela
    {
        public static double Taxa(int qtdMeses)
        {
            if (qtdMeses <= 6)
                return 0.225;
            else if (qtdMeses > 6 && qtdMeses <= 12)
                return 0.20;
            else if (qtdMeses > 12 && qtdMeses <= 24)
                return 0.175;
            else
                return 0.15;
        }
    }
}
