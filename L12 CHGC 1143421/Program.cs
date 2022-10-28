using System;

namespace L12_CHGC_1143421
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("ingresar codigo de 10 digitos");
            int numeral = 0;
            int [,] numeraln = new int[4,5];
            int[,] ma2 = new int[4, 5];
            int[,] ma3 = new int[4, 5];
            Random n = new Random();
            for (int j=0;j<4;j++){
                for (int y = 0; y < 5; y++)
                {
                    numeraln[j, y] = n.Next(100);
                    ma2[j, y] = n.Next(100);
                    numeral = numeral + numeraln[j,y];              

                }

            }
            Console.WriteLine("suma ha sido de:" + numeral);
            int prom = numeral / numeraln.Length;

            Console.WriteLine("mostrar prom:" + prom);
            for (int j = 0; j < 4; j++)
            {
                for (int y = 0; y < 5; y++)
                {

                    ma3[j, y] = ma2[j, y]+numeraln[j, y];

                    Console.Write(ma3[j, y] + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();







        }






    }

}
