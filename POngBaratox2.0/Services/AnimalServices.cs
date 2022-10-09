using POngBaratox2._0.Model;
using POngBaratox2._0.Repsitoy;

namespace POngBaratox2._0.Services
{
    public class AnimalServices
    {
        private IAnimalRepository _animalRepository;

        public AnimalServices()
        {
            _animalRepository = new AnimalRepository(); 
        }

        public Animal inserirAnimal(Animal animal)
        {
            return _animalRepository.InserirAnimal(animal);

        }

        public void doarAnimal(string cpf, int id)
        {
            _animalRepository.doarAnimal(cpf, id);
        }
        public void alterar_dados_pet(string campo, string dado, int id)
        {
            _animalRepository.alterar_dados_pet(campo, dado, id);
        }
    }
}
