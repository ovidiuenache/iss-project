using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class ProposalMetaInformation
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class ProposalMetaInformation
    { 
        public int ProposalMetaInformationId{get; set; }
        public string Title { get; set; }
        public IList<User> Authors { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public int ProposalForeignKey { get; set; }
        public Proposal Proposal { get; set; }

        public ProposalMetaInformation()
        {
            Title = "";
            Authors = new List<User>();
            Year = -1;
            Description = "";
        }

        public ProposalMetaInformation(string title, IList<User> authors, int year, string description)
        {
            this.Title = title;
            this.Authors = authors;
            this.Year = year;
            this.Description = description;
        }

        public override bool Equals(object obj)
        {
            var item = obj as ProposalMetaInformation;

            return ProposalMetaInformationId == item?.ProposalMetaInformationId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
