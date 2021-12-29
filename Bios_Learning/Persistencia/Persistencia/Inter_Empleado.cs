using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Persistencia
{
    public interface Inter_Empleado
    {
        Empleado BuscarActivo(string Usu);

        void Registrar(Empleado e);

        void Modificar(Empleado e);

        Empleado Logueo(Empleado e);

        List<Empleado> Listar();

        void Eliminar(Empleado emp); 
    }
}
