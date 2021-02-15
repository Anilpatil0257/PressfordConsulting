using Microsoft.EntityFrameworkCore;
using PressfordConsultingApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PressfordConsultingApi.Repository
{
    public class PressfordConsultingDbContext : DbContext
    {
      /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().ToTable("tblArticle");
        }
       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("DbConn");
        } */
      public PressfordConsultingDbContext(DbContextOptions<PressfordConsultingDbContext> options):base(options)
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        public DbSet<Article> Articles { get; set; }
    }
}
