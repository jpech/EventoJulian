using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class PasadoHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if (((Evento)request).dtFechaEvento < fecha)
            {
                ((Evento)request).Criterio = "Ocurrió hace";
                return request;
            }
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
