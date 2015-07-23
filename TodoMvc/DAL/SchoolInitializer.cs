using System;
using TodoMvc.Models;
using System.Collections.Generic;

namespace TodoMvc.DAL
{
	public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
	{
		protected override void Seed(SchoolContext context){
			var students = new List<Student> {
				new Student{FirstName="Bob", LastName="Alexander", EnrollmentDate=DateTime.Parse("2002-02-22")},
				new Student{FirstName="Albery", LastName="Cre", EnrollmentDate=DateTime.Parse("2004-04-02")},
				new Student{FirstName="Rithy", LastName="Burt", EnrollmentDate=DateTime.Parse("2003-02-13")},
				new Student{FirstName="Sue", LastName="Smith", EnrollmentDate=DateTime.Parse("2001-06-17")}
			};

			students.ForEach (s => context.Students.Add (s));
			context.SaveChanges ();

			var courses = new List<Course> {
				new Course{CourseID=1050, Title="Chemistry I", Credits=3},
				new Course{CourseID=1051, Title="Chemistry II", Credits=3},
				new Course{CourseID=1052, Title="Chemistry III", Credits=4}
			};

			courses.ForEach (c => context.Courses.Add (c));
			context.SaveChanges ();

			var enrollments = new List<Enrollment> {
				new Enrollment{StudentID=1, CourseID=1050, Grade=Grade.A},
				new Enrollment{StudentID=1, CourseID=1051, Grade=Grade.B},
				new Enrollment{StudentID=2, CourseID=1050, Grade=Grade.A},
				new Enrollment{StudentID=2, CourseID=1051, Grade=Grade.D},
				new Enrollment{StudentID=3, CourseID=1050, Grade=Grade.A},
				new Enrollment{StudentID=4, CourseID=1051, Grade=Grade.C},
				new Enrollment{StudentID=4, CourseID=1052, Grade=Grade.A},
			};

			enrollments.ForEach (e => context.Enrollments.Add (e));
			context.SaveChanges ();
		}
	}
}

