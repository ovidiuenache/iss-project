using System.Collections.Generic;

namespace App.Entity
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Title { get; set; }
        public string Slug { get; set; }
        /// <summary>
        /// The foreign key
        /// </summary>
        //public int UserId { get; set; }
        //public User User { get; set; }
        public List<UserRole> UserRoles { get; set; }

        public Role()
        {
        }

        public Role(string title, string slug)
        {
            Title = title;
            Slug = slug;
        }

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            var item = obj as Role;

            return RoleId == item?.RoleId;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
