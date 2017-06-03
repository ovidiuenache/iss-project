using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;
using App.Repository.Impl;
using Microsoft.EntityFrameworkCore;

namespace App.Controller.Impl
{
    /// <summary>
    /// 
    /// Class SectionRepository
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class SectionRepository : AbstractRepository<Section>, ISectionRepository
    {
        public SectionRepository(AppContext context) : base(context)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sectionName"></param>
        /// <returns></returns>
        public Section FindSectionByName(string sectionName)
        {
            return Context.Sections.SingleOrDefault(s => s.Name == sectionName);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <returns></returns>
        public List<User> FindAllAuthors(Section section)
        {
            //@todo: ceva fute risca rau de tot nu pot aduce autorii de pe sectiune
            //
            //var p = Context.Sections.Include(s => s.Authors).ToList();
            return Context.Users.ToList();
        }

        public List<Proposal> FindAllProposalsExistingInSections()
        {
            List<Section> sections = Context.Sections
                .Include(p => p.Proposals)
                .ToList();
            List<Proposal> proposals = new List<Proposal>();

            foreach (var section in sections)
            {
                foreach (var proposal in section.Proposals)
                {
                    proposals.Add(proposal);
                }
            }
            return proposals;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="proposals"></param>
        public void AddProposalsToSection(Section section, List<Proposal> proposals)
        {
            foreach (var proposal in proposals)
            {
                section.Proposals.Add(proposal);
            }
            Context.Sections.Update(section);
        }
    }
}
