using App.Context;
using App.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Phase Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    class PhaseRepository : AbstractRepository<Phase>, IPhaseRepository
    {
        public PhaseRepository(AppContext context) : base(context)
        {

        }
    }
}
