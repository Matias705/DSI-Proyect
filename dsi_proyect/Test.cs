using dsi_proyect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect
{
    public class Test
    {
        public List<Llamada> listaLlamadas;
        public Llamada llamada1;
        public Llamada llamada2;
        public Llamada llamada3;
        private Estado estado1;
        private Estado estado2;
        private CambioEstado cambioEstado1;
        private CambioEstado cambioEstado2;
        private CambioEstado cambioEstado3;
        private CambioEstado cambioEstado4;
        private CambioEstado cambioEstado5;
        private CambioEstado cambioEstado6;
        private Cliente clienteHumilde;
        private RespuestaDeCliente respuestaDeCliente1;
        private RespuestaDeCliente respuestaDeCliente2;
        private RespuestaDeCliente respuestaDeCliente3;
        private RespuestaDeCliente respuestaDeCliente4;
        private RespuestaDeCliente respuestaDeCliente5;
        private RespuestaDeCliente respuestaDeCliente6;
        private RespuestaDeCliente respuestaDeCliente7;
        private RespuestaDeCliente respuestaDeCliente8;
        private RespuestaDeCliente respuestaDeCliente9;


        private RespuestaPosible respuestaPosibles1;
        private RespuestaPosible respuestaPosibles2;
        private RespuestaPosible respuestaPosibles3;
        private RespuestaPosible respuestaPosibles4;
        private RespuestaPosible respuestaPosibles5;
        private RespuestaPosible respuestaPosibles6;
        private RespuestaPosible respuestaPosibles7;
        private RespuestaPosible respuestaPosibles8;
        private RespuestaPosible respuestaPosibles9;
        private RespuestaPosible respuestaPosibles10;
        private RespuestaPosible respuestaPosibles11;
        private RespuestaPosible respuestaPosibles12;

        private Pregunta preguntas1;
        private Pregunta preguntas2;
        private Pregunta preguntas3;
        private Pregunta preguntas4;
        private Pregunta preguntas5;
        private Pregunta preguntas6;

        public Encuesta encuesta1;
        public Encuesta encuesta2;

        public void crearTodo()
        {
            estado2 = new Estado("Finalizada");
            estado1 = new Estado("Iniciada");

            clienteHumilde = new Cliente(40941062, "Matias Marino", 3512263782);

            DateTime fecha1 = DateTime.Parse("21/02/2023 12:53:00");
            DateTime fecha2 = DateTime.Parse("29/05/2023 03:22:00");
            DateTime fecha3 = DateTime.Parse("21/02/2023 16:23:00");
            DateTime fecha4 = DateTime.Parse("29/05/2023 03:35:00");
            DateTime fecha5 = DateTime.Parse("20/05/2021 00:32:25");
            DateTime fecha6 = DateTime.Parse("20/05/2021 01:35:05");

            cambioEstado1 = new CambioEstado(fecha1, estado1);
            cambioEstado2 = new CambioEstado(fecha2, estado1);
            cambioEstado3 = new CambioEstado(fecha3, estado2);
            cambioEstado4 = new CambioEstado(fecha4, estado2);
            cambioEstado5 = new CambioEstado(fecha5, estado1);
            cambioEstado6 = new CambioEstado(fecha6, estado2);

            respuestaPosibles1 = new RespuestaPosible("Si quiero pertenecer", 1);
            respuestaPosibles2 = new RespuestaPosible("No quiero pertenecer", 2);
            respuestaPosibles3 = new RespuestaPosible("Si quiero dar de baja la tarjeta",1);
            respuestaPosibles4 = new RespuestaPosible("No quiero dar de baja la tarjeta", 2);
            respuestaPosibles5 = new RespuestaPosible("Quiero ese descuento", 1);
            respuestaPosibles6 = new RespuestaPosible("No quiero ese descuento", 2);
            respuestaPosibles7 = new RespuestaPosible("Me interesa saber más", 1);
            respuestaPosibles8 = new RespuestaPosible("No Me interesa saber más", 2);
            respuestaPosibles9 = new RespuestaPosible("Quiero recibir mas información por mail", 1);
            respuestaPosibles10 = new RespuestaPosible("No Quiero recibir mas información por mail", 2);
            respuestaPosibles11 = new RespuestaPosible("Me solucionaron mi problema", 1);
            respuestaPosibles12 = new RespuestaPosible("No me solucionaron mi problema", 2);

            List<RespuestaPosible> lista1 = new List<RespuestaPosible>();
            lista1.Add(respuestaPosibles1);
            lista1.Add(respuestaPosibles2);
            List<RespuestaPosible> lista2 = new List<RespuestaPosible>();
            lista2.Add(respuestaPosibles3);
            lista2.Add(respuestaPosibles4);
            List<RespuestaPosible> lista3 = new List<RespuestaPosible>();
            lista3.Add(respuestaPosibles5);
            lista3.Add(respuestaPosibles6);
            List<RespuestaPosible> lista4 = new List<RespuestaPosible>();
            lista4.Add(respuestaPosibles7);
            lista4.Add(respuestaPosibles8);
            List<RespuestaPosible> lista5 = new List<RespuestaPosible>();
            lista5.Add(respuestaPosibles9);
            lista5.Add(respuestaPosibles10);
            List<RespuestaPosible> lista6 = new List<RespuestaPosible>();
            lista6.Add(respuestaPosibles11);
            lista6.Add(respuestaPosibles12);

            preguntas1 = new Pregunta("Quiere pertener a nuestra secta?", lista1);
            preguntas2 = new Pregunta("Quiere dar de baja a la tarjeta?", lista2);
            preguntas3 = new Pregunta("Quiere el descuento asociado a su tarjeta de credito?", lista3);
            preguntas4 = new Pregunta("Le interesa saber mas sobre ofertas?", lista4);
            preguntas5 = new Pregunta("Desea recibir informacion por mail?", lista5);
            preguntas6 = new Pregunta("Se soluciono el problema por el cual consulto?", lista6);

            // en la encuesta solo incluir 1,2,4
            respuestaDeCliente1 = new RespuestaDeCliente(fecha2, respuestaPosibles1);
            respuestaDeCliente2 = new RespuestaDeCliente(fecha2, respuestaPosibles3);
            respuestaDeCliente3 = new RespuestaDeCliente(fecha4, respuestaPosibles2);
            respuestaDeCliente4 = new RespuestaDeCliente(fecha4, respuestaPosibles7);
            respuestaDeCliente5 = new RespuestaDeCliente(fecha5, respuestaPosibles8);
            respuestaDeCliente6 = new RespuestaDeCliente(fecha5, respuestaPosibles3);
            respuestaDeCliente7 = new RespuestaDeCliente(fecha2, respuestaPosibles7);
            respuestaDeCliente8 = new RespuestaDeCliente(fecha4, respuestaPosibles3);
            respuestaDeCliente9 = new RespuestaDeCliente(fecha5, respuestaPosibles1);

            List<Pregunta> listaDePreguntas = new List<Pregunta>();
            listaDePreguntas.Add(preguntas1);
            listaDePreguntas.Add(preguntas2);
            listaDePreguntas.Add(preguntas4);

            List<Pregunta> listaDePreguntas2 = new List<Pregunta>();
            listaDePreguntas2.Add(preguntas1);
            listaDePreguntas2.Add(preguntas6);
            listaDePreguntas2.Add(preguntas4);

            encuesta1 = new Encuesta(fecha1, "Encuesta de servicio", listaDePreguntas);
            encuesta2 = new Encuesta(fecha3,"Encuesta de afiliacion", listaDePreguntas2);

            List<CambioEstado> listCambio = new List<CambioEstado>();
            listCambio.Add(cambioEstado1);
            listCambio.Add(cambioEstado3);

            List<CambioEstado> listCambio2 = new List<CambioEstado>();
            listCambio2.Add(cambioEstado2);
            listCambio2.Add(cambioEstado4);

            List<CambioEstado> listCambio3 = new List<CambioEstado>();
            listCambio3.Add(cambioEstado5);

            List<RespuestaDeCliente> rtaCliente = new List<RespuestaDeCliente>();
            rtaCliente.Add(respuestaDeCliente1);
            rtaCliente.Add(respuestaDeCliente2);
            rtaCliente.Add(respuestaDeCliente7);

            llamada1 = new Llamada(null, null, 0, true, null, clienteHumilde, listCambio, rtaCliente, 11);
            llamada2 = new Llamada(null, null, 0, true, null, clienteHumilde, listCambio2, rtaCliente, 22);
            llamada3 = new Llamada(null, null, 0, true, null, clienteHumilde, listCambio3, rtaCliente, 33);


            listaLlamadas = new List<Llamada>();
            listaLlamadas.Add(llamada1);
            listaLlamadas.Add(llamada2);
            listaLlamadas.Add(llamada3);


        }

    }
}
