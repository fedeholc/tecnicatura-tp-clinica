using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Entidades
{
    enum TurnoStatus
    {
        NoDisponible = 0,
        Disponible = 1,
        Ocupado = 2
    }

    
        public class Turno
        {
            public int Id { get; set; }
            public DateTime? Fecha { get; set; }
            public TimeSpan? Hora { get; set; }
            public int LugarDeAtencion_id { get; set; }
            public int? Paciente_id { get; set; }
            public int TurnoStatus { get; set; }
            public int? Estudio_id { get; set; }
        }
    
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
