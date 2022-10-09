using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using Services;

namespace Controllers
{
    public class AdotanteController
    {
        public Adotante InserirAdotante(Adotante adotante)
        {
            new ServicesAdotante().InserirAdotante(adotante);
            return adotante;
        }

        public void Alterar_dados_Adotante(string campo, string dado, string cpf)
        {
            new ServicesAdotante().alterar_dados(campo, dado, cpf);

        }
    }
}
