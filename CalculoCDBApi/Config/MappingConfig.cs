using AutoMapper;
using CalculoCDBApi.Data.VO;
using CalculoCDBApi.Model;

namespace CalculoCDBApi.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ResultadoInvestimentoVO, ResultadoInvestimentoModel>();
                config.CreateMap<ResultadoInvestimentoModel, ResultadoInvestimentoVO>();
                config.CreateMap<InvestimentoVO, InvestimentoModel>();
                config.CreateMap<InvestimentoModel, InvestimentoVO>();
            });
            return mappingConfig;
        }
    }
}
