using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Context;
using App.Entity;
using App.Repository.Impl;

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

        public Section FindSectionByName(string sectionName)
        {
            return Context.Sections.SingleOrDefault(s => s.Name == sectionName);
        }
    }
}
