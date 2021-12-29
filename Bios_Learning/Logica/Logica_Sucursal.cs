using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia; 

namespace Logica
{
   internal class Logica_Sucursal:ILogicaSucursal 
    {
  
            private static Logica_Sucursal _instancia = null;

            private Logica_Sucursal () { }
            public static Logica_Sucursal GetInstancia()
            {
                if (_instancia == null)
                    _instancia = new Logica_Sucursal();

                return _instancia;
            }

        public void Agregar(Sucursales s)
        {
            Inter_Sucursal intSucu = FabricaPersistencia.getPersistenciaSucursal(); 
            intSucu.Agregar(s);
        }

        public void Eliminar (Sucursales s)
        {
            Inter_Sucursal intSucu = FabricaPersistencia.getPersistenciaSucursal();
            intSucu.Eliminar(s); 

        }

        public void Modificar (Sucursales s)
        {
            Inter_Sucursal intSucu = FabricaPersistencia.getPersistenciaSucursal();
            intSucu.Modificar(s);
        }

        public Sucursales Buscar (string sucu)
        {
            Inter_Sucursal intSucu = FabricaPersistencia.getPersistenciaSucursal();
           return intSucu.BuscarActivas(sucu);

        }

        public List<Sucursales> Listar()
        {
            Inter_Sucursal intSucu = FabricaPersistencia.getPersistenciaSucursal();
            return intSucu.Listar(); 
        }

    

    
    }
}

