
namespace Calculator
{
    partial class frmExamNotes
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblFirstExam = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblStudentNameSurName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbSuccess = new System.Windows.Forms.ListBox();
            this.lbFail = new System.Windows.Forms.ListBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtFinal);
            this.groupBox1.Controls.Add(this.txtMidTerm);
            this.groupBox1.Controls.Add(this.txtNumber);
            this.groupBox1.Controls.Add(this.txtNameSurname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblFirstExam);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Controls.Add(this.lblStudentNameSurName);
            this.groupBox1.Location = new System.Drawing.Point(47, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 758);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Final Exam";
            // 
            // lblFirstExam
            // 
            this.lblFirstExam.AutoSize = true;
            this.lblFirstExam.Location = new System.Drawing.Point(18, 220);
            this.lblFirstExam.Name = "lblFirstExam";
            this.lblFirstExam.Size = new System.Drawing.Size(96, 25);
            this.lblFirstExam.TabIndex = 2;
            this.lblFirstExam.Text = "MidTerm";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(18, 144);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(87, 25);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // lblStudentNameSurName
            // 
            this.lblStudentNameSurName.AutoSize = true;
            this.lblStudentNameSurName.Location = new System.Drawing.Point(18, 67);
            this.lblStudentNameSurName.Name = "lblStudentNameSurName";
            this.lblStudentNameSurName.Size = new System.Drawing.Size(160, 25);
            this.lblStudentNameSurName.TabIndex = 0;
            this.lblStudentNameSurName.Text = "Name Surname";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblInfo);
            this.groupBox2.Controls.Add(this.lbSuccess);
            this.groupBox2.Controls.Add(this.lbFail);
            this.groupBox2.Location = new System.Drawing.Point(569, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1032, 758);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exam Results";
            // 
            // lbSuccess
            // 
            this.lbSuccess.FormattingEnabled = true;
            this.lbSuccess.ItemHeight = 25;
            this.lbSuccess.Location = new System.Drawing.Point(520, 46);
            this.lbSuccess.Name = "lbSuccess";
            this.lbSuccess.Size = new System.Drawing.Size(490, 679);
            this.lbSuccess.TabIndex = 1;
            // 
            // lbFail
            // 
            this.lbFail.FormattingEnabled = true;
            this.lbFail.ItemHeight = 25;
            this.lbFail.Location = new System.Drawing.Point(23, 46);
            this.lbFail.Name = "lbFail";
            this.lbFail.Size = new System.Drawing.Size(490, 679);
            this.lbFail.TabIndex = 0;
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(231, 67);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(236, 31);
            this.txtNameSurname.TabIndex = 4;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(231, 144);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(236, 31);
            this.txtNumber.TabIndex = 5;
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(231, 220);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(100, 31);
            this.txtMidTerm.TabIndex = 6;
            this.txtMidTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMidTerm.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(231, 288);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 31);
            this.txtFinal.TabIndex = 7;
            this.txtFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(444, 57);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(23, 732);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 2;
            // 
            // frmExamNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1666, 923);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExamNotes";
            this.Text = "frmExamNotes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirstExam;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblStudentNameSurName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbSuccess;
        private System.Windows.Forms.ListBox lbFail;
        private System.Windows.Forms.TextBox txtMidTerm;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblInfo;
    }
}