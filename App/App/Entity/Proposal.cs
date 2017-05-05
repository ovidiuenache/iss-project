namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Proposal
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class Proposal
    {
        private int id;
        private ProposalMetaInformation metaInformation;
        private string fullPaper;
        private string abstractPaper;

        public Proposal()
        {
            id = -1;
            metaInformation = null;
            fullPaper = "";
            abstractPaper = "";
        }

        public Proposal(ProposalMetaInformation metaInformation, string fullPaper, string abstractPaper)
        {
            this.metaInformation = metaInformation;
            this.fullPaper = fullPaper;
            this.abstractPaper = abstractPaper;
        }

        public int getId()
        {
            return id;
        }

        public ProposalMetaInformation getMetaInformation()
        {
            return metaInformation;
        }

        public string getFullPaper()
        {
            return fullPaper;
        }

        public string getAbstractPaper()
        {
            return abstractPaper;
        }

        public void setMetaInformation(ProposalMetaInformation metaInformation)
        {
            this.metaInformation = metaInformation;
        }

        public void setFullPaper(string fullPaper)
        {
            this.fullPaper = fullPaper;
        }

        public void setAbstractPaper(string abstractPaper)
        {
            this.abstractPaper = abstractPaper;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Proposal;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}
