using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Interfaces
{
    public interface ICriterio
    {
        void AsignarCriterio(Evento evento, DateTime fecha);
    }
}
