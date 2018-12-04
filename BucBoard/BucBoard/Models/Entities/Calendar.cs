using Project2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BucBoard.Models.Entities
{
    public class Calendar
    {
        public int Id { get; set; }
        public string Month { get; set; }
        public string UserId { get; set; }
        public int AppUserId { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<Event> Events { get; set; }

        public Calendar()
        {
            Events = new List<Event>();
        }
    }
}
