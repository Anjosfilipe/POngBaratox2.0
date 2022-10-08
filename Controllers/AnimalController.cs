using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AnimalController
    {
        public Animal InserirAnimal(Animal animal)
        {
            new ServicesAnimal().InserirPET(animal);
            return animal;
        }

        public void doarAnimal(string cpf, int id)
        {
            new ServicesAnimal().doarPET(cpf, id);
        }

        public void alterar_dados_pet(string campo,string dado, int id)
        {
            new ServicesAnimal().alterar_dados(campo,dado,id);
        }
    }
}
