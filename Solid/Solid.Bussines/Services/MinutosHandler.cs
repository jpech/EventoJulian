using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class MinutosHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if ((((Evento)request).dtFechaEvento - fecha).TotalMinutes > 0 && (((Evento)request).dtFechaEvento - fecha).TotalHours < 1)
                return $" {((Evento)request).cDescripcion} {((Evento)request).Criterio} {(((Evento)request).dtFechaEvento - fecha).TotalMinutes} minutos.\n";
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
