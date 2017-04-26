using System;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Review
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class Review
    {
        private int id;
        private string qualifier;
        private string comment;
        private Reviewer reviewer;
        private DateTime dateCreated;

        public Review()
        {
            id = -1;
            qualifier = "";
            comment = "";
            reviewer = null;
            dateCreated = new DateTime();
        }

        public Review(string qualifier, string comment, Reviewer reviewer, DateTime dateCreated)
        {
            this.qualifier = qualifier;
            this.comment = comment;
            this.reviewer = reviewer;
            this.dateCreated = dateCreated;
        }

        public int getId()
        {
            return id;
        }

        public string getQualifier()
        {
            return qualifier;
        }

        public string getComment()
        {
            return comment;
        }

        public Reviewer getReviewer()
        {
            return reviewer;
        }

        public DateTime getDateCreated()
        {
            return dateCreated;
        }

        public void setQualifier(string qualifier)
        {
            this.qualifier = qualifier;
        }

        public void setComment(string comment)
        {
            this.comment = comment;
        }

        public void setReviewer(Reviewer reviewer)
        {
            this.reviewer = reviewer;
        }

        public void setDateCreated(DateTime dateCreated)
        {
            this.dateCreated = dateCreated;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Review;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}
