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
    /// Topic Repository 
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    class TopicRepository : AbstractRepository<Topic>, ITopicRepository
    {
        public TopicRepository(AppContext context) : base(context)
        {

        }
    }
}
