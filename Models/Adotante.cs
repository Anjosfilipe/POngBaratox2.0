using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Adotante
    {
        public String Nome { get; set; }
        public String CPF { get; set; }
        public String Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public String Telefone { get; set; }
        public Endereco Endereco { get; set; }

        public Adotante()
        {

        }

        public Adotante(string nome, String cPF, string sexo, DateTime dataNascimento, string telefone, Endereco endereco)
        {
            Nome = nome;
            CPF = cPF;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Endereco = endereco;
        }

       

    }
}
