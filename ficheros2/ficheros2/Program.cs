using System;
using System.IO;

namespace ficheros2
{
    class Program
    {
        static void leerFichero(String ruta)   //Creamos un metodo para leer un fichero.
        {
            FileStream fichero = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fichero); //Creamos el flujo, recuerda al final del metodo hay que cerrarlo.
            string contenido = "";
            while((contenido = sr.ReadLine()) != null)
                Console.WriteLine(contenido);
            sr.Close();
            fichero.Close();
        }
        static void escribirFichero(String ruta, string alu)  //Creamos un metodo para escribir en el fichero.
        {
            FileStream fichero = new FileStream(ruta, FileMode.Append, FileAccess.Write); //Append para ir añadiendo al final y que no borre lo anterior.
                                                    // RECUERDA APPEND LO CREA SINO EXISTE!!
            StreamWriter sw = new StreamWriter(fichero); //Creamos el flujo, recuerda al final del metodo hay que cerrarlo.
            sw.WriteLine(alu);
            sw.Close();
            fichero.Close();
        }


        static void Main(string[] args)
        {

            string rutaAchivo1 = @"C:\Users\pabli\OneDrive\Documentos\Visual Studio 2019\Code Snippets\Visual C#\Alumnos.txt";  //Creamos una ruta donde queramos el archivo.

            while (true)
            {


                Console.WriteLine("Quieres leer el fichero o añadir un alumno? (L/A) ");
                string respuesta = Console.ReadLine();

                if (respuesta == "L" || respuesta.ToLower() == "leer") //si la respuesta es L será leer.
                {
                    leerFichero(rutaAchivo1);
                }
                else if (respuesta == "A" || respuesta.ToLower() == "Añadir") //Si la respuesta es A será añadir.
                {
                    Console.WriteLine("Escribe el nombre del alumno: ");
                    string frase = Console.ReadLine();
                    escribirFichero(rutaAchivo1, frase);

                }
                else
                {
                    Console.WriteLine("No se reconoce como ninguna opción, lo siento.");
                    break;
                }
            }
            
        }
    }
}
