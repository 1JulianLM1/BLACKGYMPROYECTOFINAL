using Guna.UI2.WinForms.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGym
{
    public class Turno
    {
        
        public string dia { get; set; }
        public string hora { get; set; }
        public int idUsuario { get; set; }

        public int idTurno { get; set; }

        public Turno() { }
        public Turno(string dia, string hora, int idUsuario, int idTurno) {
            this.dia = dia;
            this.hora = hora;
            this.idUsuario = idUsuario;
            this.idTurno = idTurno;
        }
    }
}
