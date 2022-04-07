using System;
using System.Collections.Generic;

namespace Examen.Rangos
{
    public class Rangos
    {
        /**
         * Crear una clase llamada Rangos que tenga un método llamado CompletarRango que tome un parámetro de colección de números enteros positivos (1,2,3,...n) en cualquier orden. 
         * El algoritmo debe completar si faltan números en la colección en el rango dado. 
         * Finalmente devolver la colección completa y ordenada de manera ascendente
         */

        public static List<int> CompletarRango(List<int> inputcolection)
        {

            List<int> lista = inputcolection;
            var listaTemp = lista.ToArray();
            Array.Sort(listaTemp);

            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < listaTemp.Length; i++)
            {
                s.Add(listaTemp[i]);
            }

            for (int x = listaTemp[0]; x <= listaTemp[listaTemp.Length - 1]; x++)
                if (!s.Contains(x))
                    lista.Add(x);

            lista.Sort();

            return lista;
        }
    }
}
