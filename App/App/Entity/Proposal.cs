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
        public ProposalMetaInformation MetaInformation { get; set; }
        public string FullPaper { get; set; }
        public string AbstractPaper { get; set; }

        public Proposal()
        {
            ProposalId = -1;
            MetaInformation = null;
            FullPaper = "";
            AbstractPaper = "";
        }

        public Proposal(ProposalMetaInformation metaInformation, string fullPaper, string abstractPaper)
        {
            this.MetaInformation = metaInformation;
            this.FullPaper = fullPaper;
            this.AbstractPaper = abstractPaper;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Proposal;

            return ProposalId == item?.ProposalId;
        }
    }
}
