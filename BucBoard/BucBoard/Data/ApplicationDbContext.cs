using System;
using System.Collections.Generic;
using System.Text;
using BucBoard.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BucBoard.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Calendar>().HasKey(i => new { i.Id });
            builder.Entity<Event>().HasKey(i => new { i.Id });
            builder.Entity<Message>().HasKey(i => new { i.Id });
        }
    }
}
