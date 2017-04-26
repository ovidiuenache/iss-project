namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Topic
    /// Author: Ioan Ovidiu Enache
    /// 
    /// </summary>
    public class Topic
    {
        private int id;
        private string name;
        private string description;

        public Topic()
        {
            id = -1;
            name = "";
            description = "";
        }

        public Topic(string name, string description)
        {
            this.name = name;
            this.description = description;
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

        public string getDescription()
        {
            return description;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Topic;

            if (item == null)
            {
                return false;
            }

            return id == item.getId();
        }
    }
}
