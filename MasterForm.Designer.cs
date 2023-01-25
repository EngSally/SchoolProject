namespace SchoolProject
{
    partial class MasterForm
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
            this.linkInstructor = new System.Windows.Forms.LinkLabel();
            this.linkDepartment = new System.Windows.Forms.LinkLabel();
            this.linkStudent = new System.Windows.Forms.LinkLabel();
            this.linkCourse = new System.Windows.Forms.LinkLabel();
            this.linkTopic = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // linkInstructor
            // 
            this.linkInstructor.AutoSize = true;
            this.linkInstructor.Location = new System.Drawing.Point(505, 19);
            this.linkInstructor.Name = "linkInstructor";
            this.linkInstructor.Size = new System.Drawing.Size(58, 15);
            this.linkInstructor.TabIndex = 0;
            this.linkInstructor.TabStop = true;
            this.linkInstructor.Text = "Instructor";
            // 
            // linkDepartment
            // 
            this.linkDepartment.AutoSize = true;
            this.linkDepartment.Location = new System.Drawing.Point(311, 19);
            this.linkDepartment.Name = "linkDepartment";
            this.linkDepartment.Size = new System.Drawing.Size(70, 15);
            this.linkDepartment.TabIndex = 1;
            this.linkDepartment.TabStop = true;
            this.linkDepartment.Text = "Department";
            // 
            // linkStudent
            // 
            this.linkStudent.AutoSize = true;
            this.linkStudent.Location = new System.Drawing.Point(700, 19);
            this.linkStudent.Name = "linkStudent";
            this.linkStudent.Size = new System.Drawing.Size(53, 15);
            this.linkStudent.TabIndex = 2;
            this.linkStudent.TabStop = true;
            this.linkStudent.Text = "Students";
            // 
            // linkCourse
            // 
            this.linkCourse.AutoSize = true;
            this.linkCourse.Location = new System.Drawing.Point(127, 19);
            this.linkCourse.Name = "linkCourse";
            this.linkCourse.Size = new System.Drawing.Size(44, 15);
            this.linkCourse.TabIndex = 3;
            this.linkCourse.TabStop = true;
            this.linkCourse.Text = "Course";
            // 
            // linkTopic
            // 
            this.linkTopic.AutoSize = true;
            this.linkTopic.Location = new System.Drawing.Point(12, 19);
            this.linkTopic.Name = "linkTopic";
            this.linkTopic.Size = new System.Drawing.Size(35, 15);
            this.linkTopic.TabIndex = 4;
            this.linkTopic.TabStop = true;
            this.linkTopic.Text = "Topic";
            this.linkTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTopic_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 370);
            this.panel1.TabIndex = 5;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.linkTopic);
            this.Controls.Add(this.linkCourse);
            this.Controls.Add(this.linkStudent);
            this.Controls.Add(this.linkDepartment);
            this.Controls.Add(this.linkInstructor);
            this.Name = "MasterForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LinkLabel linkInstructor;
        private LinkLabel linkDepartment;
        private LinkLabel linkStudent;
        private LinkLabel linkCourse;
        private LinkLabel linkTopic;
        private Panel panel1;
    }
}