using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Interfaces
{
    public interface ILector
    {
        List<string> LeerArchivo(string ruta);
    }
}
