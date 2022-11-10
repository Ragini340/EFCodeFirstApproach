using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EFCodeFirstFinal.Models;

namespace EFCodeFirstFinal.DataAccessLayer
{
    public class SchoolDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolDataContext>
      {
        public object SchoolDatacontext { get; private set; }

        protected override void Seed(SchoolDataContext context)
        {
            var studentDatas = new List<StudentData>
            {
            new StudentData{FirstMidName="Ragini",LastName="Singh",EnrollmentDate=DateTime.Parse("2010-09-02")},
            new StudentData{FirstMidName="R",LastName="Singh",EnrollmentDate=DateTime.Parse("2011-09-02")},
            new StudentData{FirstMidName="Ragini",LastName="Ragini",EnrollmentDate=DateTime.Parse("2012-09-03")},
            new StudentData{FirstMidName="Alica",LastName="Floric",EnrollmentDate=DateTime.Parse("2013-09-03")},
            new StudentData{FirstMidName="Will",LastName="Gardnor",EnrollmentDate=DateTime.Parse("200-09-01")},
            new StudentData{FirstMidName="Kalinda",LastName="Sharma",EnrollmentDate=DateTime.Parse("2014-09-04")},
            new StudentData{FirstMidName="Daine",LastName="Lockart",EnrollmentDate=DateTime.Parse("2015-09-05")},
            new StudentData{FirstMidName="Cary",LastName="Aagos",EnrollmentDate=DateTime.Parse("2016-09-06")}
            };

            studentDatas.ForEach(s => context.StudentDatas.Add(s));
            context.SaveChanges();
            var courses = new List<Course>
            {
            new Course{CourseID=1000,Title="Chemistry",Credits=3,},
            new Course{CourseID=4000,Title="Phyics",Credits=3,},
            new Course{CourseID=4042,Title="Mathematics",Credits=3,},
            new Course{CourseID=1075,Title="Calculus",Credits=4,},
            new Course{CourseID=3041,Title="Language",Credits=4,},
            new Course{CourseID=2023,Title="Composition",Credits=3,},
            new Course{CourseID=2000,Title="Literature",Credits=4,}
            };
            courses.ForEach(s => context.Courses.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050,},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}
