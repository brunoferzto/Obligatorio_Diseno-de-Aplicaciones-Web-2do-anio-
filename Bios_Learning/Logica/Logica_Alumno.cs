using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCompartidas;
using Persistencia; 

namespace Logica
{
    internal class Logica_Alumno:ILogicaAlumno
    {

        private static Logica_Alumno _instancia = null;

        private Logica_Alumno() { }
        public static Logica_Alumno GetInstancia()
        {
            if (_instancia == null)
                _instancia = new Logica_Alumno();

            return _instancia;
        }

        public void Agregar (Alumnos e)
        {
            Inter_Alumnos intAlu = FabricaPersistencia.getPersistenciaAlumnos();
            intAlu.Agregar(e); 
        }

        public void Inscribir (Inscripcion i)
        {
            Inter_Alumnos intAlu = FabricaPersistencia.getPersistenciaAlumnos();
            intAlu.Inscripcion(i);
        }

        public Alumnos Buscar(int ced)
        {
            Inter_Alumnos intAlu = FabricaPersistencia.getPersistenciaAlumnos();
            return intAlu.Buscar(ced);
        }


    }
}
