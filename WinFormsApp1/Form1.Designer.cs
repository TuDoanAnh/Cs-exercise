namespace WinFormsApp1
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
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.cbInstructor = new System.Windows.Forms.ComboBox();
            this.lbSelectSubject = new System.Windows.Forms.Label();
            this.lbSelectInstructor = new System.Windows.Forms.Label();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.lbCourseCode = new System.Windows.Forms.Label();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.lbCourseDes = new System.Windows.Forms.Label();
            this.lsAllStudent = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.nudTermId = new System.Windows.Forms.NumericUpDown();
            this.tbCampusId = new System.Windows.Forms.TextBox();
            this.lsSelectedStudent = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudTermId)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(131, 42);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(200, 28);
            this.cbSubject.TabIndex = 0;
            // 
            // cbInstructor
            // 
            this.cbInstructor.FormattingEnabled = true;
            this.cbInstructor.Location = new System.Drawing.Point(131, 94);
            this.cbInstructor.Name = "cbInstructor";
            this.cbInstructor.Size = new System.Drawing.Size(200, 28);
            this.cbInstructor.TabIndex = 1;
            // 
            // lbSelectSubject
            // 
            this.lbSelectSubject.AutoSize = true;
            this.lbSelectSubject.Location = new System.Drawing.Point(34, 40);
            this.lbSelectSubject.Name = "lbSelectSubject";
            this.lbSelectSubject.Size = new System.Drawing.Size(58, 20);
            this.lbSelectSubject.TabIndex = 3;
            this.lbSelectSubject.Text = "Subject";
            // 
            // lbSelectInstructor
            // 
            this.lbSelectInstructor.AutoSize = true;
            this.lbSelectInstructor.Location = new System.Drawing.Point(34, 102);
            this.lbSelectInstructor.Name = "lbSelectInstructor";
            this.lbSelectInstructor.Size = new System.Drawing.Size(71, 20);
            this.lbSelectInstructor.TabIndex = 4;
            this.lbSelectInstructor.Text = "Instructor";
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(131, 150);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(200, 27);
            this.tbCourseCode.TabIndex = 5;
            // 
            // lbCourseCode
            // 
            this.lbCourseCode.AutoSize = true;
            this.lbCourseCode.Location = new System.Drawing.Point(32, 157);
            this.lbCourseCode.Name = "lbCourseCode";
            this.lbCourseCode.Size = new System.Drawing.Size(93, 20);
            this.lbCourseCode.TabIndex = 6;
            this.lbCourseCode.Text = "Course Code";
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(131, 207);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(200, 197);
            this.tbDescription.TabIndex = 7;
            // 
            // lbCourseDes
            // 
            this.lbCourseDes.AutoSize = true;
            this.lbCourseDes.Location = new System.Drawing.Point(-9, 207);
            this.lbCourseDes.Name = "lbCourseDes";
            this.lbCourseDes.Size = new System.Drawing.Size(134, 20);
            this.lbCourseDes.TabIndex = 8;
            this.lbCourseDes.Text = "Course Description";
            // 
            // lsAllStudent
            // 
            this.lsAllStudent.FormattingEnabled = true;
            this.lsAllStudent.ItemHeight = 20;
            this.lsAllStudent.Location = new System.Drawing.Point(408, 12);
            this.lsAllStudent.Name = "lsAllStudent";
            this.lsAllStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsAllStudent.Size = new System.Drawing.Size(225, 304);
            this.lsAllStudent.TabIndex = 9;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(669, 461);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(180, 29);
            this.btAdd.TabIndex = 10;
            this.btAdd.Text = "Add New Course";
            this.btAdd.UseVisualStyleBackColor = true;
            // 
            // nudTermId
            // 
            this.nudTermId.Location = new System.Drawing.Point(131, 420);
            this.nudTermId.Name = "nudTermId";
            this.nudTermId.Size = new System.Drawing.Size(200, 27);
            this.nudTermId.TabIndex = 11;
            // 
            // tbCampusId
            // 
            this.tbCampusId.Location = new System.Drawing.Point(135, 473);
            this.tbCampusId.Name = "tbCampusId";
            this.tbCampusId.Size = new System.Drawing.Size(196, 27);
            this.tbCampusId.TabIndex = 12;
            // 
            // lsSelectedStudent
            // 
            this.lsSelectedStudent.FormattingEnabled = true;
            this.lsSelectedStudent.ItemHeight = 20;
            this.lsSelectedStudent.Location = new System.Drawing.Point(717, 12);
            this.lsSelectedStudent.Name = "lsSelectedStudent";
            this.lsSelectedStudent.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lsSelectedStudent.Size = new System.Drawing.Size(206, 304);
            this.lsSelectedStudent.TabIndex = 13;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(660, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(29, 20);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = ">>";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(660, 123);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(29, 20);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "<<";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 542);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lsSelectedStudent);
            this.Controls.Add(this.tbCampusId);
            this.Controls.Add(this.nudTermId);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.lsAllStudent);
            this.Controls.Add(this.lbCourseDes);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.lbCourseCode);
            this.Controls.Add(this.tbCourseCode);
            this.Controls.Add(this.lbSelectInstructor);
            this.Controls.Add(this.lbSelectSubject);
            this.Controls.Add(this.cbInstructor);
            this.Controls.Add(this.cbSubject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTermId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.ComboBox cbInstructor;
        private System.Windows.Forms.Label lbSelectSubject;
        private System.Windows.Forms.Label lbSelectInstructor;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.Label lbCourseCode;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label lbCourseDes;
        private System.Windows.Forms.ListBox lsAllStudent;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.NumericUpDown nudTermId;
        private System.Windows.Forms.TextBox tbCampusId;
        private System.Windows.Forms.ListBox lsSelectedStudent;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}
