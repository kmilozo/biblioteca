using biblioteca.Controllers;
using biblioteca.Models;
using Microsoft.VisualBasic.ApplicationServices;
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
using static System.Net.Mime.MediaTypeNames;

namespace biblioteca
{
    public partial class Books : Form
    {
        StateController myState = new StateController();
        BookController myBook = new BookController();
        public Books()
        {
            InitializeComponent();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            cmbState.DataSource = myState.getState();
            cmbState.DisplayMember = "estado";
            cmbState.ValueMember = "id_estado";
            FillGrid(dgvListBooks);
        }

        public void FillGrid(DataGridView dg)
        {
            dg.DataSource = myBook.getBooks();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string gender = txtGender.Text;
            int IdSelected = int.Parse(cmbState.SelectedValue.ToString());
            if (title != "" && author != "" && gender != "" && IdSelected != null)
            {
                BookModel newBook = new BookModel();
                newBook.title = title;
                newBook.author = author;
                newBook.gender = gender;
                newBook.id_state = IdSelected;
                myBook.insertBook(newBook);
                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvListBooks);
                txtGender.Clear();
                txtAuthor.Clear();
                txtTitle.Clear();
                lblCodigo.Text = "";
            }
            else
            {
                MessageBox.Show("Llene todos los campos para poder guardar el registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int idbook = int.Parse(dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[0].Value.ToString());
            int idstate = int.Parse(dgvListBooks.Rows[dgvListBooks.CurrentRow.Index].Cells[4].Value.ToString());
            if (idbook > 0 && idstate == 1)
            {
                myBook.deleteBook(idbook);
                MessageBox.Show("Registro eliminado con exito");
                FillGrid(dgvListBooks);
                txtGender.Clear();
                txtAuthor.Clear();
                txtTitle.Clear();
                lblCodigo.Text = "";
            }
            else
            {
                MessageBox.Show("El libro no se puede eliminar porque está en prestado o reservado.");
            }
        }


        private void dgvListBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text;
            string author = txtAuthor.Text;
            string gender = txtGender.Text;
            int IdState = int.Parse(cmbState.SelectedValue.ToString());
            int IdBook = int.Parse(lblCodigo.Text);

            if (title != "" && author != "" && gender != "" && IdState != null)
            {
                BookModel updateBook = new BookModel();
                updateBook.title = title;
                updateBook.author = author;
                updateBook.gender = gender;
                updateBook.id_state = IdState;
                updateBook.id_book = IdBook;
                myBook.updateBook(updateBook);
                MessageBox.Show("Registro actualizado exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvListBooks);
                txtGender.Clear();
                txtAuthor.Clear();
                txtTitle.Clear();
                lblCodigo.Text = "";

            }
            else
            {
                MessageBox.Show("Seleccione el registro y llene los registros que desea modificar el registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvListBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = dgvListBooks.SelectedCells[0].Value.ToString();
            txtTitle.Text = dgvListBooks.SelectedCells[1].Value.ToString();
            txtAuthor.Text = dgvListBooks.SelectedCells[2].Value.ToString();
            txtGender.Text = dgvListBooks.SelectedCells[3].Value.ToString();
            cmbState.SelectedValue = dgvListBooks.SelectedCells[4].Value.ToString();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
