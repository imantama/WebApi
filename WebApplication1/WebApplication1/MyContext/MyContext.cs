using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1
{
    public class MyContext :DbContext
    {
        public MyContext() : base("myConnection") {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Division> Divisions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Entity<Division>()
                .HasRequired<Department>(D => D.Department)
                .WithMany(D => D.Divisions).HasForeignKey<int>(De => De.Department_Id)
                .WillCascadeOnDelete();
            modelBuilder.Entity<Department>()
                .HasMany<Division>(D => D.Divisions)
                .WithRequired(De => De.Department)
                .HasForeignKey<int>(D => D.Department_Id)
                .WillCascadeOnDelete();



        }
    }
}