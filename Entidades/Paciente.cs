using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica.Entidades
{
    public class Paciente
    {
        public int? Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? DNI { get; set; }
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public int? Cobertura_id { get; set; }
        public string? HistoriaClinica { get; set; }
    }
}
