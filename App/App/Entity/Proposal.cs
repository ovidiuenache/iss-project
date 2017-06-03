using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Proposal
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Proposal
    {
        public int ProposalId { get; set; }
        public string Title { get; set; }
        public IList<User> Authors { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string FullPaper { get; set; }
        public string AbstractPaper { get; set; }

        public Proposal()
        {
            MetaInformation = new ProposalMetaInformation();
            FullPaper = "";
            AbstractPaper = "";
        }

        public Proposal(string title,
            IList<User> authors,
            int year,
            string description,
            string fullPaper,
            string abstractPaper)
        {
            this.Title = title;
            this.Authors = authors;
            this.Year = year;
            this.Description = description;
            this.FullPaper = fullPaper;
            this.AbstractPaper = abstractPaper;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Proposal;

            return ProposalId == item?.ProposalId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
