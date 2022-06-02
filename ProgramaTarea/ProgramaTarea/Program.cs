using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProgramaTarea
{
    internal class Program
    {
        class Trabajador
        {
            //Atributos 
            public string nombre;
            public int edad;
            public string profesion;

            //Contstructor
            public Trabajador(string nombre, int edad, string profesion)
            {
                this.nombre = nombre;
                this.edad = edad;
                this.profesion = profesion;
            }

            //Metodos de la clase
            public int CalcularSueldo(int horas, int CuantoHora)
            {
                return horas * CuantoHora;
            }

            public void DesplegarDatos(int Sueldo)
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
                Console.WriteLine("Profesion: " + profesion);
                Console.WriteLine("Sueldo: {0:c}", Sueldo);
            }
        }

        
        static void Main(string[] args)
        {
            //Creacion del documento 
            StreamWriter sw = new StreamWriter("DatosTrabajador.txt");

            //Declaracion Variables 
            string nombre, profesion;
            int edad, horas, CuantoHora;

            //Asignacion de datos 
            Console.Write("Introduce tu nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Introduduce tu edad: ");
            edad = Int32.Parse(Console.ReadLine());
            Console.Write("Escribe tu profesion: ");
            profesion = Console.ReadLine();
            Console.Write("Introduce las horas que trabajas: ");
            horas = Int32.Parse(Console.ReadLine());
            Console.Write("Introduce a cuanto te pagan la hora: ");
            CuantoHora = Int32.Parse(Console.ReadLine());
            Console.ReadKey();
            Console.Clear();

            //Creacion del objeto 
            Trabajador t1 = new Trabajador(nombre, edad, profesion);
            
            //Invocacion de metodos 
            int sueldo = t1.CalcularSueldo(horas, CuantoHora);
            t1.DesplegarDatos(sueldo);

            sw.WriteLine(t1.nombre + " " + t1.edad + " " + t1.profesion + " {0:c}",sueldo);
            sw.Close();

            Console.WriteLine("Escribiendo archivo....");
            Console.ReadKey();





        }
    }
}
