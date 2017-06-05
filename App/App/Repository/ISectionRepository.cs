﻿using System.Collections.Generic;
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
        /// <returns></returns>
        List<Proposal> FindAllProposalsExistingInSections();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="section"></param>
        /// <param name="proposal"></param>
        void AddProposalToSection(Section section, Proposal proposal);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Section> FindAllSectionsWithoutLeader();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<Section> FindAllSectionsWithoutRoom();
    }
}
