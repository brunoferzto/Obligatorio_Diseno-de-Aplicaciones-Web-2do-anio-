using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Persistencia
{
   public interface Inter_Alumnos
    {
        void Agregar(Alumnos alumno);
        Alumnos Buscar(int ced);
        void Inscripcion(Inscripcion ins);
    }
}
