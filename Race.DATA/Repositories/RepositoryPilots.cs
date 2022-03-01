using Race.DATA.Interfaces;
using Race.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.DATA.Repositories
{
    public class RepositoryPilots : RepositoryModel<Pilots>, IRepositoryPilots
    {
        public RepositoryPilots(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
