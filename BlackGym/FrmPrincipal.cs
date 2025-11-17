using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackGym
{
    public partial class FrmPrincipal : Form
    {
        public int precio = 0;
        public int IngresoRestanteVAR = 0;
        public int segundosTrabajados = 0;
        public int segundosIniciales = 3600;
        private int turnoActualId = -1; // guardamos el ID del turno
        Usuario usuariologin;
        public FrmPrincipal(Usuario usuariologin)
        {
            
            InitializeComponent();
            this.usuariologin = usuariologin;
        }

        private void FechaTurno_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaAsignada = FechaTurno.Value;

            // Hay que hacer un control para que el usuario no ingrese una fecha anterior a la actual, tampoco una usada por el mismo cliente, y tampoco que sea un fin de semana

            if (fechaAsignada.Date < DateTime.Today)
            {
                MessageBox.Show("No puedes seleccionar una fecha anterior a la actual. Por favor, elige una fecha válida.");
                FechaTurno.Value = DateTime.Today; // Restablecer al valor válido
            }
          else if (fechaAsignada.DayOfWeek == DayOfWeek.Saturday || fechaAsignada.DayOfWeek == DayOfWeek.Sunday)
            {
                MessageBox.Show("No puedes seleccionar un fin de semana. Por favor, elige un día entre lunes y viernes.");
                FechaTurno.Value = DateTime.Today; // Restablecer al valor válido
            }
            else
            {
                // Aquí podrías agregar lógica para verificar si el usuario ya tiene un turno en esa fecha
                ModeloTurno modeloTurno = new ModeloTurno();
                bool tieneTurno = modeloTurno.UsuarioTieneTurnoEnFecha(SesionActual.UsuarioLogueado.Id, fechaAsignada);
                if (tieneTurno)
                {
                    MessageBox.Show("Ya tienes un turno asignado en esta fecha. Por favor, elige otra fecha.");
                    FechaTurno.Value = DateTime.Today; // Restablecer al valor válido
                }
            }

        }
        private void guardarT_Click(object sender, EventArgs e)
        {
            // Declarar UNA vez y usar la misma instancia dentro del método
            ModeloPagos pagosModel = new ModeloPagos();

            // Consultar el pago actual desde la base (tiempo real)
            Pagos pago = pagosModel.BuscarPago(SesionActual.UsuarioLogueado.Id);
            IngresoRestanteVAR = pago?.IngresosRestantesN ?? 0;
            IngresoRestanteT.Text = IngresoRestanteVAR.ToString();

            // CONTROL DE INGRESOS RESTANTES
            if (IngresoRestanteVAR <= 0)
            {
                MessageBox.Show("No tienes ingresos restantes para registrar un nuevo turno. Por favor, realiza un pago.");
                return;
            }

            // Controlamos si ingresa un horario
            if (string.IsNullOrEmpty(listaHorarios.Text))
            {
                MessageBox.Show("Por favor, selecciona un horario para el turno.");
                return;
            }

            // Construir turno
            string dia = FechaTurno.Value.ToString();
            string hora = listaHorarios.Text;

            Turno t = new Turno()
            {
                dia = dia,
                hora = hora,
                idUsuario = SesionActual.UsuarioLogueado.Id
            };

            ModeloTurno modeloTurno = new ModeloTurno();
            bool resultado = modeloTurno.RegistrarTurno(t, out turnoActualId);

            if (resultado)
            {
                // Usar la misma instancia pagosModel para restar el turno
                bool restado = pagosModel.RestarTurno(t.idUsuario);

                // Volver a consultar la BD para actualizar lo que se muestra en pantalla
                pago = pagosModel.BuscarPago(t.idUsuario);
                IngresoRestanteVAR = pago?.IngresosRestantesN ?? 0;
                IngresoRestanteT.Text = IngresoRestanteVAR.ToString();

                MessageBox.Show("Turno registrado correctamente. ID: " + turnoActualId);
            }
            else
            {
                MessageBox.Show("No se pudo registrar el turno.");
            }
            //ModeloPagos modeloPagos = new ModeloPagos();
            //Pagos pagoActual = modeloPagos.BuscarPago(SesionActual.UsuarioLogueado.Id);

            //IngresoRestanteVAR = pagoActual?.IngresosRestantesN ?? 0;
            //IngresoRestanteT.Text = IngresoRestanteVAR.ToString(); 

            //// --- CONTROL DE INGRESOS RESTANTES ---
            //if (IngresoRestanteVAR <= 0)
            //{
            //    MessageBox.Show("No tienes ingresos restantes para registrar un nuevo turno. Por favor, realiza un pago.");
            //    return;
            //}
            //if (IngresoRestanteVAR <= 0 /*|| precio <= 0*/)
            //{
            //    MessageBox.Show("No tienes ingresos restantes para registrar un nuevo turno. Por favor, realiza un pago.");
            //    return;
            //}
            //else if (IngresoRestanteVAR == 0) //tendriamos que comprobar en tiempo real, es decir hacer todo el codigo que hay en el load
            //{
            //    MessageBox.Show("No tienes ingresos restantes para registrar un nuevo turno. Por favor, realiza un pago.");
            //    return;
            //}
            ////Controlamos si ingresa un horario
            //if (string.IsNullOrEmpty(listaHorarios.Text))
            //{
            //    MessageBox.Show("Por favor, selecciona un horario para el turno.");
            //    return;
            //}


            //else
            //{


            //    string dia = FechaTurno.Value.ToString();
            //    string hora = listaHorarios.Text;

            //    Turno t = new Turno()
            //    {
            //        dia = dia,
            //        hora = hora,
            //        idUsuario = SesionActual.UsuarioLogueado.Id
            //    };

            //    ModeloTurno modeloTurno = new ModeloTurno();
            //    bool resultado = modeloTurno.RegistrarTurno(t, out turnoActualId);

            //    if (resultado)
            //    {
            //        ModeloPagos modeloPagos = new ModeloPagos();
            //        bool restado = modeloPagos.RestarTurno(t.idUsuario);
            //        // Actualizar y mostrar los ingresos restantes
            //        Pagos pagoActual = modeloPagos.BuscarPago(t.idUsuario);
            //        int ingresosRestantesUsuario = pagoActual?.IngresosRestantesN ?? 0;
            //        IngresoRestanteT.Text = ingresosRestantesUsuario.ToString();

            //        MessageBox.Show("Turno registrado correctamente. ID: " + turnoActualId);
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo registrar el turno.");
            //    }
            //}
        }


       /* private void guardarT_Click(object sender, EventArgs e) este es el original
        {
            string dia = FechaTurno.Value.ToString();
            string hora = listaHorarios.Text;

            Turno t = new Turno()
            {
                dia = dia,
                hora = hora,
                idUsuario = SesionActual.UsuarioLogueado.Id
            };
            ModeloTurno modeloTurno = new ModeloTurno();
            bool resultado = modeloTurno.RegistrarTurno(t);

            if (resultado != null)
            {
       
            }

        }*/
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContadorTiempoTxtBox_TextChanged(object sender, EventArgs e)
        {/*
            Timer temporizador = new Timer(); //si clickeo guardarT_Click se inicia el timer
            temporizador.Interval = 1000; // Intervalo de 1 segundo (1000 milisegundos)
            temporizador.Tick += (s, args) =>
            {
                temporizador.Start();
                if (int.TryParse(ContadorTiempoTxtBox.Text, out int tiempoRestante))
                {
                    if (tiempoRestante > 0)
                    {
                        tiempoRestante--;
                        ContadorTiempoTxtBox.Text = tiempoRestante.ToString();
                    }
                    else
                    {
                        temporizador.Stop();
                        MessageBox.Show("El tiempo ha terminado.");
                    }
                }
                else
                {
                    temporizador.Stop();
                    MessageBox.Show("Entrada no válida en el contador de tiempo.");
                }
            };
            */




        }


        private void BotonTemporizador_Click(object sender, EventArgs e)
        {
            //Si clickeo el boton, se inicia el timer
            if(turnoActualId <= 0)
            {
                MessageBox.Show("Por favor, registra un turno antes de iniciar el temporizador.");
                return;
            }
            else { 
                segundosTrabajados = 0;
            TurnoClienteTimer.Start();
            }
        }


        private void iniciarContador()
        {
            TurnoClienteTimer.Start();

            while(segundosTrabajados <= segundosIniciales)
            {
                lblCronometro.Text = $"En progreso: {TimeSpan.FromSeconds(segundosIniciales):mm\\:ss}";

            }

            /*
            while (segundosTrabajados <= 3600)
            {
                segundosIniciales -= segundosTrabajados;
                lblCronometro.Text = $"En progreso: {TimeSpan.FromSeconds(segundosIniciales):mm\\:ss}";

            }

            if(segundosTrabajados == 3600)
            {
                TurnoClienteTimer.Stop();
                MessageBox.Show("El turno ha finalizado.");
            }*/

            /*

                        if(segundosTrabajados <= 3600)
                        {
                            for (int i = 0; i < 3600; i++)
                            {
                                segundosTrabajados = i;

                            }
                            lblCronometro.Text = $"En progreso: {TimeSpan.FromSeconds(segundosTrabajados):mm\\:ss}";

                        }



                        else 
                        if (segundosTrabajados >= 3600) // 1 hora = 3600 segundos
                        {
                            TurnoClienteTimer.Stop();
                            MessageBox.Show("El turno ha finalizado.");


                        }*/
        }

        private void TurnoClienteTimer_Tick_1(object sender, EventArgs e)
        {


            if (segundosTrabajados < segundosIniciales)
            {
                segundosTrabajados++;
                TimeSpan tiempoRestante = TimeSpan.FromSeconds(segundosIniciales - segundosTrabajados);
                lblCronometro.Text = $"Tiempo restante: {tiempoRestante:hh\\:mm\\:ss}";
            }
            else
            {
                TurnoClienteTimer.Stop();
                MessageBox.Show("¡Tiempo finalizado!");

                if (turnoActualId > 0)
                {
                    ModeloTurno modeloTurno = new ModeloTurno();
                    if (modeloTurno.EliminarTurno(turnoActualId))
                        MessageBox.Show("El turno fue eliminado de la base de datos.");
                    else
                        MessageBox.Show("No se pudo eliminar el turno.");
                }
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            TurnoClienteTimer.Stop();

            //Hay que controlar que el usuario sea el cliente logueado

            int idCliente = SesionActual.UsuarioLogueado.Id;

            ModeloTurno modeloTurnos = new ModeloTurno();
            DataTable datosTurnos = modeloTurnos.obtenerTurnosPorUsuario(idCliente);
            dgvMuestroTurnos.DataSource = datosTurnos;


            //
            ModeloPagos modeloPagos = new ModeloPagos();
            

            // Buscar el pago más reciente del usuario
            Pagos pagoActual = modeloPagos.BuscarPago(idCliente);

            if (pagoActual != null)
            {
                // Mostrar fecha de abono registrada
                MiFechaAbono.Text = pagoActual.Fecha_Pago.ToString("dd/MM/yyyy");

                // Mostrar fecha de vencimiento registrada
                MiFechaVencimiento.Text = pagoActual.Fecha_Vencimiento.ToString("dd/MM/yyyy");

                // Mostrar ingresos restantes
                IngresoRestanteVAR = pagoActual.IngresosRestantesN;
                IngresoRestanteT.Text = IngresoRestanteVAR.ToString();
            }
            else
            {
                // No tiene pagos registrados

                DateTime hoy = DateTime.Today;
                DateTime vencimiento = hoy.AddMonths(1);

                MiFechaAbono.Text = hoy.ToString("dd/MM/yyyy");
                MiFechaVencimiento.Text = vencimiento.ToString("dd/MM/yyyy");

                IngresoRestanteVAR = 0;
                IngresoRestanteT.Text = "0";
            }

            //TurnoClienteTimer.Stop();

            //// Inicializar los ingresos restantes del usuario logueado
            //ModeloPagos modeloPagos = new ModeloPagos();
            //int idCliente = SesionActual.UsuarioLogueado.Id;



            //Pagos pagoActual = modeloPagos.BuscarPago(idCliente);

            //if (pagoActual != null)
            //{
            //    // Mostrar fecha de abono (generada automáticamente al registrar el pago)
            //    MiFechaAbono.Text = pagoActual.Fecha_Pago.ToString("dd/MM/yyyy");

            //    // Mostrar fecha de vencimiento (viene de la base de datos)
            //    MiFechaVencimiento.Text = pagoActual.Fecha_Vencimiento.ToString("dd/MM/yyyy");

            //    // Mostrar ingresos restantes
            //    IngresoRestanteVAR = pagoActual.IngresosRestantesN;
            //    IngresoRestanteT.Text = IngresoRestanteVAR.ToString();
            //}
            //else
            //{
            //    //  MessageBox.Show("No se encontraron pagos registrados para este usuario.");
            //    DateTime hoy = DateTime.Today;
            //    DateTime vencimiento = hoy.AddMonths(1);
            //    // Valores por defecto
            //    IngresoRestanteVAR = 0;
            //    MiFechaAbono.Text = hoy.ToString("dd/MM/yyyy");
            //    MiFechaVencimiento.Text = vencimiento.ToString("dd/MM/yyyy"); // o podés usar DateTime.Today también

            //    IngresoRestanteT.Text = IngresoRestanteVAR.ToString();
            //}

            ////Pagos pagoActual = modeloPagos.BuscarPago(idCliente);
            ////IngresoRestanteVAR = pagoActual?.IngresosRestantesN ?? 0;
            ////MiFechaAbono = pagoActual?.Fecha_Pago ?? DateTime.Today;
            ////MiFechaVencimiento = pagoActual?.Fecha_Vencimiento ?? DateTime.Today;
            ////// Mostrar los ingresos restantes en el TextBox
            ////IngresoRestanteT.Text = IngresoRestanteVAR.ToString();
        }

        private void FechaAbono_Click(object sender, EventArgs e)
        {

        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void BotonPago_Click(object sender, EventArgs e)
        {
            ModeloPagos modeloPagos = new ModeloPagos();
            int idCliente = SesionActual.UsuarioLogueado.Id;

            // Obtener el último pago del usuario
            Pagos pagoActual = modeloPagos.BuscarPago(idCliente);
            int ingresosRestantesUsuario = pagoActual?.IngresosRestantesN ?? 0;

            // 1️⃣ Si aún tiene ingresos disponibles → no permitir pagar
            if (ingresosRestantesUsuario > 0)
            {
                MessageBox.Show("Aún tienes ingresos restantes. No es necesario realizar un nuevo pago.");
                return;
            }

            // 2️⃣ Validar que haya seleccionado un abono
            if (precio == 0)
            {
                MessageBox.Show("Por favor, selecciona un tipo de abono válido antes de realizar el pago.");
                return;
            }

            // 3️⃣ Si existe un pago anterior → borrarlo
            if (modeloPagos.TienePagoAnterior(idCliente))
            {
                modeloPagos.BorrarPagosAnteriores(idCliente);
            }

            // 4️⃣ Insertar SIEMPRE el nuevo pago
            DateTime fechaPago = DateTime.Today;
            int ImportePago = precio;
            int IngresosRestantesN = IngresoRestanteVAR;

            modeloPagos.insertarPago(idCliente, fechaPago, ImportePago, IngresosRestantesN);

            // 5️⃣ Mensaje final
            MessageBox.Show(
                "Pago registrado correctamente con vencimiento en " +
                fechaPago.AddMonths(1).ToShortDateString()
            );



            //ModeloPagos modeloPagos = new ModeloPagos();
            //int idCliente = SesionActual.UsuarioLogueado.Id;

            //// Obtener los ingresos restantes del usuario logueado desde la base de datos
            //Pagos pagoActual = modeloPagos.BuscarPago(idCliente);
            //int ingresosRestantesUsuario = pagoActual?.IngresosRestantesN ?? 0;

            //if (ingresosRestantesUsuario > 0)
            //{
            //    MessageBox.Show("Aún tienes ingresos restantes. No es necesario realizar un nuevo pago.");
            //    return;
            //}
            //else
            //{
            //    if (precio == 0)
            //    {
            //        MessageBox.Show("Por favor, selecciona un tipo de abono válido antes de realizar el pago.");
            //        return;
            //    }
            //    else if(modeloPagos.TienePagoAnterior(idCliente))
            //    {
            //        modeloPagos.BorrarPagosAnteriores(idCliente);
            //    }
            //    else
            //    {


            //        DateTime fechaPago = DateTime.Today;
            //        int ImportePago = precio;
            //        int IngresosRestantesN = IngresoRestanteVAR;
            //        modeloPagos.insertarPago(idCliente, fechaPago, ImportePago, IngresosRestantesN);

            //        MessageBox.Show("Pago registrado correctamente con vencimiento en " + fechaPago.AddMonths(1).ToShortDateString());

            //        MessageBox.Show(
            //            "Pago registrado correctamente con vencimiento en "
            //            + fechaPago.AddMonths(1).ToShortDateString()
            //        );


            //    }
            //}


            //if (IngresoRestanteVAR > 0)
            //{ 
            //    MessageBox.Show("Aún tienes ingresos restantes. No es necesario realizar un nuevo pago.");
            //return;
            //}
            //else { 
            //if (precio == 0 || IngresoRestanteVAR == 0)
            //{
            //    MessageBox.Show("Por favor, selecciona un tipo de abono válido antes de realizar el pago.");
            //    return;
            //}
            //else
            //{
            //    ModeloPagos modeloPagos = new ModeloPagos();
            //    DateTime fechaPago = DateTime.Today;
            //    // Ejemplo: supongamos que el ID del cliente lo tenés en un TextBox llamado txtIdCliente
            //    SesionActual sesionActual = new SesionActual();

            //    int idCliente = SesionActual.UsuarioLogueado.Id;
            //    int ImportePago = precio; // Ejemplo de importe, podés obtenerlo de otro lado //// Voy a necesitar del combobox, el cual define el tipo de abono y su importe
            //    int IngresosRestantesN = IngresoRestanteVAR; // Ejemplo de ingresos restantes, podés obtenerlo de otro lado
            //      //  IngresoRestanteT.Text = Convert.ToString(IngresosRestantesN);                                             // Insertar el pago
            //    modeloPagos.insertarPago(idCliente, fechaPago, ImportePago, IngresosRestantesN);

            //    MessageBox.Show("Pago registrado correctamente con vencimiento en " + fechaPago.AddMonths(1).ToShortDateString());
            //}
            //}
        }

        private void txtIdUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMiSaldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void MisTurnosSemanalesCBX_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Aquí podrías agregar lógica para actualizar el precio en base a la selección del usuario
        //    MisTurnosSemanalesCBX.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            if (MisTurnosSemanalesCBX.SelectedItem == null) return;

           
            switch (MisTurnosSemanalesCBX.SelectedItem.ToString())
            {
                case "1":
                    precio = 30000;
                    IngresoRestanteVAR = 4;
                    break;
                case "2":
                    precio = 31000;
                    IngresoRestanteVAR = 8;
                    break;
                case "3":
                    precio = 32000;
                    IngresoRestanteVAR = 12;
                    break;
                case "4":
                    precio = 33000;
                    IngresoRestanteVAR = 16;    
                    break;
                case "5":
                    precio = 35000;
                    IngresoRestanteVAR = 20;
                    break;
                default:
                    precio = 0;
                    IngresoRestanteVAR = 0;
                    break;
            }

            txtCuotaMensual.Text = precio.ToString("N0"); // Muestra con separador de miles
            IngresoRestanteT.Text = IngresoRestanteVAR.ToString("N0"); // Muestra con separador de miles

        }

        private void txtCuotaMensual_TextChanged(object sender, EventArgs e)
        {
            // Aquí podrías agregar lógica para calcular la cuota mensual si es necesario, debo definir los precios en base al tipo de abono seleccionado (es mensual por defecto y dependiendo la cantidad de veces que quiero ir a la semana cambia el precio)

        }

        private void IngresoRestante_Click(object sender, EventArgs e)
        {
         //este no se usa
        }

        private void IngresoRestanteT_TextChanged(object sender, EventArgs e)
        {
            //hay que impedir que el usuario pueda escribir por encima del valor que tiene, ya que es un campo informativo
            this.ActiveControl = null;
            IngresoRestanteT.TabStop = false; // No permite foco con Tab
            
            IngresoRestanteT.ReadOnly = true;


            // ModeloPagos modeloPagos = new ModeloPagos();
            // int idCliente = SesionActual.UsuarioLogueado.Id;

            // // Obtener los ingresos restantes del usuario logueado desde la base de datos
            // Pagos pagoActual = modeloPagos.BuscarPago(idCliente);
            // int ingresosRestantesUsuario = pagoActual?.IngresosRestantesN ?? 0;

            // // Mostrar los ingresos restantes en el TextBox
            // IngresoRestanteT.Text = ingresosRestantesUsuario.ToString();


            // // Lo comentado se ignora
            // if (MisTurnosSemanalesCBX.SelectedItem == null) return;


            // switch (MisTurnosSemanalesCBX.SelectedItem.ToString())
            // {
            //     case "1":
            //         IngresoRestanteVAR = 8;
            //         break;
            //     case "2":
            //         IngresoRestanteVAR = 9;
            //         break;
            //     case "3":
            //         IngresoRestanteVAR = 10;
            //         break;
            //     case "4":
            //         IngresoRestanteVAR = 11;
            //         break;
            //     case "5":
            //         IngresoRestanteVAR = 12;
            //         break;
            //     default:
            //         IngresoRestanteVAR = 0;
            //         break;
            // }



        }

        private void MiFechaVencimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

        private void listaHorarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MiFechaVencimiento_TextChanged_1(object sender, EventArgs e)
        {
            MiFechaVencimiento.ReadOnly = true;
            this.ActiveControl = null;
            MiFechaVencimiento.TabStop = false; // No permite foco con Tab
            
        }

        private void MiFechaAbono_TextChanged(object sender, EventArgs e)
        {
            MiFechaAbono.ReadOnly = true;

            //ahora debemos impedir que el usuario pueda clickear por encima del text
            this.ActiveControl = null;
            MiFechaAbono.TabStop = false; // No permite foco con Tab
           
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

        /*if (segundosTrabajados < segundosIniciales) este es el original
        {
            segundosTrabajados++;
            TimeSpan tiempoRestante = TimeSpan.FromSeconds(segundosIniciales - segundosTrabajados);
            lblCronometro.Text = $"Tiempo restante: {tiempoRestante:hh\\:mm\\:ss}";
        }
        else
        {
            TurnoClienteTimer.Stop();
            MessageBox.Show("¡Tiempo finalizado!");
        }


    }

    private void FrmPrincipal_Load(object sender, EventArgs e)
    {
        TurnoClienteTimer.Stop();

    }*/
    }
}
