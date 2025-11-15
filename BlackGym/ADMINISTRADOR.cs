using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackGym
{
    public partial class ADMINISTRADOR : Form
    {
        int idRol = 0;
        public ADMINISTRADOR()
        {
            InitializeComponent();
        }

        private void TurnoAsignado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private string ObtenerNombreRol(int idRol)
        {
            switch (idRol)
            {
                case 1:
                    return "Administrador";
                case 2:
                    return "Cliente";
                case 3:
                    return "Recepcionista";
                case 4:
                    return "Empleado";
                default:
                    return "Rol desconocido";
            }
        }
        private void ADMINISTRADOR_Load(object sender, EventArgs e)
        {

            //Colores de los datagrid

            dgvMostrarTurnos.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // o el color que prefieras
            dgvMostrarTurnos.EnableHeadersVisualStyles = false;

            dgvMostrarTurnos.BackgroundColor = Color.Gray;
            dgvMostrarTurnos.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvMostrarTurnos.RowsDefaultCellStyle.BackColor = Color.Gray;
            dgvMostrarTurnos.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvMostrarTurnos.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dgvMostrarTurnos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMostrarTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvMostrarTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvMostrarTurnos.EnableHeadersVisualStyles = false;
            dgvMostrarTurnos.GridColor = Color.Black;

            dgvMostrarUsuario.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // o el color que prefieras
            dgvMostrarUsuario.EnableHeadersVisualStyles = false;
            dgvMostrarUsuario.BackgroundColor = Color.Gray;
            dgvMostrarUsuario.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvMostrarUsuario.RowsDefaultCellStyle.BackColor = Color.Gray;
            dgvMostrarUsuario.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvMostrarUsuario.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dgvMostrarUsuario.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMostrarUsuario.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvMostrarUsuario.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvMostrarUsuario.EnableHeadersVisualStyles = false;
            dgvMostrarUsuario.GridColor = Color.Black;
            //NavajoWhite;

            //OrangeRed;
            Usuario usuarioRol = new Usuario();
            ModeloLogin modeloLoginRol = new ModeloLogin();
            DataTable datosRol = modeloLoginRol.obtenerUsuario();

            if (datosRol.Rows.Count > 0)
            {
                // Obtener el rol del primer usuario como ejemplo
              //  idRol = Convert.ToInt32(datosRol.Rows[1]["idRol"]);

                // Mostrar el rol en tiempo real en el txtRol
                string rolTexto = ObtenerNombreRol(idRol);
                txtRol.Text = rolTexto;
            }


            // HelperTurnos.CargarTurnosEnGrid(dgvMostrarTurnos);
            agregarColumna();
            ModeloTurno modeloTurnos = new ModeloTurno();
            DataTable datos = modeloTurnos.obtenerTurno();
            dgvMostrarTurnos.DataSource = datos;


            ModeloLogin modeloLogin = new ModeloLogin();
            DataTable datos2 = modeloLogin.obtenerUsuario();
            dgvMostrarUsuario.DataSource = datos2;


            ModeloPagos modeloPagos = new ModeloPagos();
            DataTable datosPagos = modeloPagos.obtenerPagos();

            if (datosPagos != null && datosPagos.Rows.Count > 0)
            {
                if (!datos2.Columns.Contains("Fecha de Pago"))
                {
                    datos2.Columns.Add("Fecha de Pago", typeof(string));
                }

                foreach (DataRow fila in datos2.Rows)
                {
                    int idUsuario = Convert.ToInt32(fila["ID USUARIO"]);
                    DataRow pago = datosPagos.AsEnumerable()
                                             .FirstOrDefault(p => Convert.ToInt32(p["ID USUARIO"]) == idUsuario);

                    if (pago != null)
                    {
                        fila["Fecha de Pago"] = Convert.ToDateTime(pago["Fecha_Pago"]).ToString("dd/MM/yyyy");
                    }
                    else
                    {
                        fila["Fecha de Pago"] = "No hay pagos registrados";
                    }
                }
            }

        }
        

        public void agregarColumna()
        {
                       DataGridViewButtonColumn botonDetalles = new DataGridViewButtonColumn();
            botonDetalles.HeaderText = "Usuarios";
            botonDetalles.Text = "Seleccionar";
            botonDetalles.UseColumnTextForButtonValue = true;
            dgvMostrarUsuario.Columns.Add(botonDetalles);

            //DataGridViewButtonColumn botonDetallesTurnos = new DataGridViewButtonColumn();
            //botonDetallesTurnos.HeaderText = "Turnos";
            //botonDetallesTurnos.Text = "Seleccionar";
            //botonDetallesTurnos.UseColumnTextForButtonValue = true;
            //dgvMostrarTurnos.Columns.Add(botonDetallesTurnos);
        }

        private void dgvMostrarTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            //dgvMostrarUsuario
            if (e.RowIndex >= 0) // Asegura que no sea el encabezado
            {

                DataGridViewRow fila = dgvMostrarUsuario.Rows[e.RowIndex];

                // Verificar si la celda "Fecha de Pago" contiene un valor válido
                string fechaPagoTexto = fila.Cells["Fecha de Pago"].Value?.ToString();
                if (DateTime.TryParse(fechaPagoTexto, out DateTime fechaPagoValida))
                {
                    txtFechaPago.Value = fechaPagoValida; // Asignar la fecha válida al DateTimePicker
                }
                else
                {
                    MessageBox.Show("El usuario seleccionado no tiene una fecha de pago registrada.");
                    txtFechaPago.Value = DateTime.Today; // Asignar una fecha predeterminada
                }

                // Asignar otros valores a los TextBoxes
                txtNombre.Text = fila.Cells["Nombre de Usuario"].Value?.ToString();
                txtCorreo.Text = fila.Cells["Correo Electrónico"].Value?.ToString();
                txtTelefono.Text = fila.Cells["Número de Teléfono"].Value?.ToString();
                txtRol.Text = fila.Cells["Rol"].Value?.ToString();
                txtID.Text = fila.Cells["ID USUARIO"].Value?.ToString();

                //DataGridViewRow fila = dgvMostrarUsuario.Rows[e.RowIndex];
                //txtFechaPago.Text = fila.Cells["Fecha de Pago"].Value?.ToString();
                //txtNombre.Text = fila.Cells["Nombre de Usuario"].Value?.ToString();
                //txtCorreo.Text = fila.Cells["Correo Electrónico"].Value?.ToString();
                //txtTelefono.Text = fila.Cells["Número de Teléfono"].Value?.ToString();
                //txtRol.Text = fila.Cells["Rol"].Value?.ToString(); // si tenés un textbox para el rol
                //txtID.Text = fila.Cells["ID USUARIO"].Value?.ToString();
                //   txtFechaPago.Text = fila.Cells["Fecha de Pago"].Value?.ToString();
            }
        }

        private void BtnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int idUsuario)) // Verificar que el ID del usuario sea válido
            {
                // Actualizar la fecha de pago
                DateTime nuevaFechaPago = ((DateTimePicker)txtFechaPago).Value; // Obtener la nueva fecha de pago
                ModeloPagos modeloPagos = new ModeloPagos();
                bool fechaActualizada = modeloPagos.ActualizarFechaPago(idUsuario, nuevaFechaPago);

                // Mostrar mensaje de confirmación
                if (fechaActualizada)
                {
                    MessageBox.Show("Fecha de pago actualizada correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la fecha de pago.");
                }
            }
            else
            {
                MessageBox.Show("ID de usuario no válido.");
            }
            //if (int.TryParse(txtID.Text, out int idUsuario)) // Verificar que el ID del usuario sea válido
            //{
            //    // Actualizar la fecha de pago
            //    DateTime nuevaFechaPago = ((DateTimePicker)txtFechaPago).Value; // Obtener la nueva fecha de pago
            //    ModeloPagos modeloPagos = new ModeloPagos();
            //    bool fechaActualizada = modeloPagos.ActualizarFechaPago(idUsuario, nuevaFechaPago);

            //    // Actualizar el rol del usuario
            //    string rolSeleccionado = NuevoRol.SelectedItem?.ToString();
            //    int nuevoRol = 0;

            //    switch (rolSeleccionado)
            //    {
            //        case "Recepcionista":
            //            nuevoRol = 3; // ID del rol de recepcionista
            //            break;
            //        case "Cliente":
            //            nuevoRol = 2; // ID del rol de cliente
            //            break;
            //        case "Empleado":
            //            nuevoRol = 4; // ID del rol de empleado
            //            break;
            //        default:
            //            MessageBox.Show("Por favor, selecciona un rol válido.");
            //            return;
            //    }

            //    ModeloLogin modeloLogin = new ModeloLogin();
            //    bool rolActualizado = modeloLogin.ActualizarRolUsuario(idUsuario, nuevoRol);

            //    // Mostrar mensajes de confirmación
            //    if (fechaActualizada && rolActualizado)
            //    {
            //        MessageBox.Show("Fecha de pago y rol actualizados correctamente.");
            //    }
            //    else if (fechaActualizada)
            //    {
            //        MessageBox.Show("Fecha de pago actualizada, pero no se pudo actualizar el rol.");
            //    }
            //    else if (rolActualizado)
            //    {
            //        MessageBox.Show("Rol actualizado, pero no se pudo actualizar la fecha de pago.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudieron realizar los cambios.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ID de usuario no válido.");
            //}

        }

        private void txtFechaPago_TextChanged(object sender, EventArgs e)
        {
            //no existe ahora
        }

        private void txtFechaPago_ValueChanged(object sender, EventArgs e)
        {


            //if (int.TryParse(txtID.Text, out int idCliente)) // Asegúrate de que el ID del cliente sea válido
            //{
            //    DateTime nuevaFechaPago = ((DateTimePicker)txtFechaPago).Value; // Obtén la nueva fecha

            //    ModeloPagos modeloPagos = new ModeloPagos();
            //    bool actualizado = modeloPagos.ActualizarFechaPago(idCliente, nuevaFechaPago);

            //    if (actualizado)
            //    {
            //        MessageBox.Show("Fecha de pago actualizada correctamente.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo actualizar la fecha de pago.");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("ID de cliente no válido.");
            //}
        }

        private void NuevoRol_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (int.TryParse(txtID.Text, out int idUsuario)) // Asegúrate de que el ID del usuario sea válido
            //{
            //    string rolSeleccionado = NuevoRol.SelectedItem.ToString();
            //    int nuevoRol = 0;

            //    switch (rolSeleccionado)
            //    {
            //        case "Recepcionista":
            //            nuevoRol = 3; // ID del rol de recepcionista
            //            break;
            //        case "Cliente":
            //            nuevoRol = 2; // ID del rol de cliente
            //            break;
            //        case "Empleado":
            //            nuevoRol = 4; // ID del rol de empleado
            //            break;
            //        default:
            //            MessageBox.Show("Rol no válido seleccionado.");
            //            return;
            //    }

            //    ModeloLogin modeloLogin = new ModeloLogin();
            //    bool actualizado = modeloLogin.ActualizarRolUsuario(idUsuario, nuevoRol);

            //    if (actualizado)
            //    {
            //        MessageBox.Show("Rol actualizado correctamente.");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo actualizar el rol.");
            //    }
            }

        private void ModificarRol_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int idUsuario)) // Verificar que el ID del usuario sea válido
            {
                // Obtener el rol seleccionado del ComboBox
                string rolSeleccionado = NuevoRol.SelectedItem?.ToString();
                int nuevoRol = 0;

                // Determinar el ID del rol según el rol seleccionado
                switch (rolSeleccionado)
                {
                    case "Recepcionista":
                        nuevoRol = 3; // ID del rol de recepcionista
                        break;
                    case "Cliente":
                        nuevoRol = 2; // ID del rol de cliente
                        break;
                    case "Empleado":
                        nuevoRol = 4; // ID del rol de empleado
                        break;
                    default:
                        MessageBox.Show("Por favor, selecciona un rol válido.");
                        return;
                }

                // Actualizar el rol en la base de datos
                ModeloLogin modeloLogin = new ModeloLogin();
                bool rolActualizado = modeloLogin.ActualizarRolUsuario(idUsuario, nuevoRol);

                // Mostrar mensaje de confirmación y actualizar el txtRol
                if (rolActualizado)
                {
                    MessageBox.Show("Rol actualizado correctamente.");

                    // Recargar el rol actualizado desde la base de datos
                    DataTable datosRol = modeloLogin.obtenerUsuario();
                    DataRow usuarioActualizado = datosRol.AsEnumerable()
                                                         .FirstOrDefault(u => Convert.ToInt32(u["ID USUARIO"]) == idUsuario);

                    if (usuarioActualizado != null)
                    {
                        txtRol.Text = usuarioActualizado["Rol"].ToString(); // Actualizar el txtRol con el nuevo rol
                    }
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el rol.");
                }
            }
            else
            {
                MessageBox.Show("ID de usuario no válido.");
            }
        }
            //else
            //{
            //    MessageBox.Show("ID de usuario no válido.");
            //}
        

        private void txtRol_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }//no existe

        private void eliminarUsuario_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtID.Text, out int idUsuario)) // Verificar que el ID del usuario sea válido
            {
                ModeloLogin modeloLogin = new ModeloLogin();
                bool eliminado = modeloLogin.EliminarUsuario(idUsuario);

                if (eliminado)
                {
                    MessageBox.Show("Usuario eliminado correctamente.");

                    // Actualizar el DataGridView para reflejar los cambios
                    DataTable datosActualizados = modeloLogin.obtenerUsuario();
                    dgvMostrarUsuario.DataSource = datosActualizados;
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.");
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void eliminarTurno_Click(object sender, EventArgs e)
        {
            if (dgvMostrarTurnos.SelectedRows.Count > 0) // Verificar que haya una fila seleccionada
            {
                DataGridViewRow filaSeleccionada = dgvMostrarTurnos.SelectedRows[0];
                if (int.TryParse(filaSeleccionada.Cells["idTurno"].Value?.ToString(), out int idTurno)) // Verificar que el ID sea válido
                {
                    ModeloTurno modeloTurno = new ModeloTurno();
                    bool eliminado = modeloTurno.EliminarTurno(idTurno);

                    if (eliminado)
                    {
                        MessageBox.Show("Turno eliminado correctamente.");

                        // Actualizar el DataGridView para reflejar los cambios
                        DataTable datosActualizados = modeloTurno.obtenerTurno();
                        dgvMostrarTurnos.DataSource = datosActualizados;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el turno.");
                    }
                }
                else
                {
                    MessageBox.Show("ID de turno no válido.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un turno para eliminar.");
            }
        }

        private void BotonCerrarSesion_Click(object sender, EventArgs e)
        {
            // Limpiar la sesión actual
            SesionActual.UsuarioLogueado = null;

            // Redirigir al formulario de inicio de sesión
            Form1 loginForm = new Form1();
            this.Hide(); // Ocultar el formulario actual
            loginForm.Show(); // Mostrar el formulario de inicio de sesión

        }
        //else
        //{
        //    MessageBox.Show("ID de usuario no válido.");
        //}
    }

        //dgvMostrarUsuario
}



