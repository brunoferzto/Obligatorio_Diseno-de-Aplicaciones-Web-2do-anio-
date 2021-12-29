using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Logica
{
   public class FabricaLogica
    {
        public static ILogicaSucursal getLogicaSucursal()
        {
            return (Logica_Sucursal.GetInstancia());
        }

        public static IlogicaEmpleado getLogicaEmpleado()
        {
            return (Logica_Empleado.GetInstancia());
        }

        public static ILogicaAlumno getLogicaAlumno()
        {
            return (Logica_Alumno.GetInstancia());
        }

        public static ILogicaCursos getLogicaCursos()
        {
            return (Logica_Cursos.GetInstancia());
        }
    }
}
