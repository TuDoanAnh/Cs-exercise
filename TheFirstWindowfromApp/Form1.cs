using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheFirstWindowfromApp
{
    public partial class Form1 : Form
    {
        List<Button> btNewButtonList = new List<Button>();
        int count = 0;
        int maxRox = 0;
        int maxCol = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAddNewButton_Click(object sender, EventArgs e)
        {
            if (maxCol <= 3)
            {
                if (maxRox < 6)
                {
                    if (count == 0)
                    {
                        Button btNewButton = new Button();
                        btNewButton.Text = "Button" + count;
                        btNewButton.Size = new Size(btAddNewButton.Width, btAddNewButton.Height);
                        btNewButton.Location = new Point(btAddNewButton.Location.X, btAddNewButton.Location.Y + btAddNewButton.Height + 10);
                        this.Controls.Add(btNewButton);
                        btNewButtonList.Add(btNewButton);
                        count++;
                        maxRox++;
                    }
                    else
                    {
                        Button btNewButton = new Button();
                        btNewButton.Text = "Button" + count; ;
                        btNewButton.Size = new Size(btNewButtonList[count - 1].Width, btNewButtonList[count - 1].Height);
                        btNewButton.Location = new Point(btNewButtonList[count - 1].Location.X, btNewButtonList[count - 1].Location.Y + btAddNewButton.Height + 10);
                        this.Controls.Add(btNewButton);
                        btNewButtonList.Add(btNewButton);
                        count++;
                        maxRox++;
                    }
                    if (maxRox == 6) maxCol++;
                }
                else
                {
                    if (maxRox == 6)
                    {
                        maxRox = 0;
                    }
                    if (maxRox == 0)
                    {
                        Button btNewButton = new Button();
                        btNewButton.Text = "Button" + count;
                        btNewButton.Size = new Size(btAddNewButton.Width, btAddNewButton.Height);
                        btNewButton.Location = new Point(btNewButtonList[count - 6].Location.X + btAddNewButton.Width + 25, btNewButtonList[count - 6].Location.Y);
                        this.Controls.Add(btNewButton);
                        btNewButtonList.Add(btNewButton);
                        count++;
                        maxRox++;
                    }
                    else
                    {
                        Button btNewButton = new Button();
                        btNewButton.Text = "Button" + count; ;
                        btNewButton.Size = new Size(btNewButtonList[count - 1].Width, btNewButtonList[count - 1].Height);
                        btNewButton.Location = new Point(btNewButtonList[count - 1].Location.X + btAddNewButton.Width + 25, btNewButtonList[count - 1].Location.Y + btAddNewButton.Height + 10);
                        this.Controls.Add(btNewButton);
                        btNewButtonList.Add(btNewButton);
                        count++;
                        maxRox++;
                    }
                }
                textBox1.Text = "Number of button: " + count;
            }
        }
    }
}
