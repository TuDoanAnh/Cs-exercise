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
    public partial class frmDamage : Form
    {
        public frmDamage()
        {
            InitializeComponent();
        }

        private void frmDamage_Load(object sender, EventArgs e)
        {
            List<Pokemon> pokemons = new PokemonLogic().GetAllPokemons();
            List<Pokemon> pokemons2 = new PokemonLogic().GetAllPokemons();
            cbYour.DisplayMember = "PokemonName";
            cbYour.ValueMember = "PokeId";

            cbEnemy.DisplayMember = "PokemonName";
            cbEnemy.ValueMember = "PokeId";

            cbYour.DataSource = pokemons;
            cbEnemy.DataSource = pokemons2;

            List<Move> moves = new MoveLogic().GetAllMoves();
            cbMove.DisplayMember = "MoveName";
            cbMove.ValueMember = "MoveId";
            cbMove.DataSource = moves;
        }

        private void btGetCounter_Click(object sender, EventArgs e)
        {
            string yourPokeId = cbYour.SelectedValue.ToString();
            string enemyPokeId = cbEnemy.SelectedValue.ToString();
            int yourLevel = (int)nudYour.Value;
            int enemyLevel = (int)nudEnemy.Value;
            string moveId = cbMove.SelectedValue.ToString();
            Boolean burn = false;
            if (check1.Checked) burn = true;
            int attack = (int)nudAttack.Value;
            int defense = (int)nudDefense.Value;

            Pokemon yourPokemon = new PokemonLogic().GetPokemonById(Convert.ToInt32(yourPokeId));
            Pokemon enemyPokemon = new PokemonLogic().GetPokemonById(Convert.ToInt32(enemyPokeId));
            Move move = new MoveLogic().GetMoveById(Convert.ToInt32(moveId));

            double temp = ((2 * yourLevel) / 5 + 2);
            double movePower = (double)move.MovePower;
            double standardDamage = (double)Math.Floor((temp * movePower * (attack / defense)) / 50 + 2);

            double modifier = 1;
            if (yourPokemon.TypeId == Convert.ToInt32(moveId) || yourPokemon.TypeId2 == Convert.ToInt32(moveId)) modifier *= 1.5;
            
            if (burn) modifier *= 0.5;
            
            Random rand = new Random();
            double randomDamage = (double)rand.Next(85,100)/100;
            
            modifier *= randomDamage;
            Models.Type moveType = new Models.Type();
           using(var context = new PokedexContext())
            {
                moveType = context.Types.First(x => x.TypeId == Convert.ToInt32(moveId));

            }
            double[] curRateType = new double[18];
            curRateType = ConvertTypeRate(moveType);
            if (enemyPokemon.TypeId2==0)
            {
                modifier *= curRateType[(int)(enemyPokemon.TypeId)-1];
            }
            else
            {
                modifier *= curRateType[(int)enemyPokemon.TypeId-1] * curRateType[(int)(enemyPokemon.TypeId2)-1];
            }

            double EstimateDamage = Math.Floor(standardDamage * modifier);

            lbStandard.Text = standardDamage.ToString();
            lbEstimate.Text = EstimateDamage.ToString();
            lbStandard.Visible = true;
            lbEstimate.Visible = true;
        }

        private double[] ConvertTypeRate(Models.Type type)
        {
            double[] rate = new double[18];
              rate[0]= type.NormalRate;
              rate[1] = type.FireRate;
              rate[2] = type.WaterRate;
              rate[3] = type.GrassRate;
              rate[4] = type.ElectricRate;
              rate[5] = type.IceRate;
              rate[6] = type.FightingRate;
              rate[7] = type.PoisonRate;
              rate[8] = type.GroundRate;
              rate[9] = type.FlyingRate;
              rate[10] = type.PsychicRate;
              rate[11] = type.BugRate;
              rate[12] = type.RockRate;
              rate[13] = type.GhostRate;
              rate[14] = type.DragonRate;
              rate[15] = type.DarkRate;
              rate[16] = type.SteelRate;
              rate[17] = type.FairyRate;

            return rate;
        }
    }
}
