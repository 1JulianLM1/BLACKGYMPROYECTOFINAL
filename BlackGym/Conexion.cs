using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGym
{
    public class Conexion
    {
        private const string servidor = "datasource= 127.0.0.1";
        private const string puerto = "port=3306";
        private const string username = "Username=root";
        private const string password = "password=24072006";
        private const string bd = "database=BlackGym";

        private string cadenaconexion;

        public Conexion()
        {

            cadenaconexion = servidor + ";" + puerto + ";" + username + ";" + password + ";" + bd;
            using (MySqlConnection conn = new MySqlConnection(cadenaconexion))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de conexión: " + ex.Message);
                }
            }
        }
        public MySqlConnection obtenerconexion()
        {
            return new MySqlConnection(cadenaconexion);
        }
    }
}
