using frmGrid.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGrid
{
    public partial class frmGrid : Form
    {
        List<ExamNote> examNotes = new List<ExamNote>();
        public frmGrid()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var examNote = new ExamNote()
            {
                Number = txtNumber.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                MidTerm = Convert.ToDouble(txtMidTerm.Text),
                Final = Convert.ToDouble(txtFinal.Text)
            };

            examNotes.Add(examNote);

            fillGrid();
        }

        private void fillGrid()
        {
            grdList.Rows.Clear();
            foreach(var exam in examNotes)
            {
                grdList.Rows.Add(new object[] { exam.Number,exam.Name,exam.Surname,exam.MidTerm,exam.Final,exam.Note});
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            int rowCount = grdList.Rows.Count;
            int colCount = grdList.Columns.Count;

            MessageBox.Show($"Grid has {rowCount} rows and  {colCount} columns");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            examNotes.RemoveAt(grdList.CurrentRow.Index);
            fillGrid();
        }
    }
}
