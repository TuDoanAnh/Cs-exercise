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
    public partial class frmCounter : Form
    {
        public frmCounter()
        {
            InitializeComponent();
        }

        private void frmCounter_Load(object sender, EventArgs e)
        {
            List<Models.Type> types1 = new PokeTypeLogic().getAllType();
            List<Models.Type> types2 = new PokeTypeLogic().getAllType();

            cbType1.DisplayMember = "TypeName";
            cbType1.ValueMember = "TypeId";
            cbType1.DataSource = types1;
            
            Models.Type t = new Models.Type();
            t.TypeId = 0;
            t.TypeName = "None";
            types2.Insert(0, t);
            cbType2.DisplayMember = "TypeName";
            cbType2.ValueMember = "TypeId";
            cbType2.DataSource = types2;

        }

        private void btGetCounter_Click(object sender, EventArgs e)
        {
            string type1 = cbType1.SelectedValue.ToString();
            string type2 = cbType2.SelectedValue.ToString();
            string take4x = "";
            string take2x = "";
            string take1x = "";
            string takeHaflx = "";
            string takeQuadx = "";
            string take0x = "";
            List<Models.Type> types = new PokeTypeLogic().getAllType();
            double[] rate = new double[18];

            Models.Type typeRate1 = types.FirstOrDefault(x => x.TypeId==Convert.ToInt32(type1));
            double[] rate1 = new double[18];
            rate1 = TakeRate(typeRate1);

            if (!type2.Equals("0"))
            {
                Models.Type typeRate2 = types.FirstOrDefault(x => x.TypeId == Convert.ToInt32(type2));
                double[] rate2 = new double[18];
                rate2 = TakeRate(typeRate2);
                for (int i=0; i<rate1.Length; i++)
                {
                    rate[i] = rate1[i] * rate2[i];
                }
            }
            else
            {
                for (int i = 0; i < rate1.Length; i++)
                {
                    rate[i] = rate1[i];
                }
            }
            PokeTypeLogic pokeTypeLogic = new PokeTypeLogic();
            for(int j = 0; j< rate.Length; j++)
            {
                if (rate[j] == 0) take0x +=" "+pokeTypeLogic.GetNameByID(j+1);
                if (rate[j] == 0.25) takeQuadx += " " + pokeTypeLogic.GetNameByID(j+1);
                if (rate[j] == 0.5) takeHaflx += " " + pokeTypeLogic.GetNameByID(j+1);
                if (rate[j] == 1) take1x += " " + pokeTypeLogic.GetNameByID(j+1);
                if (rate[j] == 2) take2x += " " + pokeTypeLogic.GetNameByID(j+1);
                if (rate[j] == 4) take4x += " " + pokeTypeLogic.GetNameByID(j+1);
            }

            lb4x.Text = take4x; lb4x.Visible = true;
            lb2x.Text = take2x; lb2x.Visible = true;
            lb1x.Text = take1x; lb1x.Visible = true; 
            lbHalfx.Text = takeHaflx; lbHalfx.Visible = true;
            lbQuadx.Text = takeQuadx; lbQuadx.Visible = true;
            lb0x.Text = take0x; lb0x.Visible = true;
        }
        private double[] TakeRate(Models.Type type)
        {
            double[] temp = new double[18];
            temp[0] = type.NormalRate;
            temp[1] = type.FireRate;
            temp[2] = type.WaterRate;
            temp[3] = type.GrassRate;
            temp[4] = type.ElectricRate;
            temp[5] = type.IceRate;
            temp[6] = type.FightingRate;
            temp[7] = type.PoisonRate;
            temp[8] = type.GroundRate;
            temp[9] = type.FlyingRate;
            temp[10] = type.PsychicRate;
            temp[11] = type.BugRate;
            temp[12] = type.RockRate;
            temp[13] = type.GhostRate;
            temp[14] = type.DragonRate;
            temp[15] = type.DarkRate;
            temp[16] = type.SteelRate;
            temp[17] = type.FairyRate;

            return temp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDamage frmDamage = new frmDamage();
            frmDamage.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTactic frmTactic = new frmTactic();
            frmTactic.Show();
            this.Hide();
        }
    }
}
