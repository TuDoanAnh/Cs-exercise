using TextChange.DAL;
using TextChange.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextChange
{
    public partial class frmStudentManagement : Form
    {
        public frmStudentManagement()
        {
            InitializeComponent();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "SubjectId";
            List<Subject> subjects = SubjectDao.GetAllSubject();
            cbSubject.DataSource = subjects;            
        }

        private void LoadCourses()
        {
            int SubjectId = Convert.ToInt32(cbSubject.SelectedValue);
            List<Course> courses = CourseDao.GetCouresBySubject(SubjectId);
            cbCourse.DisplayMember = "CourseCode";
            cbCourse.ValueMember = "CourseId";
            cbCourse.DataSource = courses;
        }

        private void LoadStudents()
        {
            int CourseId = Convert.ToInt32(cbCourse.SelectedValue);
            List<Student> students = StudentDAO.GetAllStudentsByCourseId(CourseId);
            dataGridView1.DataSource = students;
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCourses();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStudents();
        }
    }
}
