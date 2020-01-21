using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class SegundosHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if ((((Evento)request).dtFechaEvento - fecha).TotalSeconds > 0 && (((Evento)request).dtFechaEvento - fecha).TotalMinutes < 1)
                return $" {((Evento)request).cDescripcion} {((Evento)request).Criterio} {(((Evento)request).dtFechaEvento - fecha).TotalSeconds} segundos.\n";
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
