namespace Team_project_3
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
            this.addStudentButton = new System.Windows.Forms.Button();
            this.displayStudentsButton = new System.Windows.Forms.Button();
            this.enrolledStudentInACoursebutton = new System.Windows.Forms.Button();
            this.whatCoursesStudentEnrolledInbutton = new System.Windows.Forms.Button();
            this.displayCoursesButton = new System.Windows.Forms.Button();
            this.whoIsInCoursebutton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(59, 88);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(129, 63);
            this.addStudentButton.TabIndex = 0;
            this.addStudentButton.Text = "Add a Student";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // displayStudentsButton
            // 
            this.displayStudentsButton.Location = new System.Drawing.Point(59, 173);
            this.displayStudentsButton.Name = "displayStudentsButton";
            this.displayStudentsButton.Size = new System.Drawing.Size(129, 61);
            this.displayStudentsButton.TabIndex = 1;
            this.displayStudentsButton.Text = "Display All Students";
            this.displayStudentsButton.UseVisualStyleBackColor = true;
            // 
            // enrolledStudentInACoursebutton
            // 
            this.enrolledStudentInACoursebutton.Location = new System.Drawing.Point(59, 260);
            this.enrolledStudentInACoursebutton.Name = "enrolledStudentInACoursebutton";
            this.enrolledStudentInACoursebutton.Size = new System.Drawing.Size(129, 68);
            this.enrolledStudentInACoursebutton.TabIndex = 2;
            this.enrolledStudentInACoursebutton.Text = "Enrolled a Student In a Course";
            this.enrolledStudentInACoursebutton.UseVisualStyleBackColor = true;
            // 
            // whatCoursesStudentEnrolledInbutton
            // 
            this.whatCoursesStudentEnrolledInbutton.Location = new System.Drawing.Point(59, 363);
            this.whatCoursesStudentEnrolledInbutton.Name = "whatCoursesStudentEnrolledInbutton";
            this.whatCoursesStudentEnrolledInbutton.Size = new System.Drawing.Size(129, 75);
            this.whatCoursesStudentEnrolledInbutton.TabIndex = 3;
            this.whatCoursesStudentEnrolledInbutton.Text = "What Courses a Student Enrolled In";
            this.whatCoursesStudentEnrolledInbutton.UseVisualStyleBackColor = true;
            // 
            // displayCoursesButton
            // 
            this.displayCoursesButton.Location = new System.Drawing.Point(532, 173);
            this.displayCoursesButton.Name = "displayCoursesButton";
            this.displayCoursesButton.Size = new System.Drawing.Size(140, 54);
            this.displayCoursesButton.TabIndex = 4;
            this.displayCoursesButton.Text = "Display All Courses";
            this.displayCoursesButton.UseVisualStyleBackColor = true;
            // 
            // whoIsInCoursebutton
            // 
            this.whoIsInCoursebutton.Location = new System.Drawing.Point(532, 260);
            this.whoIsInCoursebutton.Name = "whoIsInCoursebutton";
            this.whoIsInCoursebutton.Size = new System.Drawing.Size(140, 68);
            this.whoIsInCoursebutton.TabIndex = 5;
            this.whoIsInCoursebutton.Text = "Who Is In a Course";
            this.whoIsInCoursebutton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(532, 363);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 66);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(532, 88);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(140, 63);
            this.addCourseButton.TabIndex = 7;
            this.addCourseButton.Text = "Add a Course";
            this.addCourseButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(585, 36);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tiny College Course Tracking System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCourseButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.whoIsInCoursebutton);
            this.Controls.Add(this.displayCoursesButton);
            this.Controls.Add(this.whatCoursesStudentEnrolledInbutton);
            this.Controls.Add(this.enrolledStudentInACoursebutton);
            this.Controls.Add(this.displayStudentsButton);
            this.Controls.Add(this.addStudentButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button addStudentButton;
        private Button displayStudentsButton;
        private Button enrolledStudentInACoursebutton;
        private Button whatCoursesStudentEnrolledInbutton;
        private Button displayCoursesButton;
        private Button whoIsInCoursebutton;
        private Button exitButton;
        private Button addCourseButton;
        private Label label1;
    }
}