using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Practica
{
    internal class Participante
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        
        public string obtener_nombre_completo(string nombre, string apellido)
        {
            return $"{Nombre} - {Apellido}";
        }
    }
}