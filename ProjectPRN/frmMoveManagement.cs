using ProjectPRN.Logics;
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
namespace ProjectPRN
{
    public partial class frmMoveManagement : Form
    {
        public frmMoveManagement()
        {
            InitializeComponent();
        }

        private void frmMoveManagement_Load(object sender, EventArgs e)
        {
            LoadMove();
        }

        private void LoadMove()
        {
            dataGridView1.DataSource = null;

            using(var context = new PokedexContext())
            {
                var moves = context.Moves.Select(x => new
                {
                    MoveId = x.MoveId,
                    MoveName = x.MoveName,
                    TypeName = x.Type.TypeName,
                    MoveCat = x.MoveCat,
                    MovePower = x.MovePower,
                    PP = x.Pp
                }).ToList();

                dataGridView1.AutoGenerateColumns = false;

                dataGridView1.Columns.Add("Id", "MoveId");
                dataGridView1.Columns["Id"].DataPropertyName = "MoveId";

                dataGridView1.Columns.Add("name", "Move Name");
                dataGridView1.Columns["name"].DataPropertyName = "MoveName";

                dataGridView1.Columns.Add("type", "Type");
                dataGridView1.Columns["type"].DataPropertyName = "TypeName";

                dataGridView1.Columns.Add("cat", "Category");
                dataGridView1.Columns["cat"].DataPropertyName = "MoveCat";

                dataGridView1.Columns.Add("power", "Power");
                dataGridView1.Columns["power"].DataPropertyName = "MovePower";

                dataGridView1.Columns.Add("pp", "PP");
                dataGridView1.Columns["pp"].DataPropertyName = "PP";

                DataGridViewButtonColumn editcol = new DataGridViewButtonColumn();
                editcol.Name = "editcol";
                editcol.HeaderText = "Edit";
                editcol.Text = "Edit Move";
                editcol.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(editcol);


                DataGridViewLinkColumn delcol = new DataGridViewLinkColumn();
                delcol.Name = "delcol";
                delcol.HeaderText = "Delete";
                delcol.Text = "Del Move";
                delcol.UseColumnTextForLinkValue = true;
                dataGridView1.Columns.Add(delcol);


                dataGridView1.DataSource = moves;
            } 
            
        }
        private void Add_close(object sender, EventArgs e)
        {
            LoadMove();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmNewMove frmNewMove = new frmNewMove();
            frmNewMove.Show();
            frmNewMove.FormClosed += Add_close;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("delcol"))
            {
                if (e.RowIndex != -1)
                {
                    String moveId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    DialogResult rs = MessageBox.Show("Confirm?", "Ok", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        new MoveLogic().DeleteMoveById(Convert.ToInt32(moveId));
                        LoadMove();
                    }
                }
            }
                if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("editcol"))
                {
                    if(e.RowIndex != -1)
                    {
                        String moveId = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Move move = new MoveLogic().GetMoveById(Convert.ToInt32(moveId));
                        EditMove editMove = new EditMove(move);
                        editMove.Show();
                        editMove.FormClosed += Add_close;
                }
                }
            }


        }
    }
