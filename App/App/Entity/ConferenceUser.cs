using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entity
{
    public class ConferenceUser
    {
        public int ConferenceId { get; set; }
        public Conference Conference { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
