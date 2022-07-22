using AreaCheck.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCheckApp.Migration
{
    public class AreaCheckDatabaseContext: DbContext
    {
        public AreaCheckDatabaseContext()
        {
        }

        public AreaCheckDatabaseContext(DbContextOptions<AreaCheckDatabaseContext> options)
             : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

        public DbSet<AreaModel> DateHistory { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
