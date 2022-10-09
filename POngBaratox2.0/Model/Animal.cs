using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POngBaratox2._0.Model
{
    public class Animal
    {
        public string Familia { get; set; }
        public string Raca { get; set; }
        public string Sexo { get; set; }
        public string Nome { get; set; }


        public readonly static string INSERT = "INSERT INTO Animal(Familia, Raca, Sexo, Nome) VALUES (@Familia,@Raca,@Sexo,@Nome)";
        

        public Animal()
        {

        }
        public Animal(string familia, string raca, string sexo, string nome)
        {
            this.Familia = familia;
            this.Raca = raca;
            this.Sexo = sexo;
            this.Nome = nome;
        }

    }
}

