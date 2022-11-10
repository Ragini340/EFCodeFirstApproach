using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFCodeFirstFinal.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace EFCodeFirstFinal.DataAccessLayer
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext() : base("SchoolContext")
        {
        }
        public DbSet<StudentData> StudentDatas { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}