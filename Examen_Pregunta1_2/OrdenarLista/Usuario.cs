using System;

namespace Examen_Pregunta1_2
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Usuario(String nombre, String apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
