using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackGym
{
    public class ModeloTurno
    {
        public DataTable obtenerTurnosPorUsuario(int idUsuario)
        {
            Conexion c1 = new Conexion();
            DataTable dataTable = new DataTable();

            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"SELECT * FROM turno WHERE idUsuario = @idUsuario ORDER BY dia";

                using (MySqlCommand cmd = new MySqlCommand(query, miConexion))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
        public bool UsuarioTieneTurnoEnFecha(int idUsuario, DateTime fecha)
        {
            bool existe = false;

            string query = @"SELECT COUNT(*) 
                     FROM turno 
                     WHERE idUsuario = @idUsuario 
                     AND DATE(dia) = @fecha";

            Conexion c1 = new Conexion();

            using (MySqlConnection conn = c1.obtenerconexion())
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
                    cmd.Parameters.AddWithValue("@fecha", fecha.Date);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    existe = count > 0;
                }
            }

            return existe;
        }
        public DataTable obtenerTurno()
        {
            Conexion c1 = new Conexion();
            DataTable dataTable = new DataTable();

            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"SELECT * from turno";

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, miConexion);
                adapter.Fill(dataTable);
                return dataTable;
            }
        } // Inserta y devuelve true/false, pero además saca el ID generado
        public bool RegistrarTurno(Turno t, out int idGenerado)
        {
            idGenerado = -1;
            Conexion conexion = new Conexion();

            using (var con = conexion.obtenerconexion())
            {
                con.Open();
                string query = "INSERT INTO turno (dia, hora, idUsuario) VALUES (@dia, @hora, @idUsuario); SELECT LAST_INSERT_ID();";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@dia", t.dia);
                comando.Parameters.AddWithValue("@hora", t.hora);
                comando.Parameters.AddWithValue("@idUsuario", t.idUsuario);

                object result = comando.ExecuteScalar();
                if (result != null)
                {
                    idGenerado = Convert.ToInt32(result);
                    return true;
                }
                return false;
            }
        }


        /*  public int RegistrarTurno(Turno t) este es el de copilot
          {
              Conexion conexion = new Conexion();

              using (var con = conexion.obtenerconexion())
              {
                  con.Open();
                  string query = "INSERT INTO turno (dia, hora, idUsuario) VALUES (@dia, @hora, @idUsuario); SELECT LAST_INSERT_ID();";
                  MySqlCommand comando = new MySqlCommand(query, con);
                  comando.Parameters.AddWithValue("@dia", t.dia);
                  comando.Parameters.AddWithValue("@hora", t.hora);
                  comando.Parameters.AddWithValue("@idUsuario", t.idUsuario);

                  object result = comando.ExecuteScalar();
                  return Convert.ToInt32(result); // devuelve el ID generado
              }
          }*/

        /* public bool RegistrarTurno(Turno t) este es el original
         {
             Conexion conexion= new Conexion();

             using(var con= conexion.obtenerconexion())
             { 
                 con.Open();
                 string query = "INSERT INTO turno (dia, hora, idUsuario) VALUES (@dia, @hora, @idUsuario)";
                 MySqlCommand comando = new MySqlCommand(query, con);
                 comando.Parameters.AddWithValue("@dia", t.dia);
                 comando.Parameters.AddWithValue("@hora", t.hora);
                 comando.Parameters.AddWithValue("@idUsuario", t.idUsuario);
                 return comando.ExecuteNonQuery() > 0;  

             }
         }*/
        public bool EliminarTurno(int idTurno)
        {
            Conexion conexion = new Conexion();

            using (var con = conexion.obtenerconexion())
            {
                con.Open();
                string query = "DELETE FROM turno WHERE idTurno = @idTurno";
                MySqlCommand comando = new MySqlCommand(query, con);
                comando.Parameters.AddWithValue("@idTurno", idTurno);
                return comando.ExecuteNonQuery() > 0;
            }
        }

    }



}
