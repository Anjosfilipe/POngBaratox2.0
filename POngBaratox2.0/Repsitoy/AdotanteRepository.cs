using System.Data.SqlClient;
using Dapper;
using POngBaratox2._0.Config;
using POngBaratox2._0.Model;

namespace POngBaratox2._0.Repsitoy
{
    public class AdotanteRepository : IAdotanteRepository
    {
        private string _conn;

        public AdotanteRepository()
        {
            _conn = DataBaseConfig.Get();
        }

        public Adotante InserirAdotante(Adotante people)
        {
            using (var db = new SqlConnection(_conn))
            {
                var query = $"INSERT INTO Adotante( Nome, CPF, Data_Nascimento, Telefone, CEP, Rua, Cidade, Bairro, Estado, Numero_casa) VALUES ('{people.Nome}','{people.CPF}','{people.DataNascimento}','{people.Telefone}','{people.Endereco.CEP}','{people.Endereco.Rua}','{people.Endereco.Cidade}','{people.Endereco.Bairro}','{people.Endereco.Estado}','{people.Endereco.Numero_casa}');";
                db.Execute(query);
                return people;
            }
        }

        public void Alterar_dados_Adotante(string campo, string dado, string cpf)
        {

            using (var db = new SqlConnection(_conn))
            {
                var query = $"UPDATE Adotante  SET {campo} = '{dado}' WHERE CPF = '{cpf}'; ";
                db.Execute(query);
            }

        }
    }
}
