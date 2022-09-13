using System.Collections.Generic;//esta libreria es para el manejo de la lista

namespace HospiEnCasa.App.Dominio
{
    public class Historia : Persona
    {    
        public int id { get; set; }
        public string Diagnostico { get; set; }
        public string Entorno { get; set; }
        public List<SugerenciaCuidado> Sugerencias { get; set; }
    }
}