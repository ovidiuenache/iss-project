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
        Section FindSectionByName(string sectionName);
    }
}
