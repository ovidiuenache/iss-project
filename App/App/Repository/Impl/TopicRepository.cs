using App.Context;
using App.Entity;
using System.Linq;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Topic Repository 
    /// Author : Catalin Radoiu 
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class TopicRepository : AbstractRepository<Topic>, ITopicRepository
    {
        public TopicRepository(AppContext context) : base(context)
        {
        }

        public Topic FindTopicByName(string topicName)
        {
            return Context.Topics.SingleOrDefault(topic => topic.Name == topicName);
        }
    }
}
