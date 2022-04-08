using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPRN.Models;
using ProjectPRN.Logics;
namespace ProjectPRN
{
    public partial class frmNewMove : Form
    {
        public frmNewMove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string type = cbType.SelectedValue.ToString();
            string Cat = "";
            int power = 0;
            if (rbPhysic.Checked) 
            {
                Cat = "Physical"; 
                power = (int)nudPower.Value;
            }
            if (rbSpecial.Checked) {

                Cat = "Special";
                power = (int)nudPower.Value;
            }

            if (rbStatus.Checked) Cat = "Status";
            int pp = (int)nudPP.Value;
            try
            {
                if (name.Equals("")) throw new Exception("Name cannot be Empty");
                Move move = new Move();
                move.MoveName = name;
                move.TypeId = Convert.ToInt32(type);
                move.MoveCat=Cat;
                move.MovePower = power;
                move.Pp = pp;
                new MoveLogic().AddMove(move);
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmNewMove_Load(object sender, EventArgs e)
        {
            List<Models.Type> types = new PokeTypeLogic().getAllType();
            cbType.DisplayMember = "TypeName";
            cbType.ValueMember = "TypeId";
            cbType.DataSource = types;
            rbPhysic.Checked = true;
        }
    }
}
