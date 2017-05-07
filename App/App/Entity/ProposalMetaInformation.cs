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
        public IList<Author> Authors { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public ProposalMetaInformation()
        {
            ProposalMetaInformationId = -1;
            Title = "";
            Authors = new List<Author>();
            Year = -1;
            Description = "";
        }

        public ProposalMetaInformation(string title, IList<Author> authors, int year, string description)
        {
            this.Title = title;
            this.Authors = authors;
            this.Year = year;
            this.Description = description;
        }

        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public void RemoveAuthor(Author author)
        {
            Authors.Remove(author);
        }

        public override bool Equals(object obj)
        {
            var item = obj as ProposalMetaInformation;

            return ProposalMetaInformationId == item?.ProposalMetaInformationId;
        }
    }
}
