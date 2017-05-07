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

        public Review()
        {
            ReviewId = -1;
            Qualifier = "";
            Comment = "";
            Reviewer = null;
            DateCreated = new DateTime();
        }

        public Review(string qualifier, string comment, User reviewer, DateTime dateCreated)
        {
            this.Qualifier = qualifier;
            this.Comment = comment;
            this.Reviewer = reviewer;
            this.DateCreated = dateCreated;
        }
        

        public override bool Equals(object obj)
        {
            var item = obj as Review;

            return ReviewId == item?.ReviewId;
        }
    }
}
