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
    public class BorrowingHistoryController
    {
        ConnectionController objCon = new ConnectionController();
        public void insertBorrowingHistory(BorrowingHistoryModel newhborrowing)
        {
            string query = $"INSERT INTO historial_prestamo(id_prestamo, id_libro, id_lector, fecha_prestamo, fecha_vencimiento) VALUES('{newhborrowing.id_borrowing}','{newhborrowing.id_book}','{newhborrowing.id_reader}','{newhborrowing.borrowing_date}', '{newhborrowing.expiration_date}')";
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

        public DataTable getBorrowingHistory()
        {
            DataTable tBook = new DataTable();
            string query = $"select * from lector l INNER JOIN (SELECT * FROM historial_prestamo)e ON l.id_lector=e.id_lector INNER JOIN (SELECT * from libro) li On li.id_libro=e.id_libro";
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

    }
}
