using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Entidades
{
    enum Prioridad
    {
        Urgencia = 0,
        Normal = 1,
     }
    enum TurnoStatus
    {
        NoDisponible = 0,
        Disponible = 1,
        Ocupado = 2
    }

    enum FacturaStatus
    {
        SinPago = 0,
        Pagada = 1,
        Adeudada = 2
    }

    enum MetodoPago
    {
        SinPago = 0,
        Efectivo = 1,
        Tarjeta = 2
    }

    public class SalaDeEspera
    {
        public int Id { get; set; }
        public DateTime? FechaHoraAcreditacion { get; set; }
        public int Paciente_id { get; set; }
        public int Estudio_id { get; set; }
        public int LugarDeAtencion_id { get; set; }
        public int Prioridad { get; set; }
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
        public DateTime? FechaNac { get; set; } 
        public string? DNI { get; set; }
        public string? Telefono { get; set; } 
        public string? Direccion { get; set; }
        public string? Email { get; set; }
        public int? Cobertura_id { get; set; }
        public string? HistoriaClinica { get; set; }      
    }
}
