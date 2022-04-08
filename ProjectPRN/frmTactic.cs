using ProjectPRN.Logics;
using ProjectPRN.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPRN
{
    public partial class frmTactic : Form
    {
        public frmTactic()
        {
            InitializeComponent();
        }

        private void frmTactic_Load(object sender, EventArgs e)
        {
            LoadStat();
        }

        private void LoadStat()
        {
            List<Pokemon> pokemons = new PokemonLogic().GetAllPokemons();
            cbPoke.DisplayMember = "PokemonName";
            cbPoke.ValueMember = "PokeId";
            cbPoke.DataSource = pokemons;

            List<Nature> natures =new NatureLogic().GetAllNature();
            cbNature.DisplayMember = "NatureName";
            cbNature.ValueMember = "NatureId";
            cbNature.DataSource = natures;
        }

        private void btGetPoke_Click(object sender, EventArgs e)
        {
            string PokeId = cbPoke.SelectedValue.ToString();
            Pokemon pokemons = new PokemonLogic().GetPokemonById(Convert.ToInt32(PokeId));
            lbBaseHP.Text = pokemons.Hp.ToString();
            lbBaseAttack.Text = pokemons.Attack.ToString();
            lbBaseDef.Text = pokemons.Defense.ToString();
            lbBaseSpAtk.Text = pokemons.SpAttack.ToString();
            lbBaseSPDef.Text = pokemons.SpDefense.ToString();
            lbBaseSpeed.Text = pokemons.Speed.ToString();
        }

        private void btTotal_Click(object sender, EventArgs e)
        {
            string IVHp = tbIHP.Text;
            string IVAtk = tbIAtk.Text;
            string IVDef = tbIDef.Text;
            string IVSpAtk = tbISpAtk.Text;
            string IVSpDef = tbISpDef.Text;
            string IVSpeed = tbISpeed.Text;

            string EVHp = tbEHp.Text;
            string EVAtk = tbEAtk.Text;
            string EVDef = tbEDef.Text;
            string EVSpAtk = tbESpAtk.Text;
            string EVSpDef = tbESpDef.Text;
            string EVSpeed = tbESpeed.Text;

            string natureID = cbNature.SelectedValue.ToString();
            Nature nature = new NatureLogic().GetNatureByID(Convert.ToInt32(natureID));
            
            if (!IVHp.Equals(""))
            {
                lbTotalHp.Text = HpCalculate(Convert.ToInt32(IVHp), Convert.ToInt32(EVHp)).ToString();
                lbTotalAtk.Text = OtherCalculate(Convert.ToInt32(IVAtk), Convert.ToInt32(EVAtk), "Attack", nature.IncreaseStat, nature.DecreaseStat).ToString();
                lbTotalDef.Text = OtherCalculate(Convert.ToInt32(IVDef), Convert.ToInt32(EVDef), "Defense", nature.IncreaseStat, nature.DecreaseStat).ToString();
                lbTotalSpAtk.Text = OtherCalculate(Convert.ToInt32(IVSpAtk), Convert.ToInt32(EVSpAtk), "SpAttack", nature.IncreaseStat, nature.DecreaseStat).ToString();
                lbTotalSpDef.Text = OtherCalculate(Convert.ToInt32(IVSpDef), Convert.ToInt32(EVSpDef), "SpDefense", nature.IncreaseStat, nature.DecreaseStat).ToString();
                lbTotalSpeed.Text = OtherCalculate(Convert.ToInt32(IVSpeed), Convert.ToInt32(EVSpeed), "Speed", nature.IncreaseStat, nature.DecreaseStat).ToString();
            }
        }
        private double HpCalculate(int Iv, int Ev)
        {
            int Hp = Convert.ToInt32(lbBaseHP.Text);
            int Level = (int)nudLevel.Value;
            double actualEv = Math.Floor((double)Ev/4);
            double temp = Math.Floor((double)((2 * Hp + Iv + actualEv)*Level)/100);
            return temp + Level + 10;
        }

        private double OtherCalculate(int Iv, int Ev, string StatName, string Increase, string Decrease)
        {
            int BaseStat = 0;
            int Level = (int)nudLevel.Value;
            double NaturePoint = 1;
            if (StatName.Equals("Attack"))
            {
                BaseStat = Convert.ToInt32(lbBaseAttack.Text);
            }else if (StatName.Equals("Defense"))
            {
                BaseStat = Convert.ToInt32(lbBaseDef.Text);
            }else if (StatName.Equals("SpAttack"))
            {
                BaseStat = Convert.ToInt32(lbBaseSpAtk.Text);
            }else if (StatName.Equals("SpDefense"))
            {
                BaseStat = Convert.ToInt32(lbBaseSPDef.Text);
            }else if (StatName.Equals("Speed"))
            {
                BaseStat = Convert.ToInt32(lbBaseSpeed.Text);
            }
            double actualEv = Math.Floor((double)Ev / 4);
            double temp = Math.Floor((double)((2 * BaseStat + Iv + actualEv) * Level) / 100) + 5;

            if (StatName.Equals(Increase))
            {
                NaturePoint = 1.1;
            }
            if (StatName.Equals(Decrease))
            {
                NaturePoint = 0.9;
            }
            double result = Math.Floor(temp * NaturePoint);
            return result;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCounter frmCounter = new frmCounter();
            frmCounter.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDamage frmDamage = new frmDamage();
            frmDamage.Show();
            this.Hide();        }
    }  
}
