using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class ProposalMetaInformation
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class ProposalMetaInformation
    {
        private int id;
        private string title;
        private IList<Author> authors;
        private int year;
        private string description;

        public ProposalMetaInformation()
        {
            id = -1;
            title = "";
            authors = new List<Author>();
            year = -1;
            description = "";
        }

        public ProposalMetaInformation(string title, IList<Author> authors, int year, string description)
        {
            this.title = title;
            this.authors = authors;
            this.year = year;
            this.description = description;
        }

        public int getId()
        {
            return id;
        }

        public string getTitle()
        {
            return title;
        }

        public IList<Author> getAuthors()
        {
            return authors;
        }

        public int getYear()
        {
            return year;
        }

        public string getDescription()
        {
            return description;
        }

        public void setTitle(string title)
        {
            this.title = title;
        }

        public void setAuthors(IList<Author> authors)
        {
            this.authors = authors;
        }

        public void addAuthor(Author author)
        {
            authors.Add(author);
        }

        public void removeAuthor(Author author)
        {
            authors.Remove(author);
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public override bool Equals(object obj)
        {
            var item = obj as ProposalMetaInformation;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}
