using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Entities
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estadoLlamada;


        public CambioEstado()
        {

        }

        public CambioEstado(DateTime fechaHoraInicio, Estado estadoLlamada)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estadoLlamada = estadoLlamada;
        }

        public Boolean esEstadoInicial()
        {
            if (estadoLlamada.esIniciada(estadoLlamada)) //preguntar esto
            { 
                return true;
            }
            return false;
        }

        public Boolean esEstadoFinalizado()
        {
            if (estadoLlamada.esFinalizada()) //preguntar esto
            {
                return true;
            }
            return false;
        }

        public Boolean esUltimoEstado(List<CambioEstado> listaCambioEstado)
        {

            for (int i = 0; i < listaCambioEstado.Count; i++)
            {
                CambioEstado objeto = listaCambioEstado[i];
                if (DateTime.Compare(this.getfechaHoraInicio(), objeto.getfechaHoraInicio()) < 0)
                {
                    estadoLlamada.setNombre(listaCambioEstado[i].getNombreEstado());
                    //return true;
                }

            }
            return true;

        }

        public DateTime getfechaHoraInicio()
        {
            return fechaHoraInicio;
        }

        public string getNombreEstado()
        {
            return estadoLlamada.getNombre();
        }


    }
}
