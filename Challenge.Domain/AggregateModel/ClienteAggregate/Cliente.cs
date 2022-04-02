using System;

namespace Challenge.Domain.AggregateModel
{
    public class Cliente: Entity
    {
        public Cliente() 
        {
            Activo = true;
        }
        public string Nombres { get; private set; }
        public string Apellidos { get; private set; }
        public string Correo { get; private set; }
        public DateTime FechaNacimiento { get; private set; }
        public string Direccion { get; private set; }
        public bool Activo { get; private set; }
        public DateTime FechaRegistro { get; private set; }
        public void Registrar(
            string nombres,
            string apellidos,
            string correo,
            DateTime fechaNacimiento,
            string direccion,
            DateTime fechaRegistro
            )
        {
            Nombres = nombres;
            Apellidos = apellidos;
            Correo = correo;
            FechaNacimiento = fechaNacimiento;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
        }

    }
}
