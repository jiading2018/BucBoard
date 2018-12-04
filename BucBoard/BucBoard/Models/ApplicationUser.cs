using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucBoard.Models.Entities;
using Microsoft.AspNetCore.Identity;

namespace Project2.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public int UserId { get; set; }

        public ICollection<Calendar> Calendars { get; set; }

        public ApplicationUser()
        {
            Calendars = new List<Calendar>();
        }
    }
}