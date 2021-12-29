using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Logica
{
    public interface ILogicaCursos
    {
         void Agregar(Cursos c);
        Cursos Buscar(string cod);
        List<Cursos> Listar();
        void Modificar(Cursos c);
        void Eliminar(Cursos c); 


    }
}
