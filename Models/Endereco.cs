using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Endereco
    {

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero_casa { get; set; }


        public Endereco()
        {

        }

        public Endereco(string CEP, string estado, string cidade, string bairro, string rua, string numero_casa)
        {
            this.CEP = CEP;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
            this.Numero_casa = numero_casa;
        }

    }
}
