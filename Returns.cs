using biblioteca.Controllers;
using biblioteca.Models;
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
    public partial class Returns : Form
    {
        BorrowingController myBorrowing = new BorrowingController();
        ReturnController myReturn = new ReturnController();
        BookController myBook = new BookController();
        public Returns()
        {
            InitializeComponent();

        }
        
        public void FillGrid(DataGridView dg)
        {
            dg.DataSource = myBorrowing.getBorrowings();

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idReader = int.Parse(txtIdReader.Text);
            int idBook = int.Parse(txtIdBook.Text);
            int codigo = int.Parse(lblCodigo.Text);
            string dateReturn = dtReturn.Value.ToString("yyyy-MM-dd");

            ReturnModel returnmodel = new ReturnModel();
            returnmodel.id_book = idBook;
            returnmodel.id_reader = idReader;
            myReturn.InsertReturn(returnmodel);
           
            BookModel updBook = new BookModel();
            updBook.id_state = 1;
            updBook.id_book = idBook;
            myBook.updateBookState(updBook);

            BorrowingModel borrowing = new BorrowingModel();
            borrowing.id_borrowing = codigo;
            myBorrowing.DeleteBorrowing(codigo);



            MessageBox.Show("Devolucion registrada con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FillGrid(dgvBorrowings);
            txtIdBook.Clear();
            lblCodigo.Text = "";
            txtIdReader.Clear();

        }

        private void Returns_Load(object sender, EventArgs e)
        {
            FillGrid(dgvBorrowings);
            //MessageBox.Show("Devolucion registrada con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvBorrowings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text= dgvBorrowings.SelectedCells[4].Value.ToString();
            txtIdReader.Text = dgvBorrowings.SelectedCells[0].Value.ToString();
            txtIdBook.Text = dgvBorrowings.SelectedCells[5].Value.ToString();
            
        }
    }
}
