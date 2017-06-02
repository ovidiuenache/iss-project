using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Class ConferenceUserRepository
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class ConferenceUserRepository : AbstractRepository<ConferenceUser>
    {
        public ConferenceUserRepository(AppContext context) : base(context)
        {
        }
    }
}
