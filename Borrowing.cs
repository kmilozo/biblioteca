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
    public partial class Borrowing : Form
    {
        ReaderController myReader = new ReaderController();
        BookController myBook = new BookController();
        BorrowingController myBorrowing= new BorrowingController();
        BorrowingHistoryController myhBorrowing = new BorrowingHistoryController();
        public Borrowing()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            int IdReader = int.Parse(cmbReader.SelectedValue.ToString());
            int IdBook = int.Parse(cmbBook.SelectedValue.ToString());
            string dateborrowing = dtBorrowing.Value.ToString("yyyy-MM-dd");
            string dateExpiration = dtExpire.Value.ToString("yyyy-MM-dd");
            
            BorrowingModel newborrowing = new BorrowingModel();
            newborrowing.id_book = IdBook;
            newborrowing.id_reader = IdReader;
            newborrowing.borrowing_date = dateborrowing;
            newborrowing.expiration_date =dateExpiration;
            myBorrowing.insertBorrowing(newborrowing);

            BorrowingHistoryModel newhborrowing = new BorrowingHistoryModel();
            newhborrowing.id_book = IdBook;
            newhborrowing.id_reader = IdReader;
            newhborrowing.borrowing_date = dateborrowing;
            newhborrowing.expiration_date = dateExpiration;
            myhBorrowing.insertBorrowingHistory(newhborrowing);


            BookModel updBook = new BookModel();
            updBook.id_state = 2;
            updBook.id_book = IdBook;
            myBook.updateBookState(updBook);
            MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void Borrowing_Load(object sender, EventArgs e)
        {
            cmbBook.DataSource = myBook.getBooksAvailables();
            cmbBook.DisplayMember = "titulo";
            cmbBook.ValueMember = "id_libro";

            cmbReader.DataSource = myReader.getReaders();
            cmbReader.DisplayMember = "nombre_lector";
            cmbReader.ValueMember = "id_lector";
        }
    }
}
