using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Entities
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private uint nroCelular;

        public Cliente(int dni, string nombreCompleto, uint nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }

        public string getNombre()
        {
            return nombreCompleto;
        }

    }
    
}
