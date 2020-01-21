using Solid.Bussines.Interfaces;
using Solid.Entities;
using System;
using System.Collections.Generic;

namespace Solid.Bussines.Services
{
    public class CriterioFuturo : ICriterio
    {
        public void AsignarCriterio(Evento evento, DateTime fecha)
        {
            if (evento == null || fecha == null || (DateTime.MinValue == evento.dtFechaEvento) || (DateTime.MinValue == fecha))
                throw new Exception("No se puedo realizar el cálculo.");

            if (evento.dtFechaEvento < fecha)
                evento.Criterio = "Ocurrió hace";
        }
    }
}
