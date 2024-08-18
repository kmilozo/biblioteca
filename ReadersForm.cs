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
    public partial class ReadersForm : Form
    {   
        ReaderController myReader = new ReaderController();
        public ReadersForm()
        {
            InitializeComponent();
            FillGrid(dgvListReaders);
        }
        
        public void FillGrid(DataGridView dg)
        {
            dg.DataSource = myReader.getReaders();
        }
        private void btnOut_Click(object sender, EventArgs e)
        {
            Home Out = new Home();
            Out.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Id = txtIdNumber.Text;
            string Phone = txtPhone.Text;
            if (Name != "" && Id != "" && Phone != "")
            {
                ReaderModel newreader = new ReaderModel();
                newreader.name= Name;
                newreader.id_number= Id;
                newreader.phone= Phone;
                myReader.InsertReader(newreader);
                MessageBox.Show("Registro añadido exitosamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvListReaders);
                txtName.Clear();
                txtIdNumber.Clear();
                txtPhone.Clear();
                lblCodigo.Text = "";
            }
            else
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text;
            string Id = txtIdNumber.Text;
            string Phone = txtPhone.Text;
            int IdReader = int.Parse(lblCodigo.Text);
            if (Name != "" && Id != "" && Phone != "")
            {
                ReaderModel updreader = new ReaderModel();
                updreader.name = Name;
                updreader.id_number = Id;
                updreader.phone = Phone;
                updreader.id_reader = IdReader;
                myReader.UpdateReader(updreader);
                MessageBox.Show("Registro actualizado con exito", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FillGrid(dgvListReaders);
                txtName.Clear();
                txtIdNumber.Clear();
                txtPhone.Clear();
                lblCodigo.Text = "";
            }
            else
            {
                MessageBox.Show("Es necesario llenar todos los campos");
            }
        }
        
        private void btnSelect_Click(object sender, EventArgs e)
        {
           
        }

        private void ReadersForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvListReaders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCodigo.Text = dgvListReaders.SelectedCells[0].Value.ToString();
            txtName.Text = dgvListReaders.SelectedCells[1].Value.ToString();
            txtIdNumber.Text = dgvListReaders.SelectedCells[2].Value.ToString();
            txtPhone.Text = dgvListReaders.SelectedCells[3].Value.ToString();
            
        }
    }
}
