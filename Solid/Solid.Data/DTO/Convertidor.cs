using Solid.Data.Interfaces;
using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Solid.Data.DTO
{
    public class Convertidor : IConvertidor
    {
        public List<Evento> ConvertirDatos(List<string>  lineas)
        {
            
            List<Evento> eventos = new List<Evento>();

            if (!lineas.Any())
                throw new Exception("No se encontraron datos para convertir.");

            try
            {
                foreach (var linea in lineas)
                {
                    Evento evento = new Evento();
                    if (!String.IsNullOrEmpty(linea))
                    {
                        evento.cDescripcion = linea.Split(',')[0];
                        evento.dtFechaEvento = Convert.ToDateTime(linea.Split(',')[1].ToString());
                        eventos.Add(evento);
                    }
                }
                return eventos;
            }
            catch (Exception ex)
            {
                throw new IndexOutOfRangeException(ex.Message);
            }
        }
    }
}
