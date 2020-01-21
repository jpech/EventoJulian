using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class DiasHadler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if ((((Evento)request).dtFechaEvento - fecha).TotalDays > 24 && (((Evento)request).dtFechaEvento - fecha).TotalDays < 31)
                return $" {((Evento)request).cDescripcion} {((Evento)request).Criterio} {(((Evento)request).dtFechaEvento - fecha).TotalDays} días.\n";
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
