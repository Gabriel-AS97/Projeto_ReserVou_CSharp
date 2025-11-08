using ReserVou.Dominio;
using ReserVou.Repositorio;

namespace ReserVou.Servico
{
    public class EstabelecimentoServico : IEstabelecimentoServico
    {
        private readonly IEstabelecimentoRepositorio _repositorio;

        public EstabelecimentoServico(IEstabelecimentoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void AdicionarEstabelecimento(string nome_estabelecimento, string endereco_estabelecimento)
        {
            var estabelecimento = new Estabelecimento(nome_estabelecimento, endereco_estabelecimento);
            _repositorio.Adicionar(estabelecimento);
        }

        public List<Estabelecimento> ObterTodos() => _repositorio.ObterTodos();

        public Estabelecimento ObterPorId(int id_estabelecimento) => _repositorio.ObterPorId(id_estabelecimento);

        public void AtualizarEstabelecimento(Estabelecimento estabelecimento) => _repositorio.Atualizar(estabelecimento);

        public void RemoverEstabelecimento(int id_estabelecimento) => _repositorio.Remover(id_estabelecimento);
    }
}