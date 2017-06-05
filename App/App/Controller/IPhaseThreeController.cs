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
    
        void deletePhases();

        void deleteConferences();

       
        void deleteTopics();

        void deleteProposals();

        void deleteReviews();

   
        List<Section> FindAllSectionsWithoutRoom();


        List<Section> FindAllSectionsWithoutLeader();

        void AddSectionRoom(Section section, string roomName);


        void UpdateProposal(Proposal proposal);

        Conference GetActiveConference();

        void AddProposalToSection(Section section, Proposal proposal);

  
        Proposal FindProposalByName(string proposalName);

 
        List<Proposal> FindAllProposals();

        
        List<Proposal> FindAllProposalsWithoutSection();

       
        List<Proposal> FindAllProposalsBySection(Section section);

   
        bool IsComiteeMemberWithoutSection(User user);

    
        List<User> FindAllComiteeMemberWithoutSection();

        
        void AddSectionLeader(Section section, User sectionLeader);

        void AddListenerToSections(List<Section> sections, User loggedUser);

        Section FindSectionByName(string sectionName);


        List<Section> FindAllUnassignedSections(User loggedUser);


        List<Section> FindAllSections();

    }
}