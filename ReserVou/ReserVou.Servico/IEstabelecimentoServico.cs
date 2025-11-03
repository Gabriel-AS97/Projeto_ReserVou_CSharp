using ReserVou.Dominio;

namespace ReserVou.Servico
{
    public interface IEstabelecimentoServico
    {
        void Adicionar(Estabelecimento estabelecimento);
        List<Estabelecimento> ObterTodos();
        Estabelecimento ObterPorId(int id_estabelecimento);
        void AtualizarEstabelecimento(Estabelecimento estabelecimento);
        void RemoverEstabelecimento(int id_estabelecimento);

    }
}
