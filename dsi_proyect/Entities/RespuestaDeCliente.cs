using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Entities
{
    public class RespuestaDeCliente
    {
        private DateTime fechaEncuesta;
        private RespuestaPosible rtaSeleccionada;

        public RespuestaDeCliente(DateTime fechaEncuesta, RespuestaPosible rtaSeleccionada)
        {
            this.fechaEncuesta = fechaEncuesta;
            this.rtaSeleccionada = rtaSeleccionada;
        }

        public string getDescripcionRta()
        {
            return this.rtaSeleccionada.getDescripcionRta();
            
        }
    }
}
