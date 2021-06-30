using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPI_PROG_3_Grupo9
{
    [Serializable]
    public class Contenedor
    {
        public Dictionary<string, string> descripciones = new Dictionary<string, string>();

        public Dictionary<string, string> Descripciones { get => descripciones; set => descripciones = value; }

        public string Traer_descripcion(string nombre)
        {
            try
            {
                
                return Descripciones[nombre];
            }
            catch (Exception)
            {
                return "";
                
            }
        }

        
    }
}
