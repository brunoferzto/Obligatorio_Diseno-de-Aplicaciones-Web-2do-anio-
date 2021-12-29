using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public class Cortos:Cursos
    {
        string area;

        public string Area
        {
            get { return area; }
            set {
                if (value != "Programación" && value != "Diseño" && value  != "Economía")
                    throw new Exception("No se ingresó un área válida");
                else
                    area = value; }
        }

        public Cortos (string area, string nom, string cod, int pre, int cupos, DateTime fechainicial, Sucursales sucu, Empleado emple)
            :base( nom,  cod,  pre,  cupos,  fechainicial,  sucu,  emple)
        {
            Area = area; 
        }

        public override string TipoCurso 
        {
            get { return ("Corto"); }
        }

    }
}
