using POngBaratox2._0.Model;
using POngBaratox2._0.Repsitoy;

namespace POngBaratox2._0.Services
{
    public class AdotanteService
    {
        private IAdotanteRepository _adotanteRepository;


        public AdotanteService()
        {
            _adotanteRepository = new AdotanteRepository();
        }

        public Adotante InserirAdotante(Adotante adontante)
        {
            return _adotanteRepository.InserirAdotante(adontante);
        }

        public void Alterar_dados_adotante(string campo,string dado,string cpf)
        {
            _adotanteRepository.Alterar_dados_Adotante(campo, dado, cpf);
        }
    }
}
