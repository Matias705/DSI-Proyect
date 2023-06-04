using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Entities
{
    public class RespuestaPosible
    {
        private string descripcion;
        private int valor;

        public RespuestaPosible(string descripcion, int valor)
        {
            this.descripcion = descripcion;
            this.valor = valor;         
        }

        public string getDescripcionRta()
        {
            return descripcion;
        }

       
    }

    
}
