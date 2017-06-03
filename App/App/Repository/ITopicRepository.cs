using App.Entity;

namespace App.Repository
{
    /// <summary>
    /// 
    /// Topic Repository interface
    /// Author : Catalin Radoiu
    /// Author : Ioan Ovidiu Enache
    /// 
    /// </summary>
    public interface ITopicRepository : IRepository<Topic>
    {
        Topic FindTopicByName(string topicName);
    }
}
