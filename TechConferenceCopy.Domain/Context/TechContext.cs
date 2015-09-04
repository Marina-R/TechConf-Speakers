using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechConferenceCopy.Domain.Entities;

namespace TechConferenceCopy.Domain.Context
{
    public class TechContext : IdentityDbContext<ConferenceUser>
    {
        public TechContext() : base("TechConferenceCopy", throwIfV1Schema: false)
        {
        }

        public DbSet<Session> Session { get; set; }
        public DbSet<Speaker> Speaker { get; set; }
        public DbSet<TimeSlot> TimeSlot { get; set; }
        public DbSet<Track> Track { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
