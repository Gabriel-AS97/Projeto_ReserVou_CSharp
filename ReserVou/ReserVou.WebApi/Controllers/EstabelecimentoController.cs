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
        private readonly IEstabelecimentoServico _estabelecimentoServico;

        public EstabelecimentoController(IEstabelecimentoServico servico)
        {
            _estabelecimentoServico = servico;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] Estabelecimento estabelecimento)
        {
            _estabelecimentoServico.AdicionarEstabelecimento(estabelecimento.Nome_Estabelecimento, estabelecimento.Endereco_Estabelecimento);
            return Ok(estabelecimento);
        }

        [HttpGet]
        public IActionResult Listar() => Ok(_estabelecimentoServico.ObterTodos());

        [HttpGet("{id_estabelecimento}")]
        public IActionResult Obter(int id_estabelecimento)
        {
            var estabelecimento = _estabelecimentoServico.ObterPorId(id_estabelecimento);
            if (estabelecimento == null) return NotFound();
            return Ok(estabelecimento);
        }

        [HttpPut("{id_estabelecimento}")]
        public IActionResult Atualizar(int id_estabelecimento, [FromBody] Estabelecimento estabelecimento)
        {
            estabelecimento.Id_Estabelecimento = id_estabelecimento;
            _estabelecimentoServico.AtualizarEstabelecimento(estabelecimento);
            return Ok(estabelecimento);
        }

        [HttpDelete("{id_estabelecimento}")]
        public IActionResult Remover(int id_estabelecimento)
        {
            _estabelecimentoServico.RemoverEstabelecimento(id_estabelecimento);
            return NoContent();
        }
    }
}
