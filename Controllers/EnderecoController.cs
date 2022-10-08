using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Controllers
{
    public class EnderecoController
    {
        public Endereco Coleta_Dados_endereco()
        {
            Console.Write("Informe o CEP: ");
            string c = Console.ReadLine();
            Console.Write("Informe o Estado: ");
            string e = Console.ReadLine();
            Console.Write("Informe o Cidade: ");
            string cd = Console.ReadLine();
            Console.Write("Informe o Bairro: ");
            string b = Console.ReadLine();
            Console.Write("Informe o Logradouro: ");
            string l = Console.ReadLine();
            Console.Write("Informe o Numero da residencia: ");
            string n = Console.ReadLine();

            return new Endereco(c, e, cd, b, l, n);
        }
    }
}
