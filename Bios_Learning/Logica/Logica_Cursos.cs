using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia; 

namespace Logica
{
   internal class Logica_Cursos:ILogicaCursos
    {
        private static Logica_Cursos _instancia = null;

        private Logica_Cursos() { }
        public static Logica_Cursos GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Logica_Cursos();

            return _instancia;
        }

        public void Agregar (Cursos c)
        {
            if (c is Especializados)
            {
                Inter_CurEspe intCEs = FabricaPersistencia.getPersistenciaCursoEspecializado();
                intCEs.Agregar((Especializados)c);
            }
            else
            {
                Inter_CurCorto intCco = FabricaPersistencia.getPersistenciaCursosCortos();
                intCco.Agregar((Cortos)c); 
            }

        }

        public Cursos Buscar (string cod)
        {
            Cursos c = null;
            Inter_CurCorto intCco = FabricaPersistencia.getPersistenciaCursosCortos();
            c = intCco.Buscar(cod); 
            if (c == null)
            {
                Inter_CurEspe intCEs = FabricaPersistencia.getPersistenciaCursoEspecializado();
                c = intCEs.Buscar(cod); 
            }

            return c; 
        }

        public List<Cursos> Listar ()
        {
            List<Cursos> listilla = new List<Cursos>();

            listilla.AddRange(FabricaPersistencia.getPersistenciaCursosCortos().Listar());
            listilla.AddRange(FabricaPersistencia.getPersistenciaCursoEspecializado().Listar());
            
            

            return listilla; 
 

        } 

        public void Modificar (Cursos c)
        {
            if (c is Cortos)
            {
                Inter_CurCorto intCco = FabricaPersistencia.getPersistenciaCursosCortos();
                intCco.Modificar((Cortos)c);
            }
            else
            {
                Inter_CurEspe intCEs = FabricaPersistencia.getPersistenciaCursoEspecializado();
                intCEs.Modificar((Especializados)c); 
            }
        }

        public void Eliminar (Cursos c)
        {
            if (c is Cortos)
            {
                Inter_CurCorto intCco = FabricaPersistencia.getPersistenciaCursosCortos();
                intCco.Eliminar((Cortos)c);
            }
            else
            {
                Inter_CurEspe intCEs = FabricaPersistencia.getPersistenciaCursoEspecializado();
                intCEs.Eliminar((Especializados)c);
            }
        }

    }
}
