using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BlackGym
{
    public class ModeloPagos
    {
        public bool TienePagoAnterior(int idCliente)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection conn = c1.obtenerconexion())
            {
                conn.Open();
                string query = @"SELECT 1 
                         FROM pagos 
                         WHERE ID_CLIENTE = @ID_CLIENTE 
                         LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", idCliente);
                    var result = cmd.ExecuteScalar();
                    return result != null;
                }
            }
        }
        public bool ActualizarIngresosRestantes(int idCliente, int nuevosIngresosRestantes)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection conn = c1.obtenerconexion())
            {
                conn.Open();
                string query = @"UPDATE Pagos 
                                 SET IngresosRestantes = @IngresosRestantes 
                                 WHERE ID_CLIENTE = @ID_CLIENTE";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@IngresosRestantes", nuevosIngresosRestantes);
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", idCliente);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
        public void BorrarPagosAnteriores(int idCliente)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection conn = c1.obtenerconexion())
            {
                conn.Open();

                string query = @"DELETE FROM pagos 
                         WHERE ID_CLIENTE = @ID_CLIENTE";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", idCliente);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public Pagos BuscarPago(int idCliente/*Pagos u*/)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = 
                @"SELECT 
                *FROM pagos
                WHERE ID_CLIENTE = @ID_CLIENTE AND IngresosRestantes > 0
                ORDER BY Fecha_Pago DESC
                LIMIT 1";


                    //@"SELECT *
                    //     FROM pagos 
                    //     WHERE ID_CLIENTE = @ID_CLIENTE 
                    //     ORDER BY Fecha_Pago DESC 
                    //     LIMIT 1";
                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@ID_CLIENTE", idCliente);

                using (var reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Pagos()
                        {
                            IdPago = Convert.ToInt32(reader["Id_Pago"]),
                            IdCliente = Convert.ToInt32(reader["ID_CLIENTE"]),
                            Fecha_Pago = Convert.ToDateTime(reader["Fecha_Pago"]),
                            Fecha_Vencimiento = Convert.ToDateTime(reader["Fecha_Vencimiento"]),
                            ImportePago = Convert.ToInt32(reader["ImportePago"]),
                            IngresosRestantesN = Convert.ToInt32(reader["IngresosRestantes"])
                        };
                    }
                }
            }
            return null;

            //Conexion c1 = new Conexion();
            //using (MySqlConnection miConexion = c1.obtenerconexion())
            //{
            //    miConexion.Open();
            //    string query = @"SELECT *
            //             FROM pagos 
            //             WHERE IdPago = @Id_Pago LIMIT 1";

            //    MySqlCommand comando = new MySqlCommand(query, miConexion);
            //    comando.Parameters.AddWithValue("@Id_Pago", u.IdPago);

            //    using (var reader = comando.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            Pagos pago=new Pagos()
            //            {
            //                IdPago= Convert.ToInt32(reader["IdPago"]),
            //                IdCliente = Convert.ToInt32(reader["Id_Cliente"]),
            //                Fecha_Pago =    Convert.ToDateTime(reader["Fecha_Pago"]),
            //                Fecha_Vencimiento =    Convert.ToDateTime(reader["Fecha_Vencimiento"])

            //            };
            //        }
            //    }
            //}
            //return null;
        }
        public bool insertarPago(int idCliente, DateTime fechaPago, int ImportePago, int IngresosRestantesN)
        {
            DateTime fechaVencimiento = fechaPago.AddMonths(1);


            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"INSERT INTO Pagos (Id_Cliente, Fecha_Pago, Fecha_Vencimiento, ImportePago, IngresosRestantes)
                     VALUES (@IdCliente, @Fecha_Pago, @Fecha_Vencimiento, @ImportePago, @IngresosRestantes)";
                MySqlCommand comando = new MySqlCommand(query, miConexion);

                comando.Parameters.AddWithValue("@IdCliente", idCliente);
                comando.Parameters.AddWithValue("@Fecha_Pago", fechaPago);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVencimiento);
                comando.Parameters.AddWithValue("@ImportePago", ImportePago);
                comando.Parameters.AddWithValue("@IngresosRestantes", IngresosRestantesN);
                return comando.ExecuteNonQuery() > 0;
            }
        }

            public DataTable obtenerPagos()
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = "SELECT Id_Cliente AS 'ID USUARIO', Fecha_Pago FROM Pagos";
                MySqlCommand comando = new MySqlCommand(query, miConexion);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                DataTable tablaPagos = new DataTable();
                adaptador.Fill(tablaPagos);
                return tablaPagos;
            }
        }
  /*          using (MySqlConnection conn = new Conexion().obtenerconexion())
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, miConexion))
                {
                    cmd.Parameters.AddWithValue("@IdCliente", idCliente);
                    cmd.Parameters.AddWithValue("@Fecha_Pago", fechaPago);
                    cmd.Parameters.AddWithValue("@Fecha_Vencimiento", fechaVencimiento);

                    cmd.ExecuteNonQuery();

                }
            }*/
        

        public bool RestarTurno(int idUsuario)
        {
            Conexion c1 = new Conexion();
            using (MySqlConnection conn = c1.obtenerconexion())
            {
                conn.Open();
                string query = "UPDATE Pagos SET IngresosRestantes = IngresosRestantes - 1 WHERE ID_CLIENTE = @ID_CLIENTE AND IngresosRestantes > 0";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ID_CLIENTE", idUsuario);
                    int filasAfectadas = cmd.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
        public bool ActualizarFechaPago(int idCliente, DateTime nuevaFechaPago)
        {
            DateTime nuevaFechaVencimiento = nuevaFechaPago.AddMonths(1);

            Conexion c1 = new Conexion();
            using (MySqlConnection miConexion = c1.obtenerconexion())
            {
                miConexion.Open();
                string query = @"UPDATE Pagos 
                         SET Fecha_Pago = @Fecha_Pago, Fecha_Vencimiento = @Fecha_Vencimiento 
                         WHERE Id_Cliente = @IdCliente";

                MySqlCommand comando = new MySqlCommand(query, miConexion);
                comando.Parameters.AddWithValue("@Fecha_Pago", nuevaFechaPago);
                comando.Parameters.AddWithValue("@Fecha_Vencimiento", nuevaFechaVencimiento);
                comando.Parameters.AddWithValue("@IdCliente", idCliente);

                return comando.ExecuteNonQuery() > 0;
            }
        }
        /*     HashPassword hashPassword = new HashPassword();
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
                     */
    }
}
