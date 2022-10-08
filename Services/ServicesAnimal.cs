using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Services
{
    public class ServicesAnimal
    {
        static string conection = "Data Source = localhost; Initial Catalog = ONG_2; User Id = sa; Password = Tricolor2511;";

        SqlConnection conexaoDB = new SqlConnection(conection);

        public Animal InserirPET(Animal animal)
        {
            conexaoDB.Open();

            SqlCommand datainsert = new();

           
            datainsert.CommandText = $"INSERT INTO Animal(Familia, Raca, Sexo, Nome) VALUES ('{animal.Familia}','{animal.Raca}','{animal.Sexo}','{animal.Nome}');";

            datainsert.Connection = conexaoDB;
            datainsert.ExecuteNonQuery();
            conexaoDB.Close();
            return animal;
        }

        public void doarPET(string cpf, int id)
        {
            conexaoDB.Open();

            SqlCommand datainsert = new();

            datainsert.CommandText = $"UPDATE Animal SET CPF = '{cpf}' WHERE ID_Chip = '{id}'; ";
          
            datainsert.Connection = conexaoDB;
            datainsert.ExecuteNonQuery();
            conexaoDB.Close();
            
        }

        public void alterar_dados(string campo,string dado,int id)
        {
            conexaoDB.Open();

            SqlCommand datainsert = new();
            datainsert.CommandText = $"UPDATE Animal SET {campo} = '{dado}' WHERE ID_Chip = '{id}'; ";

            datainsert.Connection = conexaoDB;
            datainsert.ExecuteNonQuery();
            conexaoDB.Close();
        }

    }
}
