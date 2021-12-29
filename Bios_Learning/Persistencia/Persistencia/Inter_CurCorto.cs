using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Persistencia
{
   public interface Inter_CurCorto //recordar q esta la hice como clase normal (x posible error)
    {
        Cortos Buscar(string cod);

        List<Cortos> Listar();

        void Eliminar(Cortos Un_Curso);

        void Modificar(Cortos Un_Curso);

        void Agregar(Cortos Un_Curso);


    }
}
