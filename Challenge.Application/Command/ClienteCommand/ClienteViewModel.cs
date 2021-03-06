using System;

namespace Challenge.Application.Command
{
    public class ClienteViewModel
    {
        public string Id { get; set; }
        public string Nombres { get;  set; }
        public string Apellidos { get;  set; }
        public string Correo { get;  set; }
        public DateTime FechaNacimiento { get;  set; }
        public string Direccion { get;  set; }
        public bool Activo { get;  set; }
        public DateTime FechaRegistro { get;  set; }
    }
}
