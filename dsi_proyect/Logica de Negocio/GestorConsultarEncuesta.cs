using dsi_proyect.Entities;
using dsi_proyect.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dsi_proyect.Logica_de_Negocio
{
    public class GestorConsultarEncuesta
    {

        private Llamada llamadaSeleccionada;
        private string nombreCliente;
        private DateTime periodoAFiltrar;
        private Estado estadoActual;
        private string datosRespuesta;
        // agregue este atributo
        private List<Encuesta> listaEncuestas;
        //private DataTable CrearTablaLlamada()
        //{
        //    DataTable table = new DataTable();
        //    table.Columns.Add("Numero de Llamada", typeof(int));
        //    table.Columns.Add("Fecha de Llamada", typeof(DateTime));

        //    table.Rows.Add(7654, DateTime.Parse("08/04/2023"));
        //    table.Rows.Add(7655, DateTime.Parse("08/05/2023"));
        //    table.Rows.Add(7673, DateTime.Parse("17/05/2023"));
        //    table.Rows.Add(7669, DateTime.Parse("09/05/2023"));
        //    table.Rows.Add(7666, DateTime.Parse("02/05/2023"));
        //    return table;
        //}

        public void nuevaConsulta()
        {
            
            Frm_ConsultarEncuesta consultarEncuesta = new Frm_ConsultarEncuesta();
            consultarEncuesta.ShowDialog();
        }

        public (DateTime, DateTime) tomarPeriodo(Frm_ConsultarEncuesta formulario)
        {
            DateTime fechaDesde = formulario.dateTimeDesde.Value;
            DateTime fechaHasta = formulario.dateTimeHasta.Value;
            
            return (fechaDesde,fechaHasta);
        }

        public DataTable buscarLlamada(Frm_ConsultarEncuesta formulario)
        {
            Test baseDatos = new Test();
            baseDatos.crearTodo();
            DateTime fechaDesde = this.tomarPeriodo(formulario).Item1;
            DateTime fechaHasta = this.tomarPeriodo(formulario).Item2;
            //aca trato como si hubiera una base de datos
            List<Llamada> listaLlamada = new List<Llamada>();
            listaLlamada.Add(baseDatos.llamada1);
            listaLlamada.Add(baseDatos.llamada2);
            listaLlamada.Add(baseDatos.llamada3);


            DataTable tablaFiltrada = new DataTable();
            tablaFiltrada.Columns.Add("Numero de Llamada", typeof(int));
            tablaFiltrada.Columns.Add("Fecha de Llamada", typeof(DateTime));

            foreach (Llamada call in listaLlamada)
            {
                // luego vemos lo de la encuesta respondida
                if (call.esDePeriodo(fechaDesde, fechaHasta) && call.tieneEncuestaRespondida())
                {
                    List<CambioEstado> cambioDeEstados = call.GetCambioEstados();
                    foreach (CambioEstado cambioEstado in cambioDeEstados)
                    {
                        if (cambioEstado.esEstadoInicial())
                        {
                            tablaFiltrada.Rows.Add(call.getNumeroLlamada(), cambioEstado.getfechaHoraInicio());
                            
                        }
                    }
                }

            }

            return tablaFiltrada;

        }
        /// <summary>
        /// //////////////////
        /// </summary>
        /// <returns></returns>
        //public DataTable RecuperarTodos()
        //{
        //    DataTable tablita = CrearTablaLlamada();
        //    return tablita;
        //}

        public Boolean ValidarFechas(DateTime fechaDesde , DateTime fechaHasta)
        {
            int resultado = DateTime.Compare(fechaDesde, fechaHasta);

            if (resultado > 0) { return false; }
            else { return true; }
        }


        public  DataTable RecuperarFiltrado(DateTime fechaDesde, DateTime fechaHasta, DataTable tablita)
        {
            DataTable tablaFiltrada = new DataTable();
            tablaFiltrada.Columns.Add("Numero de Llamada", typeof(int));
            tablaFiltrada.Columns.Add("Fecha de Llamada", typeof(DateTime));
           
            for (int i = 0; i < tablita.Rows.Count; i++)
            {
                // Supongamos que quieres agregar solo las filas donde la edad sea mayor a 25
                DateTime fecha = Convert.ToDateTime(tablita.Rows[i]["Fecha de Llamada"]);
                if (DateTime.Compare(fechaDesde, fecha) <= 0 && DateTime.Compare(fechaHasta, fecha) >= 0 )  
                {
                    tablaFiltrada.Rows.Add(tablita.Rows[i]["Numero de Llamada"], tablita.Rows[i]["Fecha de Llamada"]);
                    
                }
            } 
            return tablaFiltrada;
        }

        public void armarEncuesta(Encuesta encuestaEncontrada)
        {
            encuestaEncontrada.armarEncuesta();
        }
        public (string , string , string , string, string ) MostrarDatosRespuestas(int numLlamada, DateTime fecha)
        {
            Test test = new Test();
            test.crearTodo();
            listaEncuestas = new List<Encuesta>();
            listaEncuestas.Add(test.encuesta1);
            listaEncuestas.Add(test.encuesta2);


            Llamada llamada = buscarLlamada(numLlamada, fecha);
            string txtCliente = llamada.getNombreClienteLlamada();
            List<CambioEstado> listaCambioEstado = llamada.GetCambioEstados();

            string txtEstadoActual = llamada.getNombreEstadoActual();

            string txtDuracion= llamada.calcularDuracion().ToString();

            string txtRespuestas = llamada.getRespuestas().ToString();

            Encuesta encuestaEncontrada = this.buscarEncuesta(listaEncuestas, llamada);
            this.armarEncuesta(encuestaEncontrada);
            string txtPreguntas = encuestaEncontrada.getDescripcion();
                                                                                                                        
            return (txtCliente, txtEstadoActual, txtDuracion, txtRespuestas, txtPreguntas);
        }

        private Llamada buscarLlamada(int numLlamada, DateTime fecha)
        {
            Test test = new Test();
            test.crearTodo();
            foreach (Llamada llamada in test.listaLlamadas)
            {
                List<CambioEstado> cambioDeEstados = llamada.GetCambioEstados();
                foreach (CambioEstado cambioEstado in cambioDeEstados)
                {
                    if (cambioEstado.esEstadoInicial() && llamada.getNumeroLlamada() == numLlamada && cambioEstado.getfechaHoraInicio() == fecha)
                    {
                        return llamada;

                    }
                }
            }
            return null;
        }

        private Encuesta buscarEncuesta(List<Encuesta> listaEncuesta, Llamada llamada)
        {
            Boolean bandera = false;
            //recorro las Encuestas
            for (int i = 0; i< listaEncuesta.Count; i++)
            {   
                // Cada encuesta tiene una lista de preguntas
                List<Pregunta> listaPreguntas = listaEncuesta[i].getPreguntas();
                Boolean banderaAux = true;
                //Recorro la lista de preguntas
                for (int j= 0; j< listaPreguntas.Count; j++)
                {   
                    // Comparo cada pregunta con las Respuestas del cliente
                    List<RespuestaDeCliente> listaRtaCliente = llamada.getRespuestaEncuesta();
                    for (int s = 0; s< listaRtaCliente.Count; s++)
                    {

                        //Utilizo el metodo en la clase Preguntas, que me permite ver si las respuestas del cliente estaba dentro de las posibilidades
                        if (listaPreguntas[j].esDePregunta(llamada.getRespuestaEncuesta()[s].getDescripcionRta()) == false && s == llamada.getRespuestaEncuesta().Count - 1)
                        {   
                            // salir de aca significa que no estuvo
                            banderaAux = false;
                            break;
                        
                        }else if (listaPreguntas[j].esDePregunta(llamada.getRespuestaEncuesta()[s].getDescripcionRta()) )
                        {
                            ////    // si entro aca significa q recorrio toda las posibilidades
                            break;
                        }
                        // aca dio true pero no es la ultima pregunta de la encuesta, sigo iterando
                        //else if(listaPreguntas[j].esDePregunta(llamada.getRespuestaEncuesta()[s].getDescripcionRta()))
                        //{   
                        //    banderaEspecial = true;
                        //    break;
                        
                    }
                    if  (banderaAux == false) { break; }
                    if (listaPreguntas.Count - 1 == j) { bandera = true; }

                }
                if (bandera)
                {
                    return listaEncuesta[i];
                }
            }
            return null;
        }



    }
}
