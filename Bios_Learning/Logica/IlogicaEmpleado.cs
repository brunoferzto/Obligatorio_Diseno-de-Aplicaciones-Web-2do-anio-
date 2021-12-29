using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Logica
{
   public interface IlogicaEmpleado
    {
        void Agregar(Empleado e);

        Empleado Buscar(string nUSU);

        void Modificar(Empleado e);

        Empleado Logueo(Empleado e);

        void Eliminar(Empleado e);

        List<Empleado> Listar(); 
    }
}
