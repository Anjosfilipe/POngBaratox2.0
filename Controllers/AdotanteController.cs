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
    }
}
