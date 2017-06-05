using System;
using System.Collections.Generic;

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

        public IList<Conference> Conferences { get; set; }

        public Phase()
        {
            Name = "";
            Deadline = new DateTime();
        }

        public Phase(string name, DateTime deadline)
        {
            Name = name;
            Deadline = deadline;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Phase;

            return PhaseId == item?.PhaseId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
