using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid.Bussines.Interfaces;
using Solid.Bussines.Services;
using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services.UTest
{
    [TestClass()]
    public class CriterioFuturoUTest
    {
        [TestMethod()]
        public void AsignarCriterio_EnviarDatosValidos_AsignaCriterioPasado()
        {
            // Arrange
            ICriterio DOC = new CriterioFuturo();
            Evento evento = new Evento { cDescripcion = "Dia del amor y la amistad", dtFechaEvento = new DateTime(2020, 02, 14, 00, 00, 00) };
            DateTime fecha = new DateTime(2020, 02, 14, 00, 00, 50);

            // ACT
            DOC.AsignarCriterio(evento, fecha);
            var ACT = evento.Criterio;
            var result = "Ocurrió hace";

            // Assert
            Assert.AreEqual(ACT, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "No se puedo realizar el cálculo.")]
        public void AsignarCriterio_EnviaEventoVacio_EnviaExcepcion()
        {
            // Arrange
            ICriterio DOC = new CriterioFuturo();
            Evento evento = new Evento();
            DateTime fecha = new DateTime(2020, 02, 14, 00, 00, 50);

            // ACT
            DOC.AsignarCriterio(evento, fecha);
            var ACT = evento.Criterio;

            // Assert
            Assert.ThrowsException<Exception>(() => ACT);
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception), "No se puedo realizar el cálculo.")]
        public void AsignarCriterio_EnviarDatosFechaVacia_EnviaExcepcion()
        {
            // Arrange
            ICriterio DOC = new CriterioFuturo();
            Evento evento = new Evento { cDescripcion = "Dia del amor y la amistad", dtFechaEvento = new DateTime(2020, 02, 14, 00, 00, 00) };
            DateTime fecha = new DateTime();

            // ACT
            DOC.AsignarCriterio(evento, fecha);
            var ACT = evento.Criterio;
            var result = "Ocurrió hace";

            // Assert
            Assert.AreEqual(ACT, result);
        }
    }
}