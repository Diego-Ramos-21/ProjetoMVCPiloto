using Race.DATA.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DATA.Services
{
    public class PilotsService
    {
        // Permite executar as ações do repositorio
        public RepositoryPilots sRepositoryPilots { get; set; }
        public PilotsService() => sRepositoryPilots = new RepositoryPilots();
    }
}
