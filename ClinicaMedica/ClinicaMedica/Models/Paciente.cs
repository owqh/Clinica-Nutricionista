using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClinicaMedica.Models
{
    public class Paciente
    {
        public int codigo_paciente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public int dui { get; set; }
        public string fecha_nacimiento { get; set; }
        public char sexo { get; set; }
        public string correo { get; set; }
        public string estado_civil { get; set; }
        public int peso { get; set; }
        public int altura { get; set; }
        public int telefono { get; set; }
        public string alergias { get; set; }
        public string padecimieto_previo { get; set; }
    }
}