using System;
using System.IO;

namespace ProyectoSOLID
{
    public class Lector
    {
        public void LeerArchivo(string ruta)
        {
            string fichero = ruta;
            try
            {
                using (StreamReader lector = new StreamReader(fichero))
                {
                    string evento = string.Empty;
                    DateTime dtFecha = DateTime.Now;
                    while (lector.Peek() > -1)
                    {
                        string linea = lector.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            evento = linea.Split(",")[0];
                            dtFecha = Convert.ToDateTime(linea.Split(",")[1].ToString());
                            string criterio = AplicarCriterio(dtFecha);
                            Console.WriteLine(String.Format("{0}{1}", evento, criterio));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public string AplicarCriterio(DateTime dtFecha)
        {
            string mensaje = string.Empty;
            DateTime dtHoy = DateTime.Now;
            var segundos = (dtHoy - dtFecha).TotalSeconds;
            var minutos = (dtHoy - dtFecha).TotalMinutes;
            var horas = (dtHoy - dtFecha).TotalHours;
            var dias = (dtHoy - dtFecha).TotalDays;

            if (dtHoy > dtFecha)
            {

                if (segundos > 0 && minutos < 1)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrió hace ", segundos, " Segundos ");
                else if (minutos > 0 && horas < 1)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrió hace ", minutos, " Minutos ");
                else if (horas > 0 && dias < 1)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrió hace ", horas, " Horas ");
                else if (dias > 0 && dias < 30)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrió hace ", dias, " Dias ");
                else if (dias > 30 && dias < 365)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrió hace ", (dias / 30), " Meses ");
                else 
                    mensaje = string.Format("{0}{1}{2}", " Ocurrió hace ", (dias / 365), " Años ");
            }
            else
            {
                segundos = (dtFecha - dtHoy).TotalSeconds;
                minutos = (dtFecha - dtHoy).TotalMinutes;
                horas = (dtFecha - dtHoy).TotalHours;
                dias = (dtFecha - dtHoy).TotalDays;

                if (segundos > 0 && minutos < 1)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrirá dentro de ", segundos, " Segundos ");
                else if (minutos > 0 && horas < 1)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrirá dentro de ", minutos, " Minutos ");
                else if (horas > 0 && dias < 1)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrirá dentro de ", horas, " Horas ");
                else if (dias > 0 && dias < 30)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrirá dentro de ", dias, " Dias ");
                else if (dias > 30 && dias < 365)
                    mensaje = string.Format("{0}{1}{2}", " Ocurrirá dentro de ", (dias/ 30), " Meses ");
                else
                    mensaje = string.Format("{0}{1}{2}", " Ocurrirá dentro de ", (dias / 365), " Años ");
            }
            
            return mensaje;
        }
    }
}
