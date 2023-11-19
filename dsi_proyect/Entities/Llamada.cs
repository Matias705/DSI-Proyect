using dsi_proyect.Logica_de_Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsi_proyect.Entities
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private int duracion;
        private Boolean encuestaEnviada;
        private string observacionAuditor;
        private Cliente cliente;
        private List<CambioEstado> cambioEstado;
        private List<RespuestaDeCliente> respuestasEncuesta;
        private int numeroLlamada;

        public Llamada(string descripcionOperador, string detalleAccionRequerida, int duracion, bool encuestaEnviada, string observacionAuditor, Cliente cliente, List<CambioEstado> cambioEstado, List<RespuestaDeCliente> respuestasEncuesta, int numeroLlamada )
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.cliente = cliente;
            this.cambioEstado = cambioEstado;
            this.respuestasEncuesta = respuestasEncuesta;
            this.numeroLlamada = numeroLlamada;
            
        }

        public List<RespuestaDeCliente> getRespuestaEncuesta()
        {
            return respuestasEncuesta;
        }
        public List<CambioEstado> GetCambioEstados()
        {
            return cambioEstado;
        }
        public int getNumeroLlamada()
        {
            return numeroLlamada;
        }
        public int getDuracion()
        {

            return duracion;
        }

        public (Boolean,DateTime) esDePeriodo(DateTime fechaDesde, DateTime fechaHasta)
        {

            foreach (CambioEstado cambioEstadoLlamada in cambioEstado)
            {
                if (cambioEstadoLlamada.esEstadoInicial())
                {
                    DateTime fechaInicioObtenida = cambioEstadoLlamada.getfechaHoraInicio();
                    //MessageBox.Show("ENTRO");
                    if (DateTime.Compare(fechaDesde, fechaInicioObtenida) <= 0 && DateTime.Compare(fechaInicioObtenida, fechaHasta) <= 0)
                    {
                        
                        return (true, fechaInicioObtenida);
                    }
                }   

            }
            return (false, DateTime.MaxValue);
        }

        public Boolean tieneEncuestaRespondida()
        {
            if(respuestasEncuesta != null)
            {
                return true;
            }
            return false;
        }

        public string getNombreClienteLlamada()
        {
            return cliente.getNombre();
        }

        public string getNombreEstadoActual()
        {
            //esultimocabiodeestado()
            int i = 0;
            while (!(cambioEstado[i].esUltimoEstado(cambioEstado)))
            {   
                i++;

            }
            return cambioEstado[i].getNombreEstado();

            //foreach (CambioEstado item in cambioEstado)
            //{
            //    if (item.esUltimoEstado(cambioEstado))
            //    {
            //        return item.getNombreEstado();
            //    }
            //    else { continue; }
            //}
            //return "error";
        }
        public double calcularDuracion() 
        {
            DateTime var1, var2;
            var1 = new DateTime();
            var2 = new DateTime();
            foreach (CambioEstado item in cambioEstado)
            {
                if (item.esEstadoInicial())
                {   
                    
                    var1 = item.getfechaHoraInicio();
                }

                if (item.esEstadoFinalizado())
                {
                    var2 = item.getfechaHoraInicio();
                }
            }

            if (var1 == var2) 
            {
                return 0; 
            } else
            {
                TimeSpan duracion = var2 - var1;
                
                return duracion.TotalMinutes;// ACA QUE QUEDE MAS LINDO LA DURACION

            }
        }

        public IIterador crearIterador(List<RespuestaDeCliente> respuestasEncuesta)
        {
            return new IteradorRespuestas(respuestasEncuesta);
        }

        public string getRespuestas()
        {
            string rta = " ";


            IIterador iterador = (IteradorRespuestas)crearIterador(respuestasEncuesta);
            iterador.primero();
            while (!iterador.haTerminado())
            {
                RespuestaDeCliente respuestaActual = (RespuestaDeCliente)iterador.actual();
                if (rta == " ")
                {
                    rta = "-" + respuestaActual.getDescripcionRta();
                }
                else
                {
                    rta += "\r\n" + "-" + respuestaActual.getDescripcionRta();

                    iterador.siguiente();
                }

                //foreach (RespuestaDeCliente rtaCliente in respuestasEncuesta)
                //{
                //    if (rta == " " )
                //    {
                //        rta = "-" + rtaCliente.getDescripcionRta();
                //    }
                //    else
                //    {
                //        rta += "\r\n" + "-" + rtaCliente.getDescripcionRta();
                //    }

                //}
            }
            return rta;
        } 

        public string obtenerDescripcionEncuesta(Encuesta enc)
        {
            return enc.getDescripcion();
        }

    }
}
