using Microsoft.AspNetCore.Mvc;
using FirstWebApp.Models;
using System.Collections.Generic;
using System.Linq;
using FirstWebApp.Logic;

namespace FirstWebApp.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }  

        public IActionResult List(int id)
        {
            List<Subject> subjects = (new SubjectLogic()).ListAllSubject();
            List<Course> courses;
            CourseLogic courseLogic = new CourseLogic();
            if (id == 0)
            {
                courses = courseLogic.ListAllCourse();
            }
            else
            {
                courses = courseLogic.ListCourseBySubject(id);
            }
            ViewBag.Subjects = subjects;
            return View(courses);
        }

        public IActionResult Edit(int id)
        {
            Course course = (new CourseLogic()).GetCourse(id);
            if(course != null)
            {
                List<Subject> subjects = (new SubjectLogic()).ListAllSubject();
                List<Instructor> instructors = (new InstructorLogic()).ListAllInstructor();
                ViewBag.Subjects = subjects;
                ViewBag.Instructors = instructors;
            }
            return View(course);
        }

        public IActionResult DoEdit(Course NewCourse)
        {
            (new CourseLogic()).UpdateCourse(NewCourse);
            return Redirect("/Course/List/" + NewCourse.SubjectId);
        }

        public IActionResult DoDelete(int id)
        {
            (new CourseLogic()).DeleteCourse(id);
            return Redirect("/Course/List/");
        }
    }
}
