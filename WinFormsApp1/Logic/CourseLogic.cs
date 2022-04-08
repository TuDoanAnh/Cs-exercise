using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic
{
    internal class CourseLogic
    {
        public int addCourse(Course course, List<Student> students)
        {
            using(APDatabaseContext context = new APDatabaseContext())
            {
                
                context.Courses.Add(course);
                context.SaveChanges();
                course = context.Courses.First(x => x.CourseCode == course.CourseCode);
                foreach (Student student in students)
                {
                    StudentCourse sc = new StudentCourse();
                    sc.CourseId = course.CourseId;
                    sc.StudentId = student.StudentId;
                    course.StudentCourses.Add(sc);
                }
                context.SaveChanges();
            }
            return 1;
        }
    }
}
