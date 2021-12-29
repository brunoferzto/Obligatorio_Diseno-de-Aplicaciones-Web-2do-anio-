using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class FabricaPersistencia
    {
        public static Inter_Empleado getPersistenciaEmpleado()
        {
            return (Per_Empleado.GetInstancia());
        }

        public static Inter_CurCorto getPersistenciaCursosCortos()
        {
            return (Per_CurCorto.GetInstancia());

        }
        public static Inter_CurEspe getPersistenciaCursoEspecializado()
        {
            return (Per_CurEspe.GetInstancia());
        }

        public static Inter_Sucursal getPersistenciaSucursal()
        {
            return (Per_Sucursual.GetInstancia());
        }

        public static Inter_Alumnos getPersistenciaAlumnos()
        {
            return (Per_Alumnos.GetInstancia());
        }
    }
}
