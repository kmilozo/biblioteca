using biblioteca.Controllers;
using MySql.Data.MySqlClient;
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
    public partial class Reports : Form
    {
        BookController myBook = new BookController();
        BorrowingController myBorrowing = new BorrowingController();
        public Reports()
        {
            InitializeComponent();
        }
        private void Reports_Load(object sender, EventArgs e)
        {
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }
        public void FillActualState(DataGridView dg)
        {
            dg.DataSource = myBook.getActualStateBooks();
        }
        private void btnActualState_Click(object sender, EventArgs e)
        {
            FillActualState(dgvReports);
        }
        public void FillMoreBorrowingBooks(DataGridView dg)
        {
            
            dg.DataSource = myBook.getMoreBorrowingBooks();

        }
        public void FillExpirateBooks(DataGridView dg)
        {
            DateTime actualdate = DateTime.Now;
            string Today= actualdate.ToString("yyyy/MM/dd");
            dg.DataSource = myBorrowing.getBorrowingsExpirates(Today);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FillMoreBorrowingBooks(dgvReports);
        }

        private void btnExpirateBooks_Click(object sender, EventArgs e)
        {///libros vencidos
            FillExpirateBooks(dgvReports);
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
        }

        private void btnGender_Click(object sender, EventArgs e)
        {

            SeeForTitle Title = new SeeForTitle();
            Title.Show();
            this.Hide();
        }

        private void cmbFill_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnAuthor_Click_1(object sender, EventArgs e)
        {
            SeeForAuthor Author = new SeeForAuthor();
            Author.Show();
            this.Hide();
        }

        private void btnGender_Click_1(object sender, EventArgs e)
        {
            SeeForGender Gender = new SeeForGender();
            Gender.Show();
            this.Hide();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
