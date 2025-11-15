using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGym
{

    public class ModeloLogin
    {
        // Buscar usuario en la BD 
        public Usuario BuscarUsuario(Usuario u)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"SELECT *
                         FROM usuarios 
                         WHERE NombreUsuario = @NombreUsuario LIMIT 1";

                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@NombreUsuario", u.NombreUsuario);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = int.Parse(reader["ID"].ToString()),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            Correo = reader["CorreoElectronico"].ToString(),
                            NumTel = reader["NumeroTelefono"].ToString(),
                            rol = Convert.ToInt32(reader["idRol"])
                        };
                    }
                }
            }
            return null;
        }
        public bool ActualizarRolUsuario(int idUsuario, int nuevoRol)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"UPDATE usuarios SET IdRol = @nuevoRol WHERE ID = @idUsuario";

                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@nuevoRol", nuevoRol);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                return comando.ExecuteNonQuery() > 0;
            }
        }
        public bool EliminarUsuario(int idUsuario)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"DELETE FROM usuarios WHERE ID = @idUsuario";

                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                return comando.ExecuteNonQuery() > 0;
            }
        }
        // Registrar usuario
        public bool RegistroUsuario(Usuario usuario)
        {
            HashPassword hashPassword = new HashPassword();
            string hash = hashPassword.generarEncriptacionSHA1(usuario.Contraseña);

            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"INSERT INTO usuarios(nombreUsuario, contraseña, CorreoElectronico, NumeroTelefono,idRol) 
                         VALUES (@nombreUsuario, @contraseña, @CorreoElectronico, @NumeroTelefono,@idRol)";

                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.NombreUsuario);
                comando.Parameters.AddWithValue("@CorreoElectronico", usuario.Correo);
                comando.Parameters.AddWithValue("@contraseña", hash);
                comando.Parameters.AddWithValue("@NumeroTelefono", usuario.NumTel);
                comando.Parameters.AddWithValue("@idRol", 2);
                return comando.ExecuteNonQuery() > 0;
            }

        }
        public DataTable obtenerUsuario()
        {
            Conexion c1 = new Conexion();
            DataTable dataTable = new DataTable();

            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                //  string query = @"SELECT * from usuarios";
                string query = @"SELECT u.nombreUsuario AS 'Nombre de Usuario', 
                                u.CorreoElectronico AS 'Correo Electrónico', 
                                u.NumeroTelefono AS 'Número de Teléfono',
                                r.Nombre AS 'Rol', 
                                u.ID AS 'ID USUARIO'
                                
                         FROM usuarios u 
                         JOIN rol r ON u.IdRol = r.ID";


                MySqlDataAdapter adapter = new MySqlDataAdapter(query, miConexion);
                adapter.Fill(dataTable);
                return dataTable;
                
            }
        }
        public Usuario BuscarUsuarioPorCorreo(string correo)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"SELECT *
                         FROM usuarios 
                         WHERE CorreoElectronico = @CorreoElectronico LIMIT 1";

                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@CorreoElectronico", correo);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Usuario
                        {
                            Id = int.Parse(reader["ID"].ToString()),
                            NombreUsuario = reader["NombreUsuario"].ToString(),
                            Contraseña = reader["Contraseña"].ToString(),
                            Correo = reader["CorreoElectronico"].ToString(),
                            NumTel = reader["NumeroTelefono"].ToString(),
                            rol = Convert.ToInt32(reader["idRol"])
                        };
                    }
                }
            }
            return null;
        }
    }
}