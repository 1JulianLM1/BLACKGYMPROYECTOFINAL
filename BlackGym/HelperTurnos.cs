using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackGym
{
    public static class HelperTurnos
    {
        public static void CargarTurnosEnGrid(DataGridView dgv)
        {
            ModeloTurno modelo = new ModeloTurno();
            DataTable datos = modelo.obtenerTurno();
            dgv.DataSource = datos;
        }

    }
}
