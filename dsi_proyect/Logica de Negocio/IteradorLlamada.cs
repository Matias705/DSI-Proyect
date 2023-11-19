using dsi_proyect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Logica_de_Negocio
{
    public class IteradorLlamada : IIterador
    {

        private int actual;
        private List<Llamada> llamadas;

        public IteradorLlamada(List<Llamada> llamadas)
        {
            this.llamadas = llamadas;
        }

        object IIterador.actual()
        {
            return llamadas[actual];
        }

        bool IIterador.cumpleFiltro(DateTime fechaInicioPeriodo, DateTime fechaFinPerido, Llamada llamada)
        {
            return (llamada.esDePeriodo(fechaInicioPeriodo, fechaFinPerido).Item1 && llamada.tieneEncuestaRespondida());
        }

        bool IIterador.haTerminado()
        {
            if (llamadas.Count() == actual + 1)
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
