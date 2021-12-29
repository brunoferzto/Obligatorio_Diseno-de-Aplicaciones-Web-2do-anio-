using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public class Alumnos
    {
        int cedula, telefono;
        string nombre;

        public int Telefono
        {
            get { return telefono; }
            set {
                if (Convert.ToString(value).Length != 8)
                    throw new Exception("El teléfono debe tener al menos 8 caracteres");

                telefono = value; }
        }
        public int Cedula
        {
            get { return cedula; }
            set {
                if (Convert.ToString(value).Length != 8)
                    throw new Exception("La cédula debe tener 8 caracteres");
                else
                    cedula = value;
            }
        }
        public string Nombre
        {
            get { return nombre; }
            set {
                if (value == null || value.Length > 20)
                    throw new Exception("Error en Nombre");


                else
                    nombre = value; }
        }

        public Alumnos (string nom, int ced, int tele)
        {
            Nombre = nom;
            Cedula = ced;
            Telefono = tele; 

        }
    }
}
