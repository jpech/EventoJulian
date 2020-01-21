using Solid.Bussines.Interfaces;
using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    public class Context
    {
        public ICriterio _criterio { get; set; }

        public void AsignarEstrategia(ICriterio criterio)
        {
            _criterio = criterio;
        }

        public void AsignarCriterios(Evento evento, DateTime fecha)
        {
            _criterio.AsignarCriterio(evento, fecha);
        }
    }
}
