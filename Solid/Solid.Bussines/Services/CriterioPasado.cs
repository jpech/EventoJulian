using Solid.Bussines.Interfaces;
using Solid.Entities;
using System;
using System.Collections.Generic;

namespace Solid.Bussines.Services
{
    public class CriterioPasado : ICriterio
    {
        public void AsignarCriterio(Evento evento, DateTime fecha)
        {
            if (evento.dtFechaEvento > fecha)
                evento.Criterio = "Ocurrirá dentro de";
        }
    }
}
