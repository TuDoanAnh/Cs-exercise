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
    public partial class Form1 : Form
    {
        List<Models.Type> type2s = new List<Models.Type>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pokeLoad();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != -1) { 
                if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("PokeId"))
                {
                    string pokeId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    using (var context = new PokedexContext())
                    {
                        context.Types.ToList();
                        context.Categories.ToList();
                        Pokemon pokemon = context.Pokemons.FirstOrDefault(x => x.PokeId == Convert.ToInt32(pokeId));
                        frmDetail frmDetail = new frmDetail(pokemon);
                        frmDetail.Show();
                    }
                }
            }
        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            string pokeName = tbName.Text;
            if (!pokeName.Equals(""))
            {
                List<Pokemon> pokemons = new List<Pokemon>();
                pokemons = new PokemonLogic().GetPokemonByName(pokeName);
                dataGridView1.DataSource = pokemons;
            }
        }

        private void btAdvance_Click(object sender, EventArgs e)
        {
            string type1 = cbType1.SelectedValue.ToString();
            string type2 = cbType2.SelectedValue.ToString();
            string baseStat = tbBaseStat.Text;

            using(var context = new PokedexContext())
            {
                List<Pokemon> pokemons = context.Pokemons.Where(x => x.TypeId == Convert.ToInt32(type1)).ToList();
                if (!type2.Equals("0"))
                {
                    pokemons = pokemons.Where(x => x.TypeId2 == Convert.ToInt32(type2)).ToList();
                }
                if (!baseStat.Equals(""))
                {
                    pokemons = pokemons.Where(x => (x.Hp+x.Attack+x.Defense+x.SpAttack+x.SpDefense+x.Speed) >= Convert.ToInt32(baseStat)).ToList();
                }

                dataGridView1.DataSource =pokemons;
            }
        }

        private void pokeLoad()
        {
            dataGridView1.DataSource = new PokemonLogic().GetAllPokemons();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            cbType1.DisplayMember = "TypeName";
            cbType1.ValueMember = "TypeId";
            cbType1.DataSource = new PokeTypeLogic().getAllType();

            Models.Type noType = new Models.Type();
            noType.TypeName = "None";
            noType.TypeId = 0;
            cbType2.DisplayMember = "TypeName";
            cbType2.ValueMember = "TypeId";
            type2s = new PokeTypeLogic().getAllType();
            type2s.Insert(0, noType);
            cbType2.DataSource = type2s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pokeLoad();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            frmTactic frmTactic = new frmTactic();
            frmTactic.Show();
            this.Hide();
        }
    }
}

