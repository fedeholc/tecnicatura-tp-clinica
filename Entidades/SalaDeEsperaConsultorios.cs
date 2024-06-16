using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinica.Entidades
{
    public class SalaDeEsperaConsultorios
    {
        public int Id { get; set; }
        public DateTime? FechaHoraAcreditacion { get; set; }
        public int Paciente_id { get; set; }
        public int Profesional_id { get; set; }
        public int idAgenda { get; set; }
        public int Prioridad { get; set; }
        
    }
}
