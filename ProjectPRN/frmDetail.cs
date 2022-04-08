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
    public partial class frmDetail : Form
    {
        public Pokemon curPokemon { get; }
        public frmDetail(Pokemon pokemon)
        {
            curPokemon = pokemon;
            InitializeComponent();
        }

        private void frmDetail_Load(object sender, EventArgs e)
        {
            lbNumber.Text = curPokemon.PokeId.ToString();
            lbName.Text = curPokemon.PokemonName;
            pbImage.Image = Image.FromFile(curPokemon.Img);
            tbDescribe.Text = curPokemon.Describe;
            lbHeight.Text = curPokemon.Height.ToString();
            lbWeight.Text = curPokemon.Weight.ToString();
            lbCat.Text = curPokemon.Cat.CatName;
            lbGen.Text = curPokemon.Gen.ToString();
            lbMale.Text = curPokemon.MaleRate.ToString();
            lbFemale.Text = curPokemon.FemaleRate.ToString();
            lbHP.Text = curPokemon.Hp.ToString();
            lbAttack.Text = curPokemon.Attack.ToString();
            lbDef.Text = curPokemon.Defense.ToString();
            lbSpAttack.Text = curPokemon.SpAttack.ToString();
            lbSpDef.Text = curPokemon.SpDefense.ToString();
            lbSpeed.Text = curPokemon.Speed.ToString();
            btType1.Text = curPokemon.Type.TypeName;
            btType2.Text = curPokemon.TypeId2Navigation.TypeName;
        }
    }
}
