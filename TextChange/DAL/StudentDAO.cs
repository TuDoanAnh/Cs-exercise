using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextChange.Model;

namespace TextChange.DAL
{
    class StudentDAO
    {
        public static List<Student> GetAllStudents()
        {
            string sql = "select * from Students";
            DataTable dt = DAO.GetDataBySql(sql);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(Convert.ToInt32(dr["StudentId"]), dr["Roll#"].ToString(), dr["FirstName"].ToString(), dr["MidName"].ToString(), dr["LastName"].ToString()));
            }
            return students;
        }

        public static Student GetByStudentId(int StudentId)
        {
            string sql = "select * from STUDENTS where StudentId = @sid";
            SqlParameter parameter1 = new SqlParameter("@sid", DbType.Int32);
            parameter1.Value = StudentId;
            DataTable dt = DAO.GetDataBySql(sql, parameter1); 
            if (dt.Rows.Count == 0) return null; 
            DataRow dr = dt.Rows[0];
            return new Student(Convert.ToInt32(dr["StudentId"]), 
                dr["Roll#"].ToString(), dr["FirstName"].ToString(), 
                dr["MidName"].ToString(), dr["LastName"].ToString());
        }

        public static List<Student> GetAllStudentsByCourseId(int CourseID)
        {
            String sql = "Select * from STUDENTS where CourseID = @cid";
            SqlParameter param = new SqlParameter("@cid", SqlDbType.Int);
            param.Value = CourseID;
            DataTable dt = DAO.GetDataBySql(sql, param);
            List<Student> students = new List<Student>();
            foreach (DataRow dr in dt.Rows)
            {
                students.Add(new Student(Convert.ToInt32(dr["StudentId"]), dr["Roll#"].ToString(), dr["FirstName"].ToString(), dr["MidName"].ToString(), dr["LastName"].ToString()));
            }
            return students;
        }
    }
}
