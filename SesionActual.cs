using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcaRH
{
    public static class SesionActual
    {
        public static int IdUsuario { get; set; } // Identificador del usuario
        public static int CodigoEmpleado { get; set; } // Código del empleado asociado
        public static string Rol { get; set; } // Rol del usuario (Gerente o Empleado)
    }
}
