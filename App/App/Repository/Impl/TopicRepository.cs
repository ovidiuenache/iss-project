using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Topic Repository 
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public class TopicRepository : AbstractRepository<Topic>, ITopicRepository
    {
        public TopicRepository(AppContext context) : base(context)
        {
        }
    }
}
