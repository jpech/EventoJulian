using Microsoft.VisualStudio.TestTools.UnitTesting;
using Solid.Data.DTO;
using Solid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.DTO.UTest
{
    [TestClass]
    public class LeerArchivoTextoUTest
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void LeerArchivo_ArchivoNoExistente_EnviaExcepcion()
        {
            // Arrange
            ILector DOC = new LeerArchivoTexto();
            string ruta = "C:\\pruebas.txt";

            // ACT
            var ACT = DOC.LeerArchivo(ruta);

            // Assert
            Assert.ThrowsException<FileNotFoundException>(() => ACT);
        }

        [TestMethod]
        public void LeerArchivo_ArchivoExistenteConDatos_DeveulveListaConDatos()
        {
            // Arrange
            ILector DOC = new LeerArchivoTexto();
            string ruta = "C:\\prueba.txt";

            // ACT
            var ACT = DOC.LeerArchivo(ruta);
            
            // Assert
            Assert.IsTrue(ACT.Any());
        }

        [TestMethod]
        public void LeerArchivo_ArchivoExistenteConSinDatos_DeveulveListaVacia()
        {
            // Arrange
            ILector DOC = new LeerArchivoTexto();
            string ruta = "C:\\prueba.txt";

            // ACT
            var ACT = DOC.LeerArchivo(ruta);

            // Assert
            Assert.IsFalse(ACT.Any());
        }

        [TestMethod]
        public void LeerArchivo_ArchivoExistenteConEspaciosEnBlanco_DeveulveListaVacia()
        {
            // Arrange
            ILector DOC = new LeerArchivoTexto();
            string ruta = "C:\\prueba.txt";

            // ACT
            var ACT = DOC.LeerArchivo(ruta);

            // Assert
            Assert.IsFalse(ACT.Any());
        }
    }
}