using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

 namespace Persistencia
{
    public interface Inter_Sucursal
    {
        //Sucursales BuscarTodos(string sucu); //NUNCA SALE 
        Sucursales BuscarActivas(string sucu);
        void Eliminar(Sucursales s);
        void Modificar(Sucursales s);
        void Agregar(Sucursales S);
        List<Sucursales> Listar();
    }
}
