namespace NorthWindWF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployees = new System.Windows.Forms.ComboBox();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.cbShipVia = new System.Windows.Forms.ComboBox();
            this.tbShipName = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btFilter = new System.Windows.Forms.Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.lbTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(89, 3);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(192, 28);
            this.cbCustomer.TabIndex = 0;
            // 
            // cbEmployees
            // 
            this.cbEmployees.FormattingEnabled = true;
            this.cbEmployees.Location = new System.Drawing.Point(350, 3);
            this.cbEmployees.Name = "cbEmployees";
            this.cbEmployees.Size = new System.Drawing.Size(190, 28);
            this.cbEmployees.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Location = new System.Drawing.Point(89, 37);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(190, 27);
            this.dtpFrom.TabIndex = 2;
            this.dtpFrom.Value = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(350, 37);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(188, 27);
            this.dtpTo.TabIndex = 3;
            // 
            // cbShipVia
            // 
            this.cbShipVia.FormattingEnabled = true;
            this.cbShipVia.Location = new System.Drawing.Point(88, 70);
            this.cbShipVia.Name = "cbShipVia";
            this.cbShipVia.Size = new System.Drawing.Size(190, 28);
            this.cbShipVia.TabIndex = 4;
            // 
            // tbShipName
            // 
            this.tbShipName.Location = new System.Drawing.Point(350, 71);
            this.tbShipName.Name = "tbShipName";
            this.tbShipName.Size = new System.Drawing.Size(190, 27);
            this.tbShipName.TabIndex = 5;
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(88, 104);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(189, 28);
            this.cbCountry.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(88, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(587, 302);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(89, 150);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(94, 29);
            this.btFilter.TabIndex = 8;
            this.btFilter.Text = "Filter";
            this.btFilter.UseVisualStyleBackColor = true;
            this.btFilter.Click += new System.EventHandler(this.btFilter_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(89, 531);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(42, 20);
            this.lbTotal.TabIndex = 9;
            this.lbTotal.Text = "Total";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.lbOrderID);
            this.panel1.Location = new System.Drawing.Point(681, 197);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 302);
            this.panel1.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 52);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(409, 247);
            this.dataGridView2.TabIndex = 1;
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(187, 15);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(62, 20);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "OrderID";
            // 
            // lbTotalPrice
            // 
            this.lbTotalPrice.AutoSize = true;
            this.lbTotalPrice.Location = new System.Drawing.Point(684, 531);
            this.lbTotalPrice.Name = "lbTotalPrice";
            this.lbTotalPrice.Size = new System.Drawing.Size(42, 20);
            this.lbTotalPrice.TabIndex = 2;
            this.lbTotalPrice.Text = "Total";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 578);
            this.Controls.Add(this.lbTotalPrice);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.btFilter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.tbShipName);
            this.Controls.Add(this.cbShipVia);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.cbEmployees);
            this.Controls.Add(this.cbCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployees;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.ComboBox cbShipVia;
        private System.Windows.Forms.TextBox tbShipName;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Label lbTotalPrice;
    }
}
