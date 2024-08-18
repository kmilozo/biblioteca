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
    public partial class SeeForTitle : Form
    {
        BookController myBook = new BookController();
        public SeeForTitle()
        {
            InitializeComponent();
        }
        public void FillGrid(DataGridView dg)
        {
            string title = txtTitle.Text;

            if (txtTitle.Text != "")
            {
                dg.DataSource = myBook.getBookForTitle(title);
            }
            else
            {
                MessageBox.Show("Atencion, Ingrese un autor para realizar la consulta");
            }
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }

        private void SeeForTitle_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid(dgvReportTitle);
        }
    }
}
