using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia; 

namespace Logica
{
  internal class Logica_Empleado:IlogicaEmpleado
    {
        private static Logica_Empleado _instancia = null;
        
        private Logica_Empleado() { }
        public static Logica_Empleado GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Logica_Empleado();

            return _instancia;
        }
        
        public void Agregar (Empleado e)
        {

            Inter_Empleado intEmp = FabricaPersistencia.getPersistenciaEmpleado();
            intEmp.Registrar(e); 
        }

        public Empleado Buscar (string nUSU)
        {
            Inter_Empleado intEmp = FabricaPersistencia.getPersistenciaEmpleado();
            return intEmp.BuscarActivo(nUSU); 
        }

        public void Modificar (Empleado e)
        {
            Inter_Empleado intEmp = FabricaPersistencia.getPersistenciaEmpleado();
            intEmp.Modificar(e); 
        }

        public Empleado Logueo (Empleado e)
        {
            Inter_Empleado intEmp = FabricaPersistencia.getPersistenciaEmpleado();
           return intEmp.Logueo(e);
        }

        public void Eliminar (Empleado e)
        {
            Inter_Empleado intEmp = FabricaPersistencia.getPersistenciaEmpleado();
            intEmp.Eliminar(e); 
        }
        public List<Empleado> Listar ()
        {
            Inter_Empleado intEmp = FabricaPersistencia.getPersistenciaEmpleado();
            return intEmp.Listar(); 
        }


    }
}
