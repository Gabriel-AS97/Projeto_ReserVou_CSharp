using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReserVou.Dominio;
using ReserVou.Servico;

namespace ReserVou.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstabelecimentoController : ControllerBase
    {
        private readonly IEstabelecimentoServico _servico;

        public EstabelecimentoController(IEstabelecimentoServico servico)
        {
            _servico = servico;
        }

        [HttpPost]
        public IActionResult Post(Estabelecimento estabelecimento)
        {
            _servico.Adicionar(estabelecimento);
            return Ok("Estabelecimento cadastrado com sucesso!");
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_servico.Listar());
        }
    }
}
