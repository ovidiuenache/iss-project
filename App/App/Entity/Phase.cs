using System;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Phase
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Phase
    {
        public int PhaseId { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public Phase()
        {
            PhaseId = -1;
            Name = "";
            Deadline = new DateTime();
        }

        public Phase(string name, DateTime deadline)
        {
            this.Name = name;
            this.Deadline = deadline;
        }


        public override bool Equals(object obj)
        {
            var item = obj as Phase;

            return PhaseId == item?.PhaseId;
        }
    }
}
