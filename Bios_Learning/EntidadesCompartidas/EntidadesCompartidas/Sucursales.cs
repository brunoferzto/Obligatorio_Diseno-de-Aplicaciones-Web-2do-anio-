using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
    public class Sucursales
    {
        string nombre;
        string direccion;
        List<string> facilidades;


        public List<string> Facilidad
        {
            get { return facilidades; }
            set { if(value == null )
                    throw new Exception("Debe ingresarse la Facilidad de la sucursal");
            else
                facilidades = value; }
        }


    public string Nombre
        {
            get { return nombre; }
            set {
                if(value == null || value.ToString().Length == 0 || value.Length > 40)
                    throw new Exception("Error en nombre de la Sucursal");
                else
                nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set {
                if (value == null ||  value.ToString().Length == 0)
                    throw new Exception("Debe ingresar la dirección de la Sucursal");
                else
                    direccion = value; }
        }
       
      

        public Sucursales(string nom, string dire, List<string> lista)
        {
            Nombre = nom;
            Direccion = dire;
            Facilidad = lista;
        }

    
    }
}
