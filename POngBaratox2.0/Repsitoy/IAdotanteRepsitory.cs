using POngBaratox2._0.Model;


namespace POngBaratox2._0.Repsitoy
{
    public interface IAdotanteRepository
    {
        Adotante InserirAdotante(Adotante adotante);
        void Alterar_dados_Adotante(string campo, string dado, string cpf);
    }
}
