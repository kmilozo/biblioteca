using biblioteca.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class SeeForGender : Form
    {
        BookController myBook = new BookController();
        public SeeForGender()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }
        public void FillGrid(DataGridView dg)
        {
            string Gender = txtGender.Text;

            if (txtGender.Text != "")
            {
                dg.DataSource = myBook.getBookForGender(Gender);
            }
            else
            {
                MessageBox.Show("Atencion, Ingrese un autor para realizar la consulta");
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid(dgvReportGender);
        }
    }
}
