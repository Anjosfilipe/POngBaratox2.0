using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Repository
{
    public interface IAdotanteRepository
    {
        Adotante InserirAdotante(Adotante adotante);
        void Alterar_dados_Adotante(string campo, string dado, string cpf);
    }
}
