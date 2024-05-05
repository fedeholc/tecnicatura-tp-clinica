console.log(
  `INSERT INTO CircuitoB.Turno (Fecha, Hora, LugarDeAtencion_id,  Paciente_id, TurnoStatus_id) VALUES `
);

const fechaInicio = "2024-05-09";
const fechaFin = "2024-05-15";

//días entre fechas
const dates = [];
for (
  let i = new Date(fechaInicio);
  i <= new Date(fechaFin);
  i.setDate(i.getDate() + 1)
) {
  onlyDate = i.toISOString().split("T")[0];
  dates.push(onlyDate);
}

//horas (cada media hora)
const horas = [];
for (let i = 0; i < 24; i++) {
  horas.push(i + ":00:00");
  horas.push(i + ":30:00");
}

const lugarDeAtencion_id = [1, 2, 3, 4, 5];
const turnoStatus_id = 1;

lugarDeAtencion_id.map((lugar) => {
  dates.map((date) => {
    horas.map((hora) => {
      console.log(
        `('${date}', '${hora}', ${lugar},  NULL,  ${turnoStatus_id}),`
      );
    });
  });
});

//* A la última linea que se genera hay que cambiarle la coma por un punto y coma

//! hay que hacer dos generaciones, una con las horas disponibles y otra con las no disponibles
//! pasar los maps a una función para reutilizar

//? convertir a c sharp?

/*INSERT INTO CircuitoB.Turno (Fecha, Hora, LugarDeAtencion_id,  Paciente_id, TurnoStatus_id) VALUES
('2024-05-07', '10:30:00', 1,  1,  1),
('2024-05-08', '11:30:00', 2,  2,  2),
('2024-05-09', '12:30:00', 3,  3,  3),
('2024-05-10', '13:30:00', 4,  4,  4),
('2024-05-11', '14:30:00', 5,  5,  5),
('2024-05-11', '14:30:00', 6,  5,  5);*/
