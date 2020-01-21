using Solid.Bussines.Services;
using Solid.Data.DTO;
using Solid.Data.Interfaces;
using Solid.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2020, 01, 16, 00, 49, 00);
            List<string> datos = new List<string>();
            List<Evento> eventos = new List<Evento>();
            ILector lector = new LeerArchivoTexto();
            
            IConvertidor convertidor = new Convertidor();
            var context = new Context();
            string ruta = "C:\\prueba.txt";
            datos = lector.LeerArchivo(ruta);
            eventos = convertidor.ConvertirDatos(datos);
            foreach (var evento in eventos)
            {
                if (evento.dtFechaEvento < fecha)
                {
                    var str = new CriterioFuturo();
                    context.AsignarEstrategia(str);
                    context.AsignarCriterios(evento, fecha);
                }
                else
                {
                    var str2 = new CriterioPasado();
                    context.AsignarEstrategia(str2);
                    context.AsignarCriterios(evento, fecha);
                }
            }

            var segundos = new SegundosHandler();
            var segundosPasados = new SegundosPasadosHandler();
            var minutos = new MinutosHandler();
            var minutosPasados = new MinutosPasadosHandler();
            var horas = new HorasHandler();
            var horasPasados = new HorasPasadosHandler();
            var dias = new DiasHadler();
            var diasPasados = new DiasPasadosHandler();
            var meses = new MesesHandler();
            var mesesPasados = new MesesPasadosHandler();
            segundos.SetNext(segundosPasados).SetNext(minutos).SetNext(minutosPasados).SetNext(horas).SetNext(horasPasados).SetNext(dias).SetNext(diasPasados).SetNext(meses).SetNext(mesesPasados);

            Cliente.ClientCode(segundos, eventos);
            
            Console.ReadLine();
        }
    }
}
