using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackGym
{
    public class Pagos
    {
        public int IdPago { get; set; }
        public int IdCliente { get; set; }
        public DateTime Fecha_Pago { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }

        public int ImportePago { get; set; } 

        public int IngresosRestantesN { get; set; }

    }
    public class SesionActualPago
    {
        public static Pagos PagoUsuarioLogueado { get; set; }
    }
}
