using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Entities
{
    public class Estado
    {
        private string nombre;

        // iniciada, finaliza, descartada, controlada
        // enum

        public Estado()
        {

        }

        public Estado(string nombreNuevo)
        {
           nombre = nombreNuevo;
        }

        public Boolean esFinalizada()
        {
            if (this.getNombre() == "Finalizada")
            {
                return true;
            }
            return false;

        }
        

        public Boolean esIniciada()
        {
            if (this.getNombre() == "Iniciada")
            {
                return true;
            }
            return false;
        }

        public string getNombre ()
        {
            return nombre;
        }

        public void setNombre (string nuevoNombre)
        {
            this.nombre = nuevoNombre;
 
        }
    }
}
