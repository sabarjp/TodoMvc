using System;
using System.Data.Entity;
using TodoMvc.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TodoMvc.DAL
{
	public class SchoolContext : DbContext
	{
		// The connection string is specified here
		public SchoolContext() : base("SchoolContext")
		{
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Enrollment> Enrollments { get; set; }
		public DbSet<Course> Courses { get; set; }

		/*
		public override void OnModelCreating(DbModelBuilder modelBuilder) {
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention> ();
		}
		*/
	}
}

