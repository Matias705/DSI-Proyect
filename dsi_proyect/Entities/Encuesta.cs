using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dsi_proyect.Entities
{
    public class Encuesta
    {
        private DateTime fechaVigente;
        private string descripcion = "Preguntas de la encuesta";
        private List<Pregunta> pregunta;
        //se puede romper por el equal q hice en la otra clase!!

        public Encuesta(DateTime fechaVigente, string descripcion,  List<Pregunta> pregunta)
        {
            this.fechaVigente = fechaVigente;
            this.descripcion = descripcion;
            this.pregunta = pregunta;
        }

        public List<Pregunta> getPreguntas()
        {
            return pregunta;
        }

        public Boolean esEncuestaDeCliente(List<Pregunta> listaPregunta)
        {
            if (listaPregunta.SequenceEqual(pregunta)) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }       
        }

        public void armarEncuesta()
        {
            foreach (Pregunta cadapregunta in pregunta)
            {
                descripcion += "\r\n " + cadapregunta.getDescripcion();
            }
        }

        public string getDescripcion()
        {
            return descripcion;
        }

    }
}
