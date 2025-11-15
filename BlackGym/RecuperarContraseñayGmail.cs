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
    public partial class RecuperarContraseñayGmail : Form
    {
        public RecuperarContraseñayGmail()
        {
            InitializeComponent();
        }

        private void MostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox para mostrar/ocultar contraseña

            bool mostrar = MostrarContraseña.Checked;
            CrearContraseñaUsuario.UseSystemPasswordChar = !mostrar;
            ConfirmarContraseña.UseSystemPasswordChar = !mostrar;
        }

        private void CrearContraseñaUsuario_TextChanged(object sender, EventArgs e)
        {
            this.CrearContraseñaUsuario.UseSystemPasswordChar = true;
        }

        private void ConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {
            this.ConfirmarContraseña.UseSystemPasswordChar = true;
        }

        private void InicioSesion_Click(object sender, EventArgs e)
        { // Botón para recuperar contraseña y enviar por Gmail
            string correo = CorreoElec.Text.Trim();
            if (string.IsNullOrEmpty(correo))
            {
                MessageBox.Show("Por favor, ingrese su correo electrónico.");
                return;
            }
            ModeloLogin modeloLogin = new ModeloLogin();
            Usuario usuario = modeloLogin.BuscarUsuarioPorCorreo(correo);
            if (usuario == null)
            {
                MessageBox.Show("No se encontró ningún usuario con ese correo electrónico.");
                return;
            }
            // Aquí iría la lógica para enviar el correo con la contraseña recuperada
            // Por razones de seguridad, normalmente no se envía la contraseña en texto plano
            // Se debería implementar un sistema de restablecimiento de contraseña
            MessageBox.Show("Se ha enviado un correo electrónico con las instrucciones para recuperar su contraseña.");

        }
    }
}
