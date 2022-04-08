namespace TheFirstWindowfromApp
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
            this.btAddNewButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btAddNewButton
            // 
            this.btAddNewButton.Location = new System.Drawing.Point(66, 37);
            this.btAddNewButton.Name = "btAddNewButton";
            this.btAddNewButton.Size = new System.Drawing.Size(156, 43);
            this.btAddNewButton.TabIndex = 0;
            this.btAddNewButton.Text = "Add New Button";
            this.btAddNewButton.UseVisualStyleBackColor = true;
            this.btAddNewButton.Click += new System.EventHandler(this.btAddNewButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(294, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Number of button: 0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btAddNewButton);
            this.Name = "Form1";
            this.Text = "Add Button Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAddNewButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
