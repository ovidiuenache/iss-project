
namespace App.Entity
{
    /// <summary>
    /// 
    /// Class UserSection
    /// Author : Claudiu Nicola
    /// 
    /// </summary>
    public class UserSection
    {
        public int UserId { get; set; }
        public User User { get; set; }

        public int SectionId { get; set; }
        public Section Section { get; set; }
    }
}
