using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Logica
{
   public interface ILogicaSucursal
    {
        void Agregar(Sucursales s);

        void Eliminar(Sucursales s);

        void Modificar(Sucursales s);

        Sucursales Buscar(string sucu);

        List<Sucursales> Listar();
    }
}
