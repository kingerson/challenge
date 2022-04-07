using System.Collections.Generic;
using System.Linq;

namespace Examen_Pregunta1_2
{
    public class OrdenarLista
    {
        /**
         * Se debe ordenar de manera ascendente esta lista por el atributo Nombre
         * @param usuarios la lista de usuarios a ordenar
         * @return la lista ordenada de usuarios
         */
        public static List<Usuario> OrdenarPorNombre(List<Usuario> usuarios)
        {
            return usuarios.OrderBy(o => o.Nombre).ToList();
        }

        /**
         * Se debe ordenar de manera ascendente esta lista por el atributo Nombre y luego por el apellido
         * @param usuarios la lista de usuarios a ordenar
         * @return la lista ordenada de usuarios
         */
        public static List<Usuario> OrdenarPorNombreApellido(List<Usuario> usuarios)
        {
            return usuarios.OrderBy(o => o.Nombre).ThenBy(t => t.Apellido).ToList();
        }
    }
}
