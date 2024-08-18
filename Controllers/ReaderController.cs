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
    public class ReaderController
    {
        ConnectionController objCon = new ConnectionController();

        public void InsertReader(ReaderModel reader)
        {
            string query= $"INSERT INTO lector(nombre_lector, num_identificacion, telefono) VALUES('{reader.name}', '{reader.id_number}', '{reader.phone}')";
            try
            {
                if (objCon.Connect())
                {
                    MySqlCommand cmd = new MySqlCommand(query, objCon.getConection());
                    cmd.ExecuteNonQuery();
                    objCon.CloseConnection();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        public DataTable getReaders()
        {
            DataTable tBook = new DataTable();
            string query = $"SELECT * FROM lector";
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

        public void UpdateReader(ReaderModel reader)
        {

            string query = $"UPDATE lector SET nombre_lector='{reader.name}', num_identificacion='{reader.id_number}', telefono='{reader.phone}' WHERE id_lector='{reader.id_reader}'";
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

