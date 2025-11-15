using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace BlackGym
{
    public class ControlLogin
    {
        public ControlLogin() { }


      /*private string GenerarEncriptacionSHA1(string cadena)
        {
            
        } */ 
        public Usuario UsuarioValido(Usuario u)
        {
            ModeloLogin m = new ModeloLogin();

            if (string.IsNullOrEmpty(u.NombreUsuario) || string.IsNullOrEmpty(u.Contraseña))
                return null;

            // Buscar en la BD
            Usuario usuarioEncontrado = m.BuscarUsuario(u);

            if (usuarioEncontrado != null)
            {
                HashPassword hashPassword = new HashPassword();
                string hashIngresado = hashPassword.generarEncriptacionSHA1(u.Contraseña);
                Console.WriteLine(hashIngresado);
                Console.WriteLine("a");
                Console.WriteLine(usuarioEncontrado.Contraseña);
               
                // Comparar hash ingresado con el hash guardado en BD
                if (usuarioEncontrado.Contraseña == hashIngresado) //EL PROBLEMA ES QUE COMPARAMOS CONTRASEÑA ENCRIPTADA DEL USUARIO QUE VIENE POR PARAMETRO CON LA CONTRASEÑA NORMAL DEL USUARIO QUE ENCONTRE
                    return usuarioEncontrado;
            }

            return usuarioEncontrado;
        }



    }
}


