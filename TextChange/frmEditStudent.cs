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
    public partial class frmEditStudent : Form
    {
        public Student CurrentStudent { get; }

        public frmEditStudent(Student student)
        {
            CurrentStudent = student;
            InitializeComponent();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            Student student = new Student(
                Convert.ToInt32( tbId.Text),
                tbRollNumber.Text, 
                tbFirstName.Text,
                tbMidName.Text,
                tbLastName.Text
                );
            int count = StudentDAO.EditStudent(student);
            if (count > 0)
                MessageBox.Show("Edit du lieu thanh cong");
            else MessageBox.Show("Loi gi do, chua cap nhat dc du lieu");
            this.Close();
        }

        private void frmEditStudent_Load(object sender, EventArgs e)
        {
            tbId.Text = CurrentStudent.StudentId.ToString();
            tbRollNumber.Text = CurrentStudent.RollNumber;
            tbFirstName.Text = CurrentStudent.FirstName;
            tbMidName.Text = CurrentStudent.MidName;
            tbLastName.Text = CurrentStudent.LastName;

        }
    }
}
