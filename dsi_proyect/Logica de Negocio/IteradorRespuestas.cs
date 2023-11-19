using dsi_proyect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Logica_de_Negocio
{
    internal class IteradorRespuestas : IIterador
    {
        private int actual;
        private List<RespuestaDeCliente> respuestas;

        public IteradorRespuestas(List<RespuestaDeCliente> respuestas)
        {
            this.respuestas = respuestas;
        }

        object IIterador.actual()
        {
            return respuestas[actual];
        }

        bool IIterador.cumpleFiltro(DateTime fechaInicioPeriodo, DateTime fechaFinPerido, Llamada llamada)
        {
            return true;
        }

        bool IIterador.haTerminado()
        {
            if (respuestas.Count() == actual + 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IIterador.primero()
        {
            actual = 0;
        }

        void IIterador.siguiente()
        {
            actual += 1;
        }
    }
}
