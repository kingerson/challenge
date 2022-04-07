using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Examen_Pregunta1_2_Test
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Ejecicio1()
        {
            int num1 = 2;
            int num2 = 1;
            int num3 = 4;
            int num4 = 5;

            List<int> listnumerosInput = new List<int>();
            listnumerosInput.Add(num1);
            listnumerosInput.Add(num2);
            listnumerosInput.Add(num3);
            listnumerosInput.Add(num4);


            var listaCompletaResult = Examen.Rangos.Rangos.CompletarRango(listnumerosInput);

            int numCompleto1 = 1;
            int numCompleto2 = 2;
            int numCompleto3 = 3;
            int numCompleto4 = 4;
            int numCompleto5 = 5;

            List<int> listaCompleta = new List<int>();
            listaCompleta.Add(numCompleto1);
            listaCompleta.Add(numCompleto2);
            listaCompleta.Add(numCompleto3);
            listaCompleta.Add(numCompleto4);
            listaCompleta.Add(numCompleto5);

            Assert.AreEqual(listaCompleta.Count, listaCompletaResult.Count);
            Assert.AreEqual(listaCompleta[0], listaCompletaResult[0]);
            Assert.AreEqual(listaCompleta[1], listaCompletaResult[1]);
            Assert.AreEqual(listaCompleta[2], listaCompletaResult[2]);
            Assert.AreEqual(listaCompleta[3], listaCompletaResult[3]);
            Assert.AreEqual(listaCompleta[4], listaCompletaResult[4]);
        }

        [TestMethod]
        public void Ejecicio2()
        {
            int num1 = 100;
            int num2 = 96;
            int num3 = 101;
            int num4 = 102;
            int num5 = 105;

            List<int> listnumerosInput = new List<int>();
            listnumerosInput.Add(num1);
            listnumerosInput.Add(num2);
            listnumerosInput.Add(num3);
            listnumerosInput.Add(num4);
            listnumerosInput.Add(num5);


            var listaCompletaResult = Examen.Rangos.Rangos.CompletarRango(listnumerosInput);

            int numCompleto1 = 96;
            int numCompleto2 = 97;
            int numCompleto3 = 98;
            int numCompleto4 = 99;
            int numCompleto5 = 100;
            int numCompleto6 = 101;
            int numCompleto7 = 102;
            int numCompleto8 = 103;
            int numCompleto9 = 104;
            int numCompleto10 = 105;

            List<int> listaCompleta = new List<int>();
            listaCompleta.Add(numCompleto1);
            listaCompleta.Add(numCompleto2);
            listaCompleta.Add(numCompleto3);
            listaCompleta.Add(numCompleto4);
            listaCompleta.Add(numCompleto5);
            listaCompleta.Add(numCompleto6);
            listaCompleta.Add(numCompleto7);
            listaCompleta.Add(numCompleto8);
            listaCompleta.Add(numCompleto9);
            listaCompleta.Add(numCompleto10);

            Assert.AreEqual(listaCompleta.Count, listaCompletaResult.Count);
            Assert.AreEqual(listaCompleta[0], listaCompletaResult[0]);
            Assert.AreEqual(listaCompleta[1], listaCompletaResult[1]);
            Assert.AreEqual(listaCompleta[2], listaCompletaResult[2]);
            Assert.AreEqual(listaCompleta[3], listaCompletaResult[3]);
            Assert.AreEqual(listaCompleta[4], listaCompletaResult[4]);
            Assert.AreEqual(listaCompleta[5], listaCompletaResult[5]);
            Assert.AreEqual(listaCompleta[6], listaCompletaResult[6]);
            Assert.AreEqual(listaCompleta[7], listaCompletaResult[7]);
            Assert.AreEqual(listaCompleta[8], listaCompletaResult[8]);
            Assert.AreEqual(listaCompleta[9], listaCompletaResult[9]);

            var usuariosResult3 = Examen.Rangos.Rangos.CompletarRango(new List<int> { 22, 25 });
        }

        public void Ejecicio3()
        {
            int num1 = 22;
            int num2 = 25;

            List<int> listnumerosInput = new List<int>();
            listnumerosInput.Add(num1);
            listnumerosInput.Add(num2);


            var listaCompletaResult = Examen.Rangos.Rangos.CompletarRango(listnumerosInput);

            int numCompleto1 = 22;
            int numCompleto2 = 23;
            int numCompleto3 = 24;
            int numCompleto4 = 25;

            List<int> listaCompleta = new List<int>();
            listaCompleta.Add(numCompleto1);
            listaCompleta.Add(numCompleto2);
            listaCompleta.Add(numCompleto3);
            listaCompleta.Add(numCompleto4);

            Assert.AreEqual(listaCompleta.Count, listaCompletaResult.Count);
            Assert.AreEqual(listaCompleta[0], listaCompletaResult[0]);
            Assert.AreEqual(listaCompleta[1], listaCompletaResult[1]);
            Assert.AreEqual(listaCompleta[2], listaCompletaResult[2]);
            Assert.AreEqual(listaCompleta[3], listaCompletaResult[3]);
        }
    }
}
