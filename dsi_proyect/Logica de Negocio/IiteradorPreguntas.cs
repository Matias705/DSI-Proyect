using dsi_proyect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Logica_de_Negocio
{
    internal class IiteradorPreguntas : IIterador
    {

        private int actual;
        private List<Pregunta> preguntas;

        public IiteradorPreguntas(List<Pregunta> preguntas)
        {
            this.preguntas = preguntas;
        }

        object IIterador.actual()
        {
            return preguntas[actual];
        }

        bool IIterador.cumpleFiltro(DateTime fechaInicioPeriodo, DateTime fechaFinPerido, Llamada llamada)
        {
            return false;
        }

        bool IIterador.haTerminado()
        {
            if (preguntas.Count() == actual + 1)
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
            actual+=1;
        }
    }
}
