namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Topic
    /// Author: Ioan Ovidiu Enache
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Topic
    {
        public int TopicId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Topic()
        {
            TopicId = -1;
            Name = "";
            Description = "";
        }

        public Topic(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Topic;

            return TopicId == item?.TopicId;
        }
    }
}
