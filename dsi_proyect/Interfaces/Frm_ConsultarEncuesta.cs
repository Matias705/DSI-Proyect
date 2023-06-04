using dsi_proyect.Logica_de_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsi_proyect.Interfaces
{
    public partial class Frm_ConsultarEncuesta : Form
    {
        
        public Frm_ConsultarEncuesta()
        {
            InitializeComponent();
            //GestorConsultarEncuesta gestor = new GestorConsultarEncuesta();

            //DataTable dt = new DataTable();
            //dt = gestor.RecuperarTodos();
            //CargarGrilla(dt);

        }

        private void CargarGrilla(DataTable tabla)
        {
            this.gridLlamadas.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                this.gridLlamadas.Rows.Add();
                this.gridLlamadas.Rows[i].Cells[0].Value = tabla.Rows[i]["Numero de Llamada"].ToString();
                this.gridLlamadas.Rows[i].Cells[1].Value = tabla.Rows[i]["Fecha de Llamada"].ToString();
                //aca queda terminar de sacar la hora.
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Filtrar_Click(object sender, EventArgs e)
        {
            //this.dateTimeDesde.Value.ToString());
            //DateTime fechaHasta = this.dateTimeHasta.Value;
            GestorConsultarEncuesta gestor = new GestorConsultarEncuesta();
            
            if (gestor.buscarLlamada(this).Rows.Count > 0) {
                CargarGrilla(gestor.buscarLlamada(this));
            }
            else
            {
                this.gridLlamadas.Rows.Clear();
                MessageBox.Show("No se encontro ninguna llamada en el rango seleccionado");
            }


        }

        private void gridLlamadas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow contenerdor = this.gridLlamadas.SelectedRows[0];
            Frm_InfLlamada informacionLlamada = new Frm_InfLlamada();
            informacionLlamada.TomarDatos(Convert.ToInt32(contenerdor.Cells["Column1"].Value.ToString()), Convert.ToDateTime(contenerdor.Cells["Column2"].Value.ToString()));
            informacionLlamada.ShowDialog();

            //Convert.ToInt32(contenerdor.Cells["Column1"].Value.ToString()), Convert.ToDateTime(contenerdor.Cells["Column2"].Value.ToString())
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
