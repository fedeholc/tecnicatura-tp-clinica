 
using System;
using System.Collections.Generic;

public class TurnoGenerator
{
    public static void Main(string[] args)
    {
        const string fechaInicio = "2024-05-09";
        const string fechaFin = "2024-05-15";

        // Días entre fechas
        List<string> dates = new List<string>();
        for (DateTime date = DateTime.Parse(fechaInicio); date <= DateTime.Parse(fechaFin); date = date.AddDays(1))
        {
            dates.Add(date.ToString("yyyy-MM-dd"));
        }

        // Horas (cada media hora)
        List<string> horas = new List<string>();
        for (int i = 0; i < 24; i++)
        {
            horas.Add(i.ToString("00") + ":00:00");
            horas.Add(i.ToString("00") + ":30:00");
        }

        int[] lugarDeAtencion_id = { 1, 2, 3, 4, 5 };
        int turnoStatus_id = 1;

        Console.WriteLine("INSERT INTO CircuitoB.Turno (Fecha, Hora, LugarDeAtencion_id,  Paciente_id, TurnoStatus_id) VALUES ");

        foreach (string date in dates)
        {
          foreach (string hora in horas)
          {
            foreach (int lugar in lugarDeAtencion_id)
            {
                            Console.WriteLine("('" + date + "', '" + hora + "', " + lugar + ",  NULL,  " + turnoStatus_id + "),");


            }
          }
        }
    }
}