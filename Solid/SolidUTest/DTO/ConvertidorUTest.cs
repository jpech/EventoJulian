using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoFixture;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid.Data.DTO;
using Solid.Data.Interfaces;
using Solid.Entities;

namespace SolidUTest.DTO
{
    [TestClass]
    public class ConvertidorUTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception), "No se encontraron datos para convertir.")]
        public void ConvertirDatos_ListaAConvertirVacia_EnviaExcepcion()
        {
            // Arrange
            IConvertidor DOC = new Convertidor();

            // ACT
            List<string> datos = new List<string>();
            List<Evento> ACT = DOC.ConvertirDatos(datos);

            // Assert
            Assert.ThrowsException<Exception>(() => ACT);
        }

        [TestMethod]
        public void ConvertirDatos_ListaAConvertirConDatos_DevuelveListaNoVacia()
        {
            // Arrange
            IConvertidor DOC = new Convertidor();
            var fixture = new Fixture {RepeatCount = 3 };
            var datos = CrearDatos();

            // ACT
            List<Evento> ACT = DOC.ConvertirDatos(datos);

            // Assert
            Assert.IsTrue(ACT.Any());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ConvertirDatos_ListaAConvertirConFormatoNoValido_EnviaExcepcion()
        {
            // Arrange
            IConvertidor DOC = new Convertidor();
            var fixture = new Fixture { RepeatCount = 3 };
            var datos = fixture.Repeat(fixture.Create<string>).ToList();

            // ACT
            List<Evento> ACT = DOC.ConvertirDatos(datos);

            // Assert
            Assert.ThrowsException<Exception>(() => ACT);
        }

        public List<string> CrearDatos()
        {
            List<string> datos = new List<string>();
            datos.Add("Día de los muertos, 02/11/2019 00:00:0");
            datos.Add("Finalizar Prueba, 16/01/2020 00:49:10");
            datos.Add("Hora de dormir, 16/01/2020 00:48:30");
            datos.Add("Día de la madre, 10/05/2020 00:00:00");
            return datos;
        }

    }
}
