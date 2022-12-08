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
    public partial class frmCalculator : Form
    {
        public int FirstNumber 
        { 
            get {
                return Convert.ToInt32(txtFirstNumber.Text);    
            } 
        }
        public int SecondNumber
        {
            get
            {
                return Convert.ToInt32(txtSecondNumber.Text);
            }
        }

        public double Result { 
            set 
            {
                txtResult.Text = value.ToString();
            } 
        }

        public frmCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Result = FirstNumber + SecondNumber;
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {

           Result = FirstNumber - SecondNumber;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            Result = FirstNumber * SecondNumber;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Result = (double)FirstNumber / (double)SecondNumber;
        }
    }
}
