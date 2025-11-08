using ReserVou.Dominio;

namespace ReserVou.Repositorio
{
    public class EstabelecimentoRepositorio : IEstabelecimentoRepositorio
    {
        private readonly List<Estabelecimento> _estabelecimentos = new();
        private int _proximoId = 1;

        private readonly EstabelecimentoDBContext _context;
        public EstabelecimentoRepositorio(EstabelecimentoDBContext context)
        {
            _context = context;
        }

        public void Adicionar(Estabelecimento estabelecimento)
        {
            _context.Estabelecimentos.Add(estabelecimento);
            _context.SaveChanges();
        }
        /* public void Adicionar(Estabelecimento estabelecimento)
        {
            _estabelecimentos.Add(estabelecimento);
        }*/

        public void Salvar(Estabelecimento estabelecimento)
        {
            estabelecimento.Id_Estabelecimento = _proximoId++;
            _estabelecimentos.Add(estabelecimento);
        }

        public List<Estabelecimento> ObterTodos() => _estabelecimentos;

        public Estabelecimento ObterPorId(int id_estabelecimento) => _estabelecimentos.FirstOrDefault(a => a.Id_Estabelecimento == id_estabelecimento);

        public void Atualizar(Estabelecimento estabelecimento)
        {
            var existente = ObterPorId(estabelecimento.Id_Estabelecimento);
            if (existente != null)
            {
                existente.Nome_Estabelecimento = estabelecimento.Nome_Estabelecimento;
                existente.Endereco_Estabelecimento = estabelecimento.Endereco_Estabelecimento;
            }
        }

        public void Remover(int id_estabelecimento)
        {
            var estabelecimento = ObterPorId(id_estabelecimento);
            if (estabelecimento != null) _estabelecimentos.Remove(estabelecimento);
        }
    }
}
