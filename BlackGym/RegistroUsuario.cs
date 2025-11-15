using BlackGym;
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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InicioSesion_Click(object sender, EventArgs e)
        {
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
        }

        private void CrearContraseñaUsuario_TextChanged(object sender, EventArgs e)
        {
            this.CrearContraseñaUsuario.UseSystemPasswordChar = true;



        }

        private void MostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            

            
        }

        private void ConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CorreoElec_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void NumeroTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {
            //MostrarContraseña
            //CorreoElec
            //NumeroTelefono
            //InicioSesion
            //BotonSalir
        }

        private void ConfirmarContraseña_TextChanged_1(object sender, EventArgs e)
        {
            this.ConfirmarContraseña.UseSystemPasswordChar = true;
        }

        private void InicioSesion_Click_1(object sender, EventArgs e)
        {

            string nombre = CrearNombreUsuario.Text.Trim();
            string contraseña = CrearContraseñaUsuario.Text.Trim();
            string contraseñaConfirm = ConfirmarContraseña.Text.Trim();
            string correo = CorreoElec.Text.Trim();
            string telefono = NumeroTelefono.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(contraseña) ||
                string.IsNullOrEmpty(contraseñaConfirm) || string.IsNullOrEmpty(correo) ||
                string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Rellenar todos los campos");
                return;
            }

            if (contraseña != contraseñaConfirm)
            {
                MessageBox.Show("Las contraseñas no coinciden");
                return;
            }

            // Usuario con contraseña en texto plano (el modelo la encripta)
            Usuario usuario = new Usuario()
            {
                NombreUsuario = nombre,
                Correo = correo,
                Contraseña = contraseña, // texto plano
                NumTel = telefono,
            };

            ModeloLogin modelo = new ModeloLogin();
            bool resultado = modelo.RegistroUsuario(usuario);

            if (resultado)
            {
                MessageBox.Show("Usuario registrado con éxito");
                this.Close();
                // Redirigir al formulario de inicio de sesión
                Form1 loginForm = new Form1();
                this.Hide(); // Ocultar el formulario actual
                loginForm.Show(); // Mostrar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario");
            }
        }

        private void BotonSalir_Click_1(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }
        

        private void CrearNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void CorreoElec_TextChanged_1(object sender, EventArgs e)
        {
            string correo = CorreoElec.Text.Trim();
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Expresión regular para validar correos

            if (!System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo))
            {
                CorreoElec.BackColor = Color.LightCoral; // Cambiar el fondo a rojo si es inválido
            }
            else
            {
                CorreoElec.BackColor = Color.White; // Restaurar el fondo si es válido
            }
        }

        private void NumeroTelefono_TextChanged_1(object sender, EventArgs e)
        {
            string telefono = NumeroTelefono.Text.Trim();
            string patronTelefono = @"^\d{10}$"; // Expresión regular para validar 10 dígitos

            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, patronTelefono))
            {
                NumeroTelefono.BackColor = Color.LightCoral; // Cambiar el fondo a rojo si es inválido
            }
            else
            {
                NumeroTelefono.BackColor = Color.White; // Restaurar el fondo si es válido
            }
        }

        private void MostrarContraseña_CheckedChanged_1(object sender, EventArgs e)
        {
            bool mostrar = MostrarContraseña.Checked;
            CrearContraseñaUsuario.UseSystemPasswordChar = !mostrar;
            ConfirmarContraseña.UseSystemPasswordChar = !mostrar;
        }
    }
}




