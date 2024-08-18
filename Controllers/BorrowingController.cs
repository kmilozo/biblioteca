using biblioteca.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Controllers
{
    public class BorrowingController
    {
        ConnectionController objCon = new ConnectionController();
        public void insertBorrowing(BorrowingModel newborrowing)
        {
            string query = $"INSERT INTO prestamo(id_libro, id_lector, fecha_prestamo, fecha_vencimiento) VALUES('{newborrowing.id_book}','{newborrowing.id_reader}','{newborrowing.borrowing_date}', '{newborrowing.expiration_date}')";
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

        public DataTable getBorrowings()
        {
            DataTable tBook = new DataTable();
            string query = $"select * from lector l INNER JOIN (SELECT * FROM prestamo)e ON l.id_lector=e.id_lector INNER JOIN (SELECT * from libro) li On li.id_libro=e.id_libro";
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

       
        public DataTable getBorrowingsExpirates(string date)
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM prestamo WHERE fecha_vencimiento < '{date}'";
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

        public void DeleteBorrowing(int idBook)
        {
            string query = $"DELETE from prestamo WHERE id_prestamo =" + idBook;
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
