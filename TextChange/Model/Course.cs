using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAOModel.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseDescription { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public int TermId { get; set; }
        public int CampusId { get; set; }
        public Subject CourseSubject { get; set; }

        public Course(int courseId, string courseCode, string courseDescription, int instructorId, 
            string instructorName, int termId, int campusId, Subject courseSubject)
        {
            CourseId = courseId;
            CourseCode = courseCode;
            CourseDescription = courseDescription;
            InstructorId = instructorId;
            InstructorName = instructorName;
            TermId = termId;
            CampusId = campusId;
            CourseSubject = courseSubject;
        }
    }
}
