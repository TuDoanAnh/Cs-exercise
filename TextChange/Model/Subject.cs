using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDAOModel.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public Subject(int subjectId, string subjectCode, string subjectName, int departmentId, string departmentName)
        {
            SubjectId = subjectId;
            SubjectCode = subjectCode;
            SubjectName = subjectName;
            DepartmentId = departmentId;
            DepartmentName = departmentName;
        }

        public override string ToString()
        {
            return $"{SubjectCode} - {SubjectName}";
        }
    }
}
