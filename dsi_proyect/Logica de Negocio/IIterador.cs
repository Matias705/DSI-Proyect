using dsi_proyect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Logica_de_Negocio
{
    public interface IIterador
    {
        Object actual();
        Boolean haTerminado();
        void primero();
        void siguiente();
        Boolean cumpleFiltro(DateTime fechaInicioPeriodo, DateTime fechaFinPerido, Llamada llamada);
    }
}
