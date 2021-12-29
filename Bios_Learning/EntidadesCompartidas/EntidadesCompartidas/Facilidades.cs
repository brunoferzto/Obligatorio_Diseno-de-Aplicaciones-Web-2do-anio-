using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesCompartidas
{
   public class Facilidades
    {
        private string facilidad; 

        public string Facilidad
        {
            get { return facilidad; }
            set
            {
                if (value == null || value.Length > 30)
                    throw new Exception("Se debe ingresar un nombre para la Facilidad"); 
                else
                facilidad = value;
            }        
        }
        public Facilidades (string fac)
        {
            Facilidad = fac; 

        }
    }
}
