using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BlackGym
{
    public partial class Recepcion : Form
    {
        public Recepcion()
        {
            InitializeComponent();
        }
        private void RECEPCION_Load(object sender, EventArgs e)
        {
            //HelperTurnos.CargarTurnosEnGrid(dgvMuestroTurno);




        }
        private void dgvMostrarTurnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//no se usa

        private void dgvMuestroTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMuestroTurno_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
            //dgvMuestroTurnos.Columns.Add(botonDetallesTurnos);

        }
        private void Recepcion_Load_1(object sender, EventArgs e)
        {
            dgvMuestroTurnos.RowHeadersDefaultCellStyle.BackColor = Color.LightGray; // o el color que prefieras
            dgvMuestroTurnos.EnableHeadersVisualStyles = false;
            dgvMuestroTurnos.BackgroundColor = Color.Gray;
            dgvMuestroTurnos.AlternatingRowsDefaultCellStyle.BackColor = Color.Gray;
            dgvMuestroTurnos.RowsDefaultCellStyle.BackColor = Color.Gray;
            dgvMuestroTurnos.DefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvMuestroTurnos.DefaultCellStyle.SelectionBackColor = Color.DarkGray;
            dgvMuestroTurnos.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMuestroTurnos.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkRed;
            dgvMuestroTurnos.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dgvMuestroTurnos.EnableHeadersVisualStyles = false;
            dgvMuestroTurnos.GridColor = Color.Black;

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
            // HelperTurnos.CargarTurnosEnGrid(dgvMuestroTurnos);
            agregarColumna();

            // Cargar turnos en el DataGridView
            ModeloTurno modeloTurnos = new ModeloTurno();
            DataTable datosTurnos = modeloTurnos.obtenerTurno();
            dgvMuestroTurnos.DataSource = datosTurnos;

            // Cargar usuarios en el DataGridView
            ModeloLogin modeloLogin = new ModeloLogin();
            DataTable datosUsuarios = modeloLogin.obtenerUsuario();
            dgvMostrarUsuario.DataSource = datosUsuarios;

            // Cargar pagos y verificar columnas
            ModeloPagos modeloPagos = new ModeloPagos();
            DataTable datosPagos = modeloPagos.obtenerPagos();

            if (datosPagos != null && datosPagos.Rows.Count > 0)
            {
                if (!datosUsuarios.Columns.Contains("Fecha de Pago"))
                {
                    datosUsuarios.Columns.Add("Fecha de Pago", typeof(string));
                }

                foreach (DataRow fila in datosUsuarios.Rows)
                {
                    int idUsuario = Convert.ToInt32(fila["ID USUARIO"]); // Usar la columna 'ID USUARIO' como referencia
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

            //else
            //{
            //    MessageBox.Show("No se encontraron datos de pagos.");
            //}
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

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
            //else
            //{
            //    MessageBox.Show("ID de usuario no válido.");
            //}
        }

        private void dgvMostrarUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            }
        }

        private void eliminarTurno_Click(object sender, EventArgs e)
        {
            if (dgvMuestroTurnos.SelectedRows.Count > 0) // Verificar que haya una fila seleccionada
            {
                DataGridViewRow filaSeleccionada = dgvMuestroTurnos.SelectedRows[0];
                if (int.TryParse(filaSeleccionada.Cells["idTurno"].Value?.ToString(), out int idTurno)) // Verificar que el ID sea válido
                {
                    ModeloTurno modeloTurno = new ModeloTurno();
                    bool eliminado = modeloTurno.EliminarTurno(idTurno);

                    if (eliminado)
                    {
                        MessageBox.Show("Turno eliminado correctamente.");

                        // Actualizar el DataGridView para reflejar los cambios
                        DataTable datosActualizados = modeloTurno.obtenerTurno();
                        dgvMuestroTurnos.DataSource = datosActualizados;
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
    }
}
