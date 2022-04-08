using System;
using System.Collections.Generic;

#nullable disable

namespace WinFormsApp1.Models
{
    public partial class Student
    {
        public Student()
        {
            RollCallBooks = new HashSet<RollCallBook>();
            StudentCourses = new HashSet<StudentCourse>();
        }

        public int StudentId { get; set; }
        public string Roll { get; set; }
        public string FirstName { get; set; }
        public string MidName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                if (MidName ==null||MidName.Equals(string.Empty))
                    return $"{LastName} {FirstName}";
                else
                    return $"{LastName} {MidName} {FirstName}";
            }
        }

        public virtual ICollection<RollCallBook> RollCallBooks { get; set; }
        public virtual ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
