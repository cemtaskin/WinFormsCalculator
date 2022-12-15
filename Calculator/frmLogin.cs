using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cbRemeberMe.Checked)
            {
                //if remember checkBox is checked, this code block will run
                MessageBox.Show(dpBirthDate.Value.ToString("dd/MM/yyyy"));

            }
            else
            {
                MessageBox.Show("Remember Me is unchecked");
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void llOkanUniversity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.okan.edu.tr");
        }

        private void btnAddCouse_Click(object sender, EventArgs e)
        {
            lbCourses.Items.Add(txtCourseName.Text);
            txtCourseName.ResetText();
            txtCourseName.Focus();
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"The number courses in listbox is : {lbCourses.Items.Count}");
            if (lbCourses.SelectedItems.Count > 0)
            {
                lbCourses.Items.Remove(lbCourses.SelectedItems[0]);
            }
           
        }
    }
}
