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
    /// Conference Repository
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    class ConferenceRepository : AbstractRepository<Conference>, IConferenceRepository
    {
        public ConferenceRepository(AppContext context) : base(context)
        {

        }
    } 
}
