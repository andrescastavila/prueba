using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PRUEBA.Models
{
    public class DiscosRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Ver video Juanmi 09";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }

        internal Discos Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from discos";

            try
            {
                con.Open();
                command.ExecuteReader();
                MySqlDataReader res = command.ExecuteReader();

                Discos d = null;
                if (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + res.GetString(1) + res.GetInt32(2) + res.GetString(3));
                    d = new Discos(res.GetInt32(0), res.GetString(1), res.GetInt32(2), res.GetString(3));
                }

                con.Close();
                return d;
            }catch(MySqlException e)
            {
                Debug.WriteLine("Se ha producido un error de conexion");
                return null;
            }
        }

    }
}