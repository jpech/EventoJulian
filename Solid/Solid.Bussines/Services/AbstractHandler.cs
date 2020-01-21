using Solid.Bussines.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Bussines.Services
{
    public abstract class AbstractHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handle(object request, DateTime fecha)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request, fecha);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
