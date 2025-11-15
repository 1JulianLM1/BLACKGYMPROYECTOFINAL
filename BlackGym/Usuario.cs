using BlackGym;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGym
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string NumTel { get; set; }
        public int rol { get; set; }

        public Usuario() { }

        public Usuario(string un, string pass)
        {
            NombreUsuario = un;
            Contraseña = pass;
        }
        public Usuario(int rol) {
            this.rol = rol;
        }
    }

}
public  class SesionActual
{
    public static Usuario  UsuarioLogueado { get; set; }
}




