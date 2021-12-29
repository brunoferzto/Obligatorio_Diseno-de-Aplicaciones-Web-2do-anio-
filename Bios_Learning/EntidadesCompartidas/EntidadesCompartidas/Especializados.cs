using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public class Especializados:Cursos
    {
        int duracion;

        public int Duracion 
        {
            get { return duracion; }
            set {
                if (value <= 0)
                    throw new Exception("Ingrese correctamente la duración del curso");
                else
                    duracion = value; }
        }

        public Especializados (int duraci, string nom, string cod, int pre, int cupos, DateTime fechainicial, Sucursales sucu, Empleado emple)
            :base( nom,  cod,  pre,  cupos,  fechainicial,  sucu,  emple)
        {
            Duracion = duraci; 
        }

        public override string TipoCurso
        {
            get { return ("Especializado"); }
        }

    }
    
    
}
