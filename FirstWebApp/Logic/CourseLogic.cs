using FirstWebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace FirstWebApp.Logic
{
    public class CourseLogic
    {
        public List<Course> ListAllCourse()
        {
            using(var context = new APDatabaseContext())
            {
                return context.Courses.ToList();
            }
        }

        public List<Course> ListCourseBySubject(int SubjectId)
        {
            using(var context = new APDatabaseContext())
            {
                return context.Courses.Where(x => x.SubjectId == SubjectId).ToList();
            }
        }

        public Course GetCourse(int CourseId)
        {
            using(var context = new APDatabaseContext())
            {
               return context.Courses.FirstOrDefault(x => x.CourseId == CourseId);
            }
        }

        public void UpdateCourse(Course NewCourse)
        {
            using(var context =new APDatabaseContext())
            {
                Course Old = context.Courses.FirstOrDefault(x => x.CourseId == NewCourse.CourseId);
                if(Old != null)
                {
                    Old.CourseCode = NewCourse.CourseCode;
                    Old.CourseDescription = NewCourse.CourseDescription;
                    Old.SubjectId = NewCourse.SubjectId;
                    Old.InstructorId = NewCourse.InstructorId;
                    Old.CampusId = NewCourse.CampusId;
                    Old.TermId = NewCourse.TermId;
                    context.SaveChanges();
                }
            }
        }

        public void AddCourse(Course NewCourse)
        {
            using(var context = new APDatabaseContext())
            {
                context.Courses.Add(NewCourse);
                context.SaveChanges();
            }
        }

        public void DeleteCourse(int CourseId)
        {
            using(var context =new APDatabaseContext())
            {
                Course CurCourse = context.Courses.FirstOrDefault(x => x.CourseId==CourseId);
                if (CurCourse == null) return;
                List<StudentCourse> studentCourses = context.StudentCourses.Where(x => x.CourseId == CourseId).ToList();
                context.StudentCourses.RemoveRange(studentCourses);

                List<CourseSchedule> courseSchedules = context.CourseSchedules.Where(x => x.CourseId == CourseId).ToList();
                foreach (CourseSchedule courseSchedule in courseSchedules)
                {
                    List<RollCallBook> rollCallBooks = context.RollCallBooks.Where(x=>x.TeachingScheduleId == courseSchedule.TeachingScheduleId).ToList();
                    context.RollCallBooks.RemoveRange(rollCallBooks);
                }

                context.CourseSchedules.RemoveRange(courseSchedules);

                context.Courses.Remove(CurCourse);
                context.SaveChanges();
            }
        }
    }
}
