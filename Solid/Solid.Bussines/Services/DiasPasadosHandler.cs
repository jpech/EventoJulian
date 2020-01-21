using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class DiasPasadosHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if ((fecha - ((Evento)request).dtFechaEvento).TotalHours > 24 && (fecha - ((Evento)request).dtFechaEvento).TotalDays < 31)
                return $" {((Evento)request).cDescripcion} {((Evento)request).Criterio} {(fecha - ((Evento)request).dtFechaEvento).TotalDays} días.\n";
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
