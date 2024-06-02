using Clinica.Entidades;
using Microsoft.EntityFrameworkCore;
using System.IO.Packaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace clinica.Entidades
{
    
        public class ClinicaContext : DbContext
        {
            public DbSet<Paciente> Pacientes { get; set; }
            public DbSet<Profesional> Profesionales { get; set; }
            public DbSet<AgendaTurnos> AgendaTurnos { get; set; }

           
        }

    }

