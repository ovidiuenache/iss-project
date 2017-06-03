using System.Collections.Generic;
using App.Entity;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Phase three controller interface
    /// Author : Catalin Radoiu 
    /// 
    /// </summary>
    public interface IPhaseThreeController
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Section> FindAllSections();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        Section FindSectionByName(string sectionName);

        /// <summary>
        /// Iterate all sections and add the user.
        /// </summary>
        /// <param name="sections"></param>
        /// <param name="loggedUser"></param>
        void AddListenerToSections(List<Section> sections, User loggedUser);

        /// <summary>
        /// Add the leader of section.
        /// </summary>
        /// <param name="sectionLeader"></param>
        void AddSectionLeader(User sectionLeader);

        /// <summary>
        /// All users that have the following roles: chair or reviewer.
        /// </summary>
        /// <returns></returns>
        List<User> FindAllComiteeMemberWithoutSection();
    }
}