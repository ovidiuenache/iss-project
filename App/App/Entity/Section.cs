using System.Collections;
using System.Collections.Generic;

namespace App.Entity
{
    /// <summary>
    /// 
    /// Class Section
    /// Author: Claudiu Nicola
    /// 
    /// </summary>
    public class Section
    {
        public int SectionId { get; set; }
        public string Name { get; set; }
        public IList<Topic> Topics { get; set; }
        public IList<User> Listeners { get; set; }
    }
}
