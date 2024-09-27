using AutoMapper;
using CalculoCDBApi.Business;
using CalculoCDBApi.Data.VO;
using CalculoCDBApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CalculoCDBApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculoCDBController : ControllerBase
    {
        private readonly ICalculoInvestimentoBusiness _calculoInvestimentoBusiness;
        private readonly IMapper _mapper;
        private readonly ILogger<CalculoCDBController> _logger;

        public CalculoCDBController(ICalculoInvestimentoBusiness CalculoInvestimentoBusiness, IMapper Mapper,
            ILogger<CalculoCDBController> Logger)
        {
            _calculoInvestimentoBusiness = CalculoInvestimentoBusiness;
            _mapper = Mapper;
            _logger = Logger;
        }

        [HttpPost]
        public ActionResult<ResultadoInvestimentoVO> ResultadoInvestimento([FromBody] InvestimentoVO investimentoVO)
        {
            _logger.LogInformation(string.Format("Iniciando calculo de investimento com valor inicial de R$: {0} para {1} meses.",
                investimentoVO.ValorInicial, investimentoVO.QtdMeses));

            var Investimento = _mapper.Map<InvestimentoModel>(investimentoVO);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var ResultadoInvestimento = _mapper.Map<ResultadoInvestimentoVO>(_calculoInvestimentoBusiness.CalcularInvestimento(Investimento));

            return Ok(ResultadoInvestimento);
        }
    }
}
