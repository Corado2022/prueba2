using System;

namespace L10_CHGC_1143421
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            while (cont<=2)
            {
                Console.WriteLine("Ingresar su usuario");
                string usuario1 = Console.ReadLine();
                Console.WriteLine("Ingresar su contrasena");
                string asdasd = Console.ReadLine();

                bool log = login(asdasd, usuario1);
                if (log == true)
                {
                    cont = 3;
                    Console.WriteLine("el acceso ha sido correcto");
                }
                else
                {
                    cont++;
                    if (cont >=2) ;
                    Console.WriteLine("Sus intentos fueron fallidos");
                }

            }
            Console.ReadKey();

      
            
           


        }
        static bool login(string contrasena, string usuario1) { 
        
            if (usuario1 == "usuario1" && contrasena == "asdasd")
            {
                return  true;
            }
            else
            {
                return false;
            }
        }
    }
}
