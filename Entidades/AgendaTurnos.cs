using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica.Entidades
{
    public class AgendaTurnos
    {
        public int? id_AgendaTurnos { get; set; }
        public DateTime? FechaHora { get; set; }
        public int? PacienteId { get; set; }
        public int? ProfesionalId { get; set; }
      
    }
}
