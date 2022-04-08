
using DemoDAOModel.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextChange.DAL
{
    class SubjectDao
    {
        public static List<Subject> GetAllSubject()
        {
            string sql = @"select S.*, D.DepartmentName from Subjects S, Departments D where 
                            S.DepartmentId = D.DepartmentId";
            DataTable result = DAO.GetDataBySql(sql);
            List<Subject> subjects = new List<Subject>();
            foreach (DataRow dr in result.Rows)  
                subjects.Add(
                    new Subject(
                        Convert.ToInt32(dr["SubjectId"]),
                        dr["SubjectCode"].ToString(),
                        dr["SubjectName"].ToString(),
                        Convert.ToInt32(dr["DepartmentId"]),
                        dr["DepartmentName"].ToString()
                        ));
            return subjects;
        }
    
    }
}
