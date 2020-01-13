using System;

namespace ProyectoSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector lector = new Lector();
            string ruta = "C:\\prueba.txt";
            
            lector.LeerArchivo(ruta);
        }
    }
}
