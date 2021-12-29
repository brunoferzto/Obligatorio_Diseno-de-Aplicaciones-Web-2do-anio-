using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public abstract class Cursos
    {
        
        string nombre, codigo;
        int  cupos, costo; 
        DateTime fechainicio;
        Sucursales local;
        Empleado emple;

        public Empleado Empleados
        {
            get { return emple; }
            set {
                if (value == null)
                    throw new Exception("Se necesita Empleado"); 
                else
                emple = value; }
        }
        public Sucursales Local
        {
            get { return local; }
            set {
               if (value == null)
                    throw new Exception("Se necesita una Sucursal para dictar el Curso");
               else
                local = value; }
        }

        public DateTime Fecha_Inicio
        {
            get { return fechainicio; }
            set {fechainicio = value; }
        }

        public int Cupos
        {
            get { return cupos; }
            set {
                if(value <= 0)
                    throw new Exception("Valor no válido");
                else
                cupos = value; }
        }

        public int Costo
        {
            get { return costo; }
            set {
                if (value <= 0)
                    throw new Exception("Valor no válido");
                else
                costo = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set {
                if (value == null || value.Length > 40)
                    throw new Exception("Error en el 'Nombre de Curso'");
                else
                nombre = value; }
        }

        public string Codigo 
        {
            get { return codigo; }
            set {
                if (!(value.Length == 5) || (!(value.Substring(3).All(char.IsNumber) &&
                    (value.Substring(4).All(char.IsNumber)))))                
                    throw new Exception("Código Incorrecto, Formato Código (LLL/NN)");

                else
                    codigo = value; }
        }

        public Cursos (string nom, string cod, int pre, int cupos, DateTime fechainicial,Sucursales sucu, Empleado emple)
        {
            Nombre = nom;
            Codigo = cod;
            Costo = pre;
            Cupos = cupos;
            Fecha_Inicio = fechainicial;
            Local = sucu;
            Empleados = emple; 

        }

        public virtual string TipoCurso
        {
            get { return ("Clase Base"); }
        }

    }
}
