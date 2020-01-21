using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class HorasPasadosHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if ((fecha - ((Evento)request).dtFechaEvento).TotalHours > 0 && (fecha - ((Evento)request).dtFechaEvento).TotalHours < 24)
                return $" {((Evento)request).cDescripcion} {((Evento)request).Criterio} {(fecha - ((Evento)request).dtFechaEvento).TotalHours} horas.\n";
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
