using System;
using System.IO;
namespace CrearMetodoYLeerFichero
{
    class Program
    {
                 static void LeerFichero(String nombre_fichero);
                 {

                     String registro;

                     if (File.Exists(nombre_fichero))
                     {
                      registro = File.ReadAllText(nombre_fichero));
                      Console.WriteLine(registro );
                     }
                       else
                       {
                          Console.WriteLine( "Fichero no encontrado");
                       }
                  }

           static void Main(string[] args)
            {
            
          }
    }
}
