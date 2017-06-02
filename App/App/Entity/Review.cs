using System;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Review
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// </summary>
    public class Review
    {
        public int ReviewId { get; set; }
        public string Qualifier { get; set; }
        public string Comment { get; set; }
        public User Reviewer { get; set; }
        public DateTime DateCreated { get; set; }

        public Proposal Proposal { get; set; }

        public Review()
        {
            Qualifier = "";
            Comment = "";
            Reviewer = null;
            DateCreated = new DateTime();
        }

        public Review(string qualifier, string comment, User reviewer, Proposal proposal, DateTime dateCreated)
        {
            this.Qualifier = qualifier;
            this.Comment = comment;
            this.Reviewer = reviewer;
            this.Proposal = proposal;
            this.DateCreated = dateCreated;
        }
        

        public override bool Equals(object obj)
        {
            var item = obj as Review;

            return ReviewId == item?.ReviewId;
        }
    }
}
