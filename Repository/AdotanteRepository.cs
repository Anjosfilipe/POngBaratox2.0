using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AdotanteRepository : IAdotanteRepository
    {
        private string _conn;
        public AdotanteRepository()
        {
            _conn = DataBaseConfig.Get();
        }
    }
}
