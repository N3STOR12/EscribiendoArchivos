using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace EscribiendoArchivos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("ejemplo.txt", true);
            //Para sobreescribir es false, para escribir es true
            //se utiliza una "," despues del documento. 
            //Si el archivo no existe lo crea
            //Si ya existe, escribira en el

            string[] line =
            {
                "Esta es la informacion de la primera linea",
                "Esta es la segunda linea",
                "Fin del texto"
            };

            foreach (string s in line)
            {
                sw.WriteLine(s);
            }
            sw.Close(); //Cierre del archivo, se debe de hacer

            Console.WriteLine("Escribiendo en el archivo...");
            Console.ReadKey();

        }
    }
}
