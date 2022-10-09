using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;


namespace Services
{
    public class ServicesAdotante
    {

        static string conection = "Data Source = localhost; Initial Catalog = ONG_2; User Id = sa; Password = Tricolor2511;";

        SqlConnection conexaoDB = new SqlConnection(conection);

        public Adotante InserirAdotante(Adotante people)
        {
            conexaoDB.Open();

            SqlCommand datainsert = new();

            datainsert.CommandText = $"INSERT INTO Adotante( Nome, CPF, Data_Nascimento, Telefone, CEP, Rua, Cidade, Bairro, Estado, Numero_casa) VALUES ('{people.Nome}','{people.CPF}','{people.DataNascimento}','{people.Telefone}','{people.Endereco.CEP}','{people.Endereco.Rua}','{people.Endereco.Cidade}','{people.Endereco.Bairro}','{people.Endereco.Estado}','{people.Endereco.Numero_casa}');";

            datainsert.Connection = conexaoDB;
            datainsert.ExecuteNonQuery();
            conexaoDB.Close();
            return people;
        }

        public void alterar_dados(string campo, string dado, string cpf)
        {
            conexaoDB.Open();

            SqlCommand datainsert = new();
            datainsert.CommandText = $"UPDATE Adotante SET {campo} = '{dado}' WHERE CPF = '{cpf}'; ";

            datainsert.Connection = conexaoDB;
            datainsert.ExecuteNonQuery();
            conexaoDB.Close();
        }
    }
}
