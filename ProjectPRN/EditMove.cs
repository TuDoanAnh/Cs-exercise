using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectPRN.Logics;
using ProjectPRN.Models;
namespace ProjectPRN
{
    public partial class EditMove : Form
    {
        public Move move { get; }
        public EditMove(Move curMove)
        {
            InitializeComponent();
            move = curMove;
        }

        private void EditMove_Load(object sender, EventArgs e)
        {
            tbName.Text = move.MoveName;
            List<Models.Type> types = new PokeTypeLogic().getAllType();
            cbType.DisplayMember = "TypeName";
            cbType.ValueMember = "TypeId";
            cbType.DataSource = types;
            cbType.SelectedIndex = move.TypeId - 1;
            if (move.MoveCat.Equals("Physical"))
            {
                rbPhysic.Checked = true;
                nudPower.Text = move.MovePower.ToString();
            }

            if (move.MoveCat.Equals("Special"))
            {
                rbSpecial.Checked = true;
                nudPower.Value = (decimal)move.MovePower;
            }

            if (move.MoveCat.Equals("Status"))
            {
                rbStatus.Checked = true;
                nudPower.Text = "0";
            }
            nudPP.Value = (decimal)move.Pp;
            tbMoveId.Text = move.MoveId.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string moveName = tbName.Text;
            string typeId = cbType.SelectedValue.ToString();
            string moveId = tbMoveId.Text;
            string Cat = "";
            int power = 0;
            if (rbPhysic.Checked)
            {
                Cat = "Physical";
                power = (int)nudPower.Value;
            }
            if (rbSpecial.Checked)
            {

                Cat = "Special";
                power = (int)nudPower.Value;
            }

            if (rbStatus.Checked) Cat = "Status";
            int pp = (int)nudPP.Value;
            try
            {
                if (moveName.Equals("")) throw new Exception("Name can not be mpty");
                Move move  = new Move();
                move.MoveId = Convert.ToInt32(moveId);
                move.MoveName = moveName;
                move.TypeId = Convert.ToInt32(typeId);
                move.MoveCat = Cat;
                move.MovePower= Convert.ToInt32(power);
                move.Pp = Convert.ToInt32(pp);

                new MoveLogic().EditMove(move);
                Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
