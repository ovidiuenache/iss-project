using System.Collections.Generic;
using App.Entity;
using App.Repository;
using App.Repository.Impl;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase three controller implementation 
    /// Author : Catalin Radoiu 
    /// Author : Claudiu Nicola
    /// </summary>
    public class PhaseThreeController : IPhaseThreeController
    {
        private ISectionRepository SectionRepository;

        public PhaseThreeController(ISectionRepository sectionRepository)
        {
            SectionRepository = sectionRepository;
        }

        /// <summary>
        /// Get a list with all topics.
        /// </summary>
        /// <returns></returns>
        public List<Section> FindAllTopics()
        {
            return SectionRepository.All();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public Section FindSectionByName(string sectionName)
        {
            return SectionRepository.FindSectionByName(sectionName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sections"></param>
        /// <param name="loggedUser"></param>
        public void AddListenerToSections(List<Section> sections, User loggedUser)
        {
            foreach (var section in sections)
            {
                section.Listeners.Add(loggedUser);
                SectionRepository.Update(section);
            }
        }
    }
}