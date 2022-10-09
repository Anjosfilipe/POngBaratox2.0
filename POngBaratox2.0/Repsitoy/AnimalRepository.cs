using System.Data.SqlClient;
using Dapper;
using POngBaratox2._0.Config;
using POngBaratox2._0.Model;

namespace POngBaratox2._0.Repsitoy
{
    public class AnimalRepository : IAnimalRepository
    {
        private string _conn;

        public AnimalRepository()
        {
            _conn = DataBaseConfig.Get();
        }

        public Animal InserirAnimal(Animal animal)
        {
            using (var db = new SqlConnection(_conn))
            {
                db.Open();
                db.Execute(Animal.INSERT, animal);

                return animal;
            }
        }

        public void doarAnimal(string cpf, int id)
        {
            using (var db = new SqlConnection(_conn))
            {

                var query = $"UPDATE Animal SET CPF = '{cpf}' WHERE ID_Chip = '{id}';";
                db.Execute(query);
            }
        }

        public void alterar_dados_pet(string campo, string dado, int id)
        {

            using (var db = new SqlConnection(_conn))
            {
                var query = $"UPDATE Animal SET {campo} = '{dado}' WHERE ID_Chip = '{id}'; ";
                db.Execute(query);
            }

        }

    }
}
