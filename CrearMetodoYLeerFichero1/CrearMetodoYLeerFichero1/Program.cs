using System;
using System.IO; //Para uso con ficheros

namespace CrearMetodoYLeerFichero1
{
    class Program
    {
        static void leerFichero( String nombre_fichero) // Creamos un metodo para leer el fichero.
        {
            String registro;
            if (File.Exists(nombre_fichero)) //siempre usar un if else y no el while ni el for.
            {
                registro = File.ReadAllText(nombre_fichero); //metodo para leer el fichero.

                Console.WriteLine(registro);
            }
            else
            {
                Console.WriteLine("Fichero no encontrado");
            }
        }
        static void Main(string[] args)
        {
            leerFichero(@"C:\Users\pabli\source\repos\CrearMetodoYLeerFichero1\CrearMetodoYLeerFichero1\Nombres.txt"); //Copiar ruta de acceso de la parte de la derecha.
        }
        
        /* 1º Usamos la librería using system.IO 
           2º Creamos la ruta del archivo (string)
           3º Creamos el FileStream (nombre que quiera) = new FileStream(ruta archivo, FileMode.(el modo que sea), FileAccess.(el acceso que quiera))
           4º Para leer o escribir usaremos el flujo, StreamWriter/StreamReader (nombre que quiera) = new StreamWriter/Reader(nombre del FileStream).
           Por ultimo despues de hacer lo que queramos con el fichero, cerramos el flujo y luego el fichero --> nombre del flujo.close(); nombre del fichero.close();
        */

    }
}
