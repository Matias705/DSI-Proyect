using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsi_proyect.Entities
{
    public class Pregunta
    {
        private string pregunta;
        private List<RespuestaPosible> respuesta;

        public Pregunta(string pregunta, List<RespuestaPosible> respuesta)
        {
            this.pregunta = pregunta;
            this.respuesta = respuesta;
        }

        public override bool Equals(object obj)
        {
            return obj is Pregunta pregunta &&
                   this.pregunta == pregunta.pregunta &&
                   EqualityComparer<List<RespuestaPosible>>.Default.Equals(respuesta, pregunta.respuesta);
        }

        public string getDescripcion()
        {
            return pregunta;
        }

        public List<RespuestaPosible> GetRespuestaPosibles()
        {
            return respuesta;
        }

        public Boolean esDePregunta(string rta)
        {
            foreach (RespuestaPosible respuestaPos in respuesta)
            {
                if (respuestaPos.getDescripcionRta() == rta)
                {
                    return true;
                }              
            }return false;
        }



    }
}
