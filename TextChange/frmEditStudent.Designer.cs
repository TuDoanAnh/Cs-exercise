
namespace TextChange
{
    partial class frmEditStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btEdit = new System.Windows.Forms.Button();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbRollNumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "MidName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "FirstName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "RollNumber";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(155, 301);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(192, 23);
            this.btEdit.TabIndex = 5;
            this.btEdit.Text = "EditStudent";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(155, 80);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(192, 23);
            this.tbId.TabIndex = 6;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(155, 251);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(192, 23);
            this.tbLastName.TabIndex = 7;
            // 
            // tbMidName
            // 
            this.tbMidName.Location = new System.Drawing.Point(155, 206);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(192, 23);
            this.tbMidName.TabIndex = 8;
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(155, 160);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(192, 23);
            this.tbFirstName.TabIndex = 9;
            // 
            // tbRollNumber
            // 
            this.tbRollNumber.Location = new System.Drawing.Point(155, 119);
            this.tbRollNumber.Name = "tbRollNumber";
            this.tbRollNumber.Size = new System.Drawing.Size(192, 23);
            this.tbRollNumber.TabIndex = 10;
            // 
            // frmEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.tbRollNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.tbMidName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmEditStudent";
            this.Text = "frmEditStudent";
            this.Load += new System.EventHandler(this.frmEditStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbMidName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbRollNumber;
    }
}