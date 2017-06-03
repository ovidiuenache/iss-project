using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entity;
using App.Repository;

namespace App.Controller
{
    /// <summary>
    /// 
    /// Interface ISectionRepository
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public interface ISectionRepository : IRepository<Section>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        Section FindSectionByName(string sectionName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        List<User> FindAllAuthors(Section section);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Proposal> FindAllProposalsExistingInSections();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="proposals"></param>
        void AddProposalsToSection(Section section, List<Proposal> proposals);
    }
}
