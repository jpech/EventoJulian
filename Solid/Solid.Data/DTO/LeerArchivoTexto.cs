using Solid.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace Solid.Data.DTO
{
    public class LeerArchivoTexto : ILector
    {
        public List<string> LeerArchivo(string ruta)
        {
            List<string> lineas = new List<string>();
            try
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        lineas.Add(linea);
                    }
                }
                return lineas;
            }
            catch (FileNotFoundException ex)
            {
                throw new FileNotFoundException(ex.Message);
            }
        }
    }
}
