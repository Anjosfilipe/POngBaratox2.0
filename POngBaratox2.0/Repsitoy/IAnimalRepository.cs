using POngBaratox2._0.Model;

namespace POngBaratox2._0.Repsitoy
{
    public interface IAnimalRepository
    {
        Animal InserirAnimal(Animal animal);
        void doarAnimal(string cpf, int id);
        void alterar_dados_pet(string campo, string dado, int id);
    }
}
