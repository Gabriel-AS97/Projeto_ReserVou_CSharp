using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReserVou.Dominio
{
    public class Estabelecimento
    {
        public int Id_Estabelecimento { get; set; }
        public string Nome_Estabelecimento { get; set; }
        public string Endereco_Estabelecimento { get; set; }

        public Estabelecimento(string nome_estabelecimento, string endereco_estabelecimento)
        {
            Nome_Estabelecimento = nome_estabelecimento;
            Endereco_Estabelecimento = endereco_estabelecimento;
        }
    }
}
