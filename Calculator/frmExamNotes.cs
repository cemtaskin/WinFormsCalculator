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
    public partial class frmExamNotes : Form
    {
        public frmExamNotes()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int midTerm = Convert.ToInt32(txtMidTerm.Text);
            int final = Convert.ToInt32(txtFinal.Text);

            double note = midTerm * 0.3 + final * 0.7;

            if (note > 60)
            {
                lbSuccess.Items.Add($"{txtNameSurname.Text}-{txtNumber.Text}-{note}");
            }
            else
            {
                lbFail.Items.Add($"{txtNameSurname.Text}-{txtNumber.Text}-{note}");
            }
            lblInfo.Text = $"Failed : {lbFail.Items.Count} - Success : {lbSuccess.Items.Count}";
        }
    }
}
