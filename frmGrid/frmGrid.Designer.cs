
namespace frmGrid
{
    partial class frmGrid
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.clmNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMidTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.z = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtMidTerm = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblMidTerm = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            this.z.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmNumber,
            this.clnName,
            this.clmSurname,
            this.clmMidTerm,
            this.clmFinal,
            this.clmNote});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdList.Location = new System.Drawing.Point(12, 144);
            this.grdList.Name = "grdList";
            this.grdList.ReadOnly = true;
            this.grdList.RowHeadersWidth = 82;
            this.grdList.Size = new System.Drawing.Size(2203, 895);
            this.grdList.TabIndex = 0;
            // 
            // clmNumber
            // 
            this.clmNumber.HeaderText = "Number";
            this.clmNumber.MinimumWidth = 10;
            this.clmNumber.Name = "clmNumber";
            this.clmNumber.ReadOnly = true;
            this.clmNumber.Width = 200;
            // 
            // clnName
            // 
            this.clnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clnName.HeaderText = "Name";
            this.clnName.MinimumWidth = 10;
            this.clnName.Name = "clnName";
            this.clnName.ReadOnly = true;
            // 
            // clmSurname
            // 
            this.clmSurname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clmSurname.HeaderText = "Surname";
            this.clmSurname.MinimumWidth = 10;
            this.clmSurname.Name = "clmSurname";
            this.clmSurname.ReadOnly = true;
            // 
            // clmMidTerm
            // 
            this.clmMidTerm.HeaderText = "MidTerm";
            this.clmMidTerm.MinimumWidth = 10;
            this.clmMidTerm.Name = "clmMidTerm";
            this.clmMidTerm.ReadOnly = true;
            this.clmMidTerm.Width = 200;
            // 
            // clmFinal
            // 
            this.clmFinal.HeaderText = "Final";
            this.clmFinal.MinimumWidth = 10;
            this.clmFinal.Name = "clmFinal";
            this.clmFinal.ReadOnly = true;
            this.clmFinal.Width = 200;
            // 
            // clmNote
            // 
            this.clmNote.HeaderText = "Note";
            this.clmNote.MinimumWidth = 10;
            this.clmNote.Name = "clmNote";
            this.clmNote.ReadOnly = true;
            this.clmNote.Width = 200;
            // 
            // z
            // 
            this.z.Controls.Add(this.btnDelete);
            this.z.Controls.Add(this.btnQuery);
            this.z.Controls.Add(this.btnAdd);
            this.z.Controls.Add(this.txtFinal);
            this.z.Controls.Add(this.txtMidTerm);
            this.z.Controls.Add(this.txtSurname);
            this.z.Controls.Add(this.txtName);
            this.z.Controls.Add(this.txtNumber);
            this.z.Controls.Add(this.lblFinal);
            this.z.Controls.Add(this.lblMidTerm);
            this.z.Controls.Add(this.lblSurname);
            this.z.Controls.Add(this.lblName);
            this.z.Controls.Add(this.lblNumber);
            this.z.Location = new System.Drawing.Point(13, 2);
            this.z.Name = "z";
            this.z.Size = new System.Drawing.Size(2202, 124);
            this.z.TabIndex = 1;
            this.z.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1262, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 83);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(1114, 76);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(131, 31);
            this.txtFinal.TabIndex = 9;
            // 
            // txtMidTerm
            // 
            this.txtMidTerm.Location = new System.Drawing.Point(1114, 24);
            this.txtMidTerm.Name = "txtMidTerm";
            this.txtMidTerm.Size = new System.Drawing.Size(131, 31);
            this.txtMidTerm.TabIndex = 8;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(589, 70);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(229, 31);
            this.txtSurname.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 70);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 31);
            this.txtName.TabIndex = 6;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(195, 24);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(229, 31);
            this.txtNumber.TabIndex = 5;
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(987, 76);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(59, 25);
            this.lblFinal.TabIndex = 4;
            this.lblFinal.Text = "Final";
            // 
            // lblMidTerm
            // 
            this.lblMidTerm.AutoSize = true;
            this.lblMidTerm.Location = new System.Drawing.Point(987, 31);
            this.lblMidTerm.Name = "lblMidTerm";
            this.lblMidTerm.Size = new System.Drawing.Size(96, 25);
            this.lblMidTerm.TabIndex = 3;
            this.lblMidTerm.Text = "MidTerm";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(445, 73);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(98, 25);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(44, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(44, 31);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(87, 25);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(1540, 31);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(264, 70);
            this.btnQuery.TabIndex = 11;
            this.btnQuery.Text = "?";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1845, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(334, 78);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2227, 1069);
            this.Controls.Add(this.z);
            this.Controls.Add(this.grdList);
            this.Name = "frmGrid";
            this.Text = "Grid";
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            this.z.ResumeLayout(false);
            this.z.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSurname;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMidTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmFinal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNote;
        private System.Windows.Forms.GroupBox z;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtMidTerm;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblMidTerm;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnDelete;
    }
}

