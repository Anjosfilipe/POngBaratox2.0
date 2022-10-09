using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POngBaratox2._0.Model
{
    public class Adotante
    {
        public String Nome { get; set; }
        public String CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Adotante()
        {

        }

        public Adotante(string nome, String cPF, DateTime dataNascimento, string telefone, Endereco endereco)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Endereco = endereco;
        }

    }
}