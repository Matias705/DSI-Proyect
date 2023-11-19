using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Logica_de_Negocio
{
    public interface IAgregado
    {
        IIterador crearIterador(Object[] elementos);
    }
}
