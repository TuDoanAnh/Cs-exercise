using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Logic;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        List<Student> students;
        List<Student> selectedStudents = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadInstructors();
            LoadStudents();
        }

        private void LoadSubjects()
        {
            cbSubject.DisplayMember = "SubjectName";
            cbSubject.ValueMember = "SubjectId";
            cbSubject.DataSource = new SubjectLogic().getAllSubject();
        }

        private void LoadInstructors()
        {
            cbInstructor.DisplayMember = "InstructorFullName";
            cbInstructor.ValueMember = "InstructorId";
            cbInstructor.DataSource = new InstructorLogic().getAllInstructor();
        }

        private void LoadStudents()
        {
            lsAllStudent.DisplayMember = "FullName";
            lsAllStudent.ValueMember = "StudentId";
            students = (new StudentLogic().getAllStudents());
            lsAllStudent.DataSource = students;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (Object o in lsAllStudent.SelectedItems)
            {
                Student s = (Student)o;
                students.Remove(students.First(x => x.StudentId == s.StudentId));
                selectedStudents.Add(s);
            }
            lsAllStudent.DataSource = null;
            lsSelectedStudent.DataSource = null;
            lsAllStudent.DisplayMember = "FullName";
            lsAllStudent.ValueMember = "StudentId";
            lsSelectedStudent.DisplayMember = "FulllName";
            lsSelectedStudent.ValueMember = "StudentId";
            lsAllStudent.DataSource = students;
            lsSelectedStudent.DataSource = selectedStudents;
        }
    }
}
