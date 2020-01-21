using Solid.Bussines.Services;
using Solid.Data.DTO;
using Solid.Data.Interfaces;
using Solid.Entities;
using System;
using System.Collections.Generic;

namespace Solid
{
    public class Cliente
    {
        public static void ClientCode(AbstractHandler handler, List<Evento> eventos)
        {
            DateTime fecha = new DateTime(2020, 01, 16, 00, 49, 00);

            foreach (var evento in eventos)
            {
                var result = handler.Handle(evento, fecha);

                if (result != null)
                {
                    Console.WriteLine($"{result}");
                }
                else
                {
                    Console.WriteLine($"El evento {evento.cDescripcion } no se pudo resolver.");
                }
            }
        }
    }
}
