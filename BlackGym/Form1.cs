using Org.BouncyCastle.Pqc.Crypto.Lms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BlackGym.ADMINISTRADOR;

namespace BlackGym
{
    public partial class Form1 : Form
    {
        Usuario usuariologin;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Registro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            registroUsuario.Show();
            this.Hide(); // Ocultar el formulario actual (Form1)

        }

        private void InicioSesion_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener datos de los TextBox
                string usuario = NombreUsuario.Text.Trim();
                string pass = ContraseñaUsuario.Text.Trim();

                // Crear objeto Usuario
                ModeloLogin modeloLogin = new ModeloLogin();
                Usuario usuarioBD = modeloLogin.BuscarUsuario(new Usuario { NombreUsuario = usuario });

                if (usuarioBD == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Generar el hash de la contraseña ingresada
                HashPassword hashPassword = new HashPassword();
                string hashIngresado = hashPassword.generarEncriptacionSHA1(pass);

                // Comparar el hash ingresado con el almacenado
                if (hashIngresado != usuarioBD.Contraseña)
                {
                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Redirigir según el rol del usuario
                switch (usuarioBD.rol)
                {
                    case 1: // Administrador
                        MessageBox.Show("¡Bienvenido! ADMIN", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ADMINISTRADOR adminForm = new ADMINISTRADOR();
                        this.Hide();
                        adminForm.Show();
                        break;
                    case 2: // Cliente
                        MessageBox.Show("¡Bienvenido! Cliente", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmPrincipal clienteForm = new FrmPrincipal(usuarioBD);
                        SesionActual.UsuarioLogueado = usuarioBD;
                        this.Hide();
                        clienteForm.Show();
                        break;
                    case 3: // Recepcionista
                        MessageBox.Show("¡Bienvenido! Recepcionista", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Recepcion recepcionForm = new Recepcion();
                        this.Hide();
                        recepcionForm.Show();
                        break;
                    case 4: // Entrenador
                        MessageBox.Show("¡Bienvenido! Entrenador", "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmPrincipal entrenadorForm = new FrmPrincipal(usuarioBD);
                        SesionActual.UsuarioLogueado = usuarioBD;
                        this.Hide();
                        entrenadorForm.Show();
                        break;
                    default:
                        MessageBox.Show("Rol no reconocido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el inicio de sesión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //try
            //{
            //    // Obtener datos de los TextBox

            //    string usuario = NombreUsuario.Text.Trim();
            //    string pass = ContraseñaUsuario.Text.Trim();
            //    // Crear objeto Usuario
            //    usuariologin = new Usuario(usuario, pass);
            //    ModeloLogin modeloLogin = new ModeloLogin();
            //    Usuario usuarioBD = modeloLogin.BuscarUsuario(new Usuario { NombreUsuario = usuario });


            //    ModeloLogin u = new ModeloLogin();
            //    var RolUsado = u.BuscarUsuario(usuariologin);




            //    // Validar usuario con ControlLogin
            //    ControlLogin control = new ControlLogin();
            //    usuariologin = control.UsuarioValido(usuariologin);

            //    if (usuariologin != null && RolUsado.rol==3) // el 3 es Recepcionista
            //    {
            //        MessageBox.Show("¡Bienvenido! Recepcionistas", "Inicio de Sesión",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        // usuarioEncontrado es el que validaste desde la DB
            //        Recepcion p = new Recepcion();
            //        this.Hide(); // Oculta el formulario actual
            //        p.Show();
            //    }

            //    else
            //    {
            //        if(usuariologin != null && RolUsado.rol== 1) // el 1 es ADMIN
            //        {
            //            MessageBox.Show("¡Bienvenido! ADMIN", "Inicio de Sesión",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            // Muestra el formulario principal
            //            ADMINISTRADOR p = new ADMINISTRADOR();
            //            this.Hide(); // Oculta el formulario actual
            //            p.Show();

            //        }
            //        else

            //        if (usuariologin != null && RolUsado.rol == 2) // el 2 es Cliente
            //        {
            //            MessageBox.Show("¡Bienvenido! cliente", "Inicio de Sesión",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            FrmPrincipal p = new FrmPrincipal(usuariologin);
            //            SesionActual.UsuarioLogueado = usuariologin;
            //            this.Hide(); // Oculta el formulario actual
            //            p.Show();    // Muestra el formulario principal


            //        }
            //        else

            //        if (usuariologin != null && RolUsado.rol == 4) // el 4 es Entrenador
            //        {
            //            MessageBox.Show("¡Bienvenido! Entrenador", "Inicio de Sesión",
            //            MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            FrmPrincipal p = new FrmPrincipal(usuariologin); // USO NUEVO FORM PARA CONTAR LAS HORAS TRABAJADAS
            //            SesionActual.UsuarioLogueado = usuariologin;
            //            this.Hide(); // Oculta el formulario actual
            //            p.Show();    // Muestra el formulario principal


            //        }

            //        else
            //        {
            //            MessageBox.Show("Usuario / Password inválido. Revise los datos solicitados.",
            //           "Inicio de Sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //            // Devolver el foco al campo vacío o al de contraseña
            //            if (string.IsNullOrEmpty(NombreUsuario.Text))
            //                NombreUsuario.Focus();
            //            else
            //                ContraseñaUsuario.Focus();
            //        }



            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error en el inicio de sesión: " + ex.Message,
            //        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
            
        private void NombreUsuario_TextChanged(object sender, EventArgs e)
        {
          //  string nombreUsuario = NombreUsuario.Text;
        }

        private void ContraseñaUsuario_TextChanged(object sender, EventArgs e)
        {
            this.ContraseñaUsuario.UseSystemPasswordChar = true;

            //   string contraseñaUsuario = ContraseñaUsuario.Text;
        }

        private void SalirPrograma_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario registroUsuario = new RegistroUsuario();
            
            registroUsuario.Show();
            this.Hide(); // Ocultar el formulario actual (Form1)

        }

        private void MostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
          


            bool mostrar = MostrarContraseña.Checked;
            ContraseñaUsuario.UseSystemPasswordChar = !mostrar;

        }

    }
}