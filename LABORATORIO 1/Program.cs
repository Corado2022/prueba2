using System;

namespace Tarea01_1103421_Kenneth_Barillas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");

            Console.WriteLine("Escriba su nombre:");
            String Nombre = Console.ReadLine();
            Console.WriteLine("Escriba su edad:");
            String Edad = Console.ReadLine();
            Console.WriteLine("Escriba su carrera:");
            String Carrera = Console.ReadLine();
            Console.WriteLine("Escriba su carné:");
            String Carné = Console.ReadLine();

            Console.WriteLine("Soy " + Nombre + " tengo " + Edad + " años y estudio la carrera de " + Carrera + " mi número de carné es " + Carné);
         

            Console.ReadKey();
        }
    }
}
