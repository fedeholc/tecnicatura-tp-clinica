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

    enum FacturaStatus
    {
        Pendiente = 0,
        Pagada = 1,
        Anulada = 2
    }

    enum MetodoPago
    {
        PorCobertura = 0,
        Efectivo = 1,
        Tarjeta = 2
    }

    public class Factura
    {
        public int Id { get; set; }
        public int Estudio_id { get; set; }
        public int Cobertura_id { get; set; }
        public int Paciente_id { get; set; }
        public float? Monto { get; set; }
        public int? MetodoPago { get; set; }
        public int FacturaStatus { get; set; }
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
