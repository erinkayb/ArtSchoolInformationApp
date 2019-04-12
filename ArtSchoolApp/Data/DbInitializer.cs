using ArtSchoolApp.Models;
using System;
using System.Linq;

namespace ArtSchoolApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Erin",LastName="de Blaeij",EnrollmentDate=DateTime.Parse("2017-09-01"), Email="erinkayb@gmail.com"},
                new Student{FirstName="Ardjan",LastName="de Blaeij",EnrollmentDate=DateTime.Parse("2018-09-01"), Email="ajb@gmail.com"},
                new Student{FirstName="Sofia",LastName="Bjorkholm",EnrollmentDate=DateTime.Parse("2019-09-01"), Email="sofia@gmail.com"},
                new Student{FirstName="Stu",LastName="Blarkien",EnrollmentDate=DateTime.Parse("2018-09-01"), Email="stu@gmail.com"},
                new Student{FirstName="Hanneke",LastName="Mader",EnrollmentDate=DateTime.Parse("2018-09-01"), Email="han@gmail.com"},
                new Student{FirstName="Justice",LastName="Louis",EnrollmentDate=DateTime.Parse("2019-09-01"), Email="julo@gmail.com"},
                new Student{FirstName="Lori",LastName="Barr",EnrollmentDate=DateTime.Parse("2016-09-01"), Email="lor@gmail.com"},
                new Student{FirstName="Christopher",LastName="Charbon",EnrollmentDate=DateTime.Parse("2017-09-01"), Email="topher@gmail.com"}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1234,Title="Painting",Credits=3},
            new Course{CourseID=2345,Title="Drawing",Credits=3},
            new Course{CourseID=3456,Title="Photography",Credits=3},
            new Course{CourseID=4567,Title="Film",Credits=4},
            new Course{CourseID=5678,Title="Opera",Credits=4},
            new Course{CourseID=6789,Title="Choir",Credits=3},
            new Course{CourseID=7890,Title="Sculpture",Credits=4}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=2345,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=7890,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4567,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=6789,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1234,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3456,Grade=Grade.D},
            new Enrollment{StudentID=3,CourseID=5678},
            new Enrollment{StudentID=4,CourseID=5678},
            new Enrollment{StudentID=4,CourseID=2345,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4567,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=5678},
            new Enrollment{StudentID=7,CourseID=7890,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}