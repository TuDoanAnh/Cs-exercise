namespace ProjectPRN
{
    partial class frmNewMove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbNumber = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbPhysic = new System.Windows.Forms.RadioButton();
            this.rbSpecial = new System.Windows.Forms.RadioButton();
            this.rbStatus = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nudPower = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPP = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPP)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumber
            // 
            this.lbNumber.AutoSize = true;
            this.lbNumber.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNumber.ForeColor = System.Drawing.Color.Gray;
            this.lbNumber.Location = new System.Drawing.Point(1, 71);
            this.lbNumber.Name = "lbNumber";
            this.lbNumber.Size = new System.Drawing.Size(145, 27);
            this.lbNumber.TabIndex = 1;
            this.lbNumber.Text = "MoveName";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(163, 71);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(262, 27);
            this.tbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "TypeName";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(163, 142);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(262, 28);
            this.cbType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(29, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "Category";
            // 
            // rbPhysic
            // 
            this.rbPhysic.AutoSize = true;
            this.rbPhysic.Location = new System.Drawing.Point(163, 204);
            this.rbPhysic.Name = "rbPhysic";
            this.rbPhysic.Size = new System.Drawing.Size(82, 24);
            this.rbPhysic.TabIndex = 6;
            this.rbPhysic.TabStop = true;
            this.rbPhysic.Text = "Physical";
            this.rbPhysic.UseVisualStyleBackColor = true;
            // 
            // rbSpecial
            // 
            this.rbSpecial.AutoSize = true;
            this.rbSpecial.Location = new System.Drawing.Point(286, 204);
            this.rbSpecial.Name = "rbSpecial";
            this.rbSpecial.Size = new System.Drawing.Size(78, 24);
            this.rbSpecial.TabIndex = 7;
            this.rbSpecial.TabStop = true;
            this.rbSpecial.Text = "Special";
            this.rbSpecial.UseVisualStyleBackColor = true;
            // 
            // rbStatus
            // 
            this.rbStatus.AutoSize = true;
            this.rbStatus.Location = new System.Drawing.Point(409, 203);
            this.rbStatus.Name = "rbStatus";
            this.rbStatus.Size = new System.Drawing.Size(70, 24);
            this.rbStatus.TabIndex = 8;
            this.rbStatus.TabStop = true;
            this.rbStatus.Text = "Status";
            this.rbStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(66, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Power";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nudPower
            // 
            this.nudPower.Location = new System.Drawing.Point(163, 260);
            this.nudPower.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nudPower.Name = "nudPower";
            this.nudPower.Size = new System.Drawing.Size(262, 27);
            this.nudPower.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(5, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "Power Point";
            // 
            // nudPP
            // 
            this.nudPP.Location = new System.Drawing.Point(163, 316);
            this.nudPP.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPP.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPP.Name = "nudPP";
            this.nudPP.Size = new System.Drawing.Size(262, 27);
            this.nudPP.TabIndex = 13;
            this.nudPP.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(194, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add Move";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmNewMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudPP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudPower);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbStatus);
            this.Controls.Add(this.rbSpecial);
            this.Controls.Add(this.rbPhysic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbNumber);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNewMove";
            this.Text = "frmNewMove";
            this.Load += new System.EventHandler(this.frmNewMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumber;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbPhysic;
        private System.Windows.Forms.RadioButton rbSpecial;
        private System.Windows.Forms.RadioButton rbStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown nudPower;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPP;
        private System.Windows.Forms.Button button1;
    }
}