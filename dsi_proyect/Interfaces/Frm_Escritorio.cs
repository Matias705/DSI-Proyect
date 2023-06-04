using dsi_proyect.Interfaces;
using dsi_proyect.Logica_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsi_proyect
{
    public partial class Frm_Escritorio : Form
    {
        public Frm_Escritorio()
        {
            InitializeComponent();
        }

        private void consultarEncuestaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Frm_ConsultarEncuesta consultarEncuesta = new Frm_ConsultarEncuesta();
            //consultarEncuesta.ShowDialog();
            GestorConsultarEncuesta gestor = new GestorConsultarEncuesta();
            gestor.nuevaConsulta();
        }
    }
}
