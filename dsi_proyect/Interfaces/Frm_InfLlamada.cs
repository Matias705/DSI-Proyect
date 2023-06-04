using dsi_proyect.Entities;
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

namespace dsi_proyect.Interfaces
{
    public partial class Frm_InfLlamada : Form
    {
        public int numeroTelefono;
        public DateTime fecha;
        public Frm_InfLlamada()
        {
            InitializeComponent();
        }
        
        public void TomarDatos(int numero, DateTime fecha)
        {
            this.numeroTelefono = numero;
            this.fecha = fecha;
        }

        private void lbl_estado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Duracion_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Frm_InfLlamada_Load(object sender, EventArgs e)
        {
            GestorConsultarEncuesta gestor = new GestorConsultarEncuesta();
            (string txtCliente, string txtEstadoActual, string txtDuracion, string txtRespuestas, string txtPreguntas)  = gestor.MostrarDatosRespuestas(numeroTelefono, fecha);
            
            this.txtCliente.Text = txtCliente;
            this.txtEstadoActual.Text = txtEstadoActual;
            this.txtDuracion.Text = txtDuracion;
            this.txtRtaSeleccionadas.Text = txtRespuestas;
            this.txtDescripcionPreguntas.Text = txtPreguntas;
        }

        

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se imprimio la encuesta");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se genero exitosamente el CSV");
        }
    }
}
