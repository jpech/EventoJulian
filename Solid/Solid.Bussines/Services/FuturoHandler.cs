using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public class FuturoHandler : AbstractHandler
    {
        public override object Handle(object request, DateTime fecha)
        {
            if (request is Evento)
            {
                if (((Evento)request).dtFechaEvento > fecha)
                {
                    ((Evento)request).Criterio = "Ocurrirá dentro de";
                    return request;
                }
                else
                    return base.Handle(request, fecha);
            }
            else
            {
                return base.Handle(request, fecha);
            }
        }
    }
}
