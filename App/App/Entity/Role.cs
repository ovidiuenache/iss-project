using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int UserId { get; set; }
        public User User { get; set; }

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
    }
}
