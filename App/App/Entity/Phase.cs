using System;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Phase
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class Phase
    {
        private int id;

        private string name;

        private DateTime deadline;

        public Phase()
        {
            id = -1;
            name = "";
            deadline = new DateTime();
        }

        public Phase(string name, DateTime deadline)
        {
            this.name = name;
            this.deadline = deadline;
        }

        public int getId()
        {
            return id;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public DateTime getDeadline()
        {
            return deadline;
        }

        public void setDeadline(DateTime deadline)
        {
            this.deadline = deadline;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Phase;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}
