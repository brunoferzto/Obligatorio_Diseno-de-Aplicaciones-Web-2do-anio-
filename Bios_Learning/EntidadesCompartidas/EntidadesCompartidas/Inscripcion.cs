using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public class Inscripcion
    {
        DateTime fechainscr;
        Alumnos alu;
        Cursos curso;

        public DateTime Fecha
        {
            get { return fechainscr; }
            set {fechainscr = value; }
        }
        public Alumnos Alumno
        {
            get { return alu; }
            set {
                if (value == null)
                  throw new Exception("Debe ingresar el Alumno"); 

                else
                 alu = value; }
        }
        public Cursos Curso
        {
            get { return curso; }
            set {
                if(value == null)
                  throw new Exception("Debe ingresar el Curso");
                else
                curso = value; }
        }

        public Inscripcion (Alumnos aluno, DateTime fecha, Cursos curs)
        {
            Alumno = aluno;
            Curso = curs;
            Fecha = fecha; 
        }

    }
}
