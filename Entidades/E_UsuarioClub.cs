using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinica.Entidades
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
    public class E_UsuarioClub
    {
        public int NSocio
        {
            get; set;
        }
        public string? Nombre
        {
            get; set;
        }
        public int DNI
        {
            get; set;
        }
        public string? Correo
        {
            get; set;
        }
  
        public DateOnly FechaInscripcion
        {
        get; set; }

        public bool AptoFisico
        {
            get; set;
        }

    }
}
