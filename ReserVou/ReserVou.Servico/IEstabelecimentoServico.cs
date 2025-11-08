using ReserVou.Dominio;

namespace ReserVou.Servico
{
    public interface IEstabelecimentoServico
    {
        void AdicionarEstabelecimento(string nome_estabelecimento, string endereco_estabelecimento);
        List<Estabelecimento> ObterTodos();
        Estabelecimento ObterPorId(int id_estabelecimento);
        void AtualizarEstabelecimento(Estabelecimento estabelecimento);
        void RemoverEstabelecimento(int id_estabelecimento);

    }
}
