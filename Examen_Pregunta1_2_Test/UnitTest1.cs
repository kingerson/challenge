using Examen_Pregunta1_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Examen_Pregunta1_2_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrdenarListaPorNombre()
        {
            Usuario us1 = new Usuario("Carlos", "Alcantara");
            Usuario us2 = new Usuario("Luis", "Reyes");
            Usuario us3 = new Usuario("Marcos", "Pinillos");
            Usuario us4 = new Usuario("Marcos", "Buis");
            Usuario us5 = new Usuario("Alberto", "Coronel");

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(us1);
            usuarios.Add(us2);
            usuarios.Add(us3);
            usuarios.Add(us4);
            usuarios.Add(us5);

            List<Usuario> usuariosResult = Examen_Pregunta1_2.OrdenarLista.OrdenarPorNombre(usuarios);

            Usuario us1Sort = new Usuario("Alberto", "Coronel");
            Usuario us2Sort = new Usuario("Carlos", "Alcantara");
            Usuario us3Sort = new Usuario("Luis", "Reyes");
            Usuario us4Sort = new Usuario("Marcos", "Buis");
            Usuario us5Sort = new Usuario("Marcos", "Pinillos");
            List<Usuario> usuaariosSort = new List<Usuario>();
            usuaariosSort.Add(us1Sort);
            usuaariosSort.Add(us2Sort);
            usuaariosSort.Add(us3Sort);
            usuaariosSort.Add(us4Sort);
            usuaariosSort.Add(us5Sort);

            Assert.AreEqual(usuaariosSort.Count, usuaariosSort.Count);
            Assert.AreEqual(usuaariosSort[0].Nombre, usuariosResult[0].Nombre);
            Assert.AreEqual(usuaariosSort[1].Nombre, usuariosResult[1].Nombre);
            Assert.AreEqual(usuaariosSort[2].Nombre, usuariosResult[2].Nombre);
            Assert.AreEqual(usuaariosSort[3].Nombre, usuariosResult[3].Nombre);
            Assert.AreEqual(usuaariosSort[4].Nombre, usuariosResult[4].Nombre);
        }

        [TestMethod]
        public void OrdenarListaPorNombreApellido()
        {
            Usuario us1 = new Usuario("Carlos", "Alcantara");
            Usuario us2 = new Usuario("Luis", "Reyes");
            Usuario us3 = new Usuario("Marcos", "Pinillos");
            Usuario us4 = new Usuario("Marcos", "Buis");
            Usuario us5 = new Usuario("Alberto", "Coronel");

            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(us1);
            usuarios.Add(us2);
            usuarios.Add(us3);
            usuarios.Add(us4);
            usuarios.Add(us5);

            List<Usuario> usuariosResult = Examen_Pregunta1_2.OrdenarLista.OrdenarPorNombreApellido(usuarios);

            Usuario us1Sort = new Usuario("Alberto", "Coronel");
            Usuario us2Sort = new Usuario("Carlos", "Alcantara");
            Usuario us3Sort = new Usuario("Luis", "Reyes");
            Usuario us4Sort = new Usuario("Marcos", "Buis");
            Usuario us5Sort = new Usuario("Marcos", "Pinillos");
            List<Usuario> usuaariosSort = new List<Usuario>();
            usuaariosSort.Add(us1Sort);
            usuaariosSort.Add(us2Sort);
            usuaariosSort.Add(us3Sort);
            usuaariosSort.Add(us4Sort);
            usuaariosSort.Add(us5Sort);

            Assert.AreEqual(usuaariosSort.Count, usuaariosSort.Count);
            Assert.AreEqual($"{usuaariosSort[0].Nombre} {usuaariosSort[0].Apellido}", $"{usuariosResult[0].Nombre} {usuariosResult[0].Apellido}");
            Assert.AreEqual($"{usuaariosSort[1].Nombre} {usuaariosSort[1].Apellido}", $"{usuariosResult[1].Nombre} {usuariosResult[1].Apellido}");
            Assert.AreEqual($"{usuaariosSort[2].Nombre} {usuaariosSort[2].Apellido}", $"{usuariosResult[2].Nombre} {usuariosResult[2].Apellido}");
            Assert.AreEqual($"{usuaariosSort[3].Nombre} {usuaariosSort[3].Apellido}", $"{usuariosResult[3].Nombre} {usuariosResult[3].Apellido}");
            Assert.AreEqual($"{usuaariosSort[4].Nombre} {usuaariosSort[4].Apellido}", $"{usuariosResult[4].Nombre} {usuariosResult[4].Apellido}");
        }
    }
}
