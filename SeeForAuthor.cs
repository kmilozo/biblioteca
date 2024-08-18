using biblioteca.Controllers;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace biblioteca
{
    public partial class SeeForAuthor : Form
    {
        BookController myBook = new BookController();
        public SeeForAuthor()
        {
            InitializeComponent();
        }
        public void FillGrid(DataGridView dg)
        {
            string Author = txtAutor.Text;

            if (txtAutor.Text != "")
            {
                dg.DataSource = myBook.getBookForAuthor(Author);
            }
            else
            {
                MessageBox.Show("Atencion, Ingrese un autor para realizar la consulta");
            }
        }
        private void SeeForAuthor_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FillGrid(dgvReportAuthor);

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
            this.Hide();
        }
    }
}
