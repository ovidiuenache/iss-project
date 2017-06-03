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
            var author = Context.Users.Find(1);
            var petru = Context.Proposals.Include(p => p.MetaInformation.Authors).Where(p=>p.MetaInformation.Authors.Any(a=>a.UserId==author.UserId)).ToList();
            return Context.Users.ToList();
        }
    }
}
