using biblioteca.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca.Controllers
{
    public class ReturnController
    {
        ConnectionController objCon = new ConnectionController();
        public void InsertReturn(ReturnModel newreturn)
        {


            string query = $"INSERT INTO devolucion(id_libro, id_lector, fecha_devolucion) VALUES('{newreturn.id_book}','{newreturn.id_reader}','{newreturn.return_date}')";
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
