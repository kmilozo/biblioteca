using biblioteca.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace biblioteca.Controllers
{
    public class BookController
    {
        ConnectionController objCon = new ConnectionController();
        public void insertBook(BookModel newbook)
        {

            string query = $"INSERT INTO libro(titulo, autor, genero, id_estado) VALUES('{newbook.title}','{newbook.author}','{newbook.gender}', {newbook.id_state})";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (MySqlException)
            {
                throw;
            }

        }

        public DataTable getBooks()
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM libro";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }

        public DataTable getBooksAvailables()
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM libro where id_estado= 1";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }

        public DataTable getActualStateBooks()
        {
            DataTable tBook = new DataTable();
            string query = $"select * from libro l CROSS JOIN estado_libro e ON l.id_estado=e.id_estado";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }

        public DataTable getMoreBorrowingBooks()
        {
            DataTable tBook = new DataTable();
            string query = $"select * from libro l INNER JOIN (SELECT id_libro, id_lector, fecha_prestamo FROM prestamo GROUP BY id_libro HAVING COUNT(*)>=1) p ON l.id_libro=p.id_libro";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }

        public DataTable getBookForAuthor(string name)
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM `libro` WHERE autor like '%{name}%'";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }

        public DataTable getBookForGender(string name)
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM `libro` WHERE genero like '%{name}%'";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }
        public DataTable getBookForTitle(string name)
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM `libro` WHERE titulo like '%{name}%'";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(tBook);
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return tBook;

        }


        public void deleteBook(int idBook)
        {
            string query = $"DELETE from libro WHERE id_libro ="+idBook;
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (MySqlException)
            {
                throw;
            }  
        }

        

        public void updateBook(BookModel book)
        {

            string query = $"UPDATE libro SET titulo='{book.title}',autor='{book.author}',genero='{book.gender}'" +
                $",id_estado='{book.id_state}' WHERE id_libro='{book.id_book}'";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }

        public void updateBookState(BookModel book)
        {

            string query = $"UPDATE libro SET id_estado='{book.id_state}' WHERE id_libro='{book.id_book}'";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (MySqlException)
            {
                throw;
            }
        }
    }
}
