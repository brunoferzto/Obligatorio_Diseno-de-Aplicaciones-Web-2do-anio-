using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas; 

namespace Persistencia
{
  public interface Inter_CurEspe
    {
        void Agregar(Especializados Un_Curso);

        void Eliminar(Especializados Un_Curso);

        void Modificar(Especializados Un_Curso);

        List<Especializados> Listar();

        Especializados Buscar(string cod);


    }
}
