using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class HorasHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if ((((Evento)request).dtFechaEvento - fecha).TotalHours > 0 && (((Evento)request).dtFechaEvento - fecha).TotalDays < 1)
                return $" {((Evento)request).cDescripcion} {((Evento)request).Criterio} {(((Evento)request).dtFechaEvento - fecha).TotalHours} horas.\n";
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
