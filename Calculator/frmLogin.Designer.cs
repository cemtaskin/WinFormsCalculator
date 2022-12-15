
namespace Calculator
{
    partial class frmLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbRemeberMe = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lbCourses = new System.Windows.Forms.ListBox();
            this.llOkanUniversity = new System.Windows.Forms.LinkLabel();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.btnAddCouse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRemeberMe);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Form";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(28, 56);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 25);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(28, 110);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(106, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(176, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(300, 31);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(176, 104);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(300, 31);
            this.txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(176, 208);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 38);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRemeberMe
            // 
            this.cbRemeberMe.AutoSize = true;
            this.cbRemeberMe.Location = new System.Drawing.Point(176, 164);
            this.cbRemeberMe.Name = "cbRemeberMe";
            this.cbRemeberMe.Size = new System.Drawing.Size(184, 29);
            this.cbRemeberMe.TabIndex = 5;
            this.cbRemeberMe.Text = "Remember Me";
            this.cbRemeberMe.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteCourse);
            this.groupBox2.Controls.Add(this.btnAddCouse);
            this.groupBox2.Controls.Add(this.txtCourseName);
            this.groupBox2.Controls.Add(this.lblCourseName);
            this.groupBox2.Controls.Add(this.llOkanUniversity);
            this.groupBox2.Controls.Add(this.lbCourses);
            this.groupBox2.Controls.Add(this.lblBirthDate);
            this.groupBox2.Controls.Add(this.dpBirthDate);
            this.groupBox2.Location = new System.Drawing.Point(594, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1170, 881);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dpBirthDate
            // 
            this.dpBirthDate.CustomFormat = "dd/MM/yyyy";
            this.dpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpBirthDate.Location = new System.Drawing.Point(194, 38);
            this.dpBirthDate.Name = "dpBirthDate";
            this.dpBirthDate.Size = new System.Drawing.Size(300, 31);
            this.dpBirthDate.TabIndex = 0;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(32, 40);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(107, 25);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "Birth Date";
            // 
            // lbCourses
            // 
            this.lbCourses.FormattingEnabled = true;
            this.lbCourses.ItemHeight = 25;
            this.lbCourses.Location = new System.Drawing.Point(37, 168);
            this.lbCourses.Name = "lbCourses";
            this.lbCourses.Size = new System.Drawing.Size(468, 479);
            this.lbCourses.TabIndex = 2;
            // 
            // llOkanUniversity
            // 
            this.llOkanUniversity.AutoSize = true;
            this.llOkanUniversity.Location = new System.Drawing.Point(641, 39);
            this.llOkanUniversity.Name = "llOkanUniversity";
            this.llOkanUniversity.Size = new System.Drawing.Size(164, 25);
            this.llOkanUniversity.TabIndex = 3;
            this.llOkanUniversity.TabStop = true;
            this.llOkanUniversity.Text = "Okan University";
            this.llOkanUniversity.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOkanUniversity_LinkClicked);
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(180, 131);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(270, 31);
            this.txtCourseName.TabIndex = 5;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(32, 131);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(143, 25);
            this.lblCourseName.TabIndex = 4;
            this.lblCourseName.Text = "Course Name";
            // 
            // btnAddCouse
            // 
            this.btnAddCouse.Location = new System.Drawing.Point(456, 128);
            this.btnAddCouse.Name = "btnAddCouse";
            this.btnAddCouse.Size = new System.Drawing.Size(49, 34);
            this.btnAddCouse.TabIndex = 6;
            this.btnAddCouse.Text = "+";
            this.btnAddCouse.UseVisualStyleBackColor = true;
            this.btnAddCouse.Click += new System.EventHandler(this.btnAddCouse_Click);
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(48, 664);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(457, 59);
            this.btnDeleteCourse.TabIndex = 7;
            this.btnDeleteCourse.Text = "Delete Selected Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            this.btnDeleteCourse.Click += new System.EventHandler(this.btnDeleteCourse_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 921);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.Text = "Erp Program";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbRemeberMe;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dpBirthDate;
        private System.Windows.Forms.LinkLabel llOkanUniversity;
        private System.Windows.Forms.ListBox lbCourses;
        private System.Windows.Forms.Button btnAddCouse;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Button btnDeleteCourse;
    }
}