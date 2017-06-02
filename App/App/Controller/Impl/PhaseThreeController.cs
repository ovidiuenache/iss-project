using System.Collections.Generic;
using App.Entity;
using App.Repository;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase three controller implementation 
    /// Author : Catalin Radoiu 
    /// Author : Claudiu Nicola
    /// </summary>
    public class PhaseThreeController
    {
        private ITopicRepository TopicRepository;

        public PhaseThreeController(ITopicRepository topicRepository)
        {
            TopicRepository = topicRepository;
        }

        /// <summary>
        /// Get a list with all topics.
        /// </summary>
        /// <returns></returns>
        public List<Topic> FindAllTopics()
        {
            return TopicRepository.All();
        }

        public Topic FindTopicByName(string topicName)
        {
            return TopicRepository.FindTopicByName(topicName);
        }
    }
}