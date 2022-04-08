
using DemoDAOModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChange.DAL
{
    class CourseDao
    {
        public static List<Course> GetCouresBySubject(int SubjectId)
        {
            string sql = @"select C.*, S.SubjectCode, S.SubjectName,  S.DepartmentId, 
                            D.DepartmentName, I.InstructorFirstName + ' ' + I.InstructorLastName InstructorName
                            from Courses C, Subjects S, Instructors I, Departments D where
                            C.SubjectId = S.SubjectId and C.InstructorId = I.InstructorId and 
                            S.DepartmentId = D.DepartmentId
                            and C.SubjectId = @subid";
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@subid", SqlDbType.Int);
            param[0].Value = SubjectId;
            DataTable result = DAO.GetDataBySql(sql, param);
            List<Course> courses = new List<Course>();
            foreach (DataRow dr in result.Rows)
            {
                Subject s = new Subject(Convert.ToInt32(dr["SubjectId"]),
                        dr["SubjectCode"].ToString(),
                        dr["SubjectName"].ToString(),
                        Convert.ToInt32(dr["DepartmentId"]),
                        dr["DepartmentName"].ToString());
                courses.Add(
                    new Course(
                        Convert.ToInt32(dr["CourseId"]),
                        dr["CourseCode"].ToString(),
                        dr["CourseDescription"].ToString(),
                        Convert.ToInt32(dr["InstructorId"]),
                        dr["InstructorName"].ToString(),
                        dr["TermId"] is DBNull ? 0 : Convert.ToInt32(dr["TermId"]),
                        dr["CampusId"] is DBNull ? 0 : Convert.ToInt32(dr["CampusId"]),
                        s
                        ));
            }
            return courses;
        }

        //add them course vao csdl
        public static int AddCourse(Course course)
        {
            string sql = "insert into ....@para";
            SqlParameter[] parameters = new SqlParameter[4];
            return DAO.ExecuteBySql(sql, parameters);
        }
    }
}
