using System;
using 

namespace L11 CHGC 1143421
{
    internal class Program
    {
        private const string V = "promedio de calificacion  de los alumnos de la seccion A fue de   :";
        private static readonly object alumno;
        private static readonly object alumno2;
        private static readonly int estudiante;
        private static readonly int suma2;
        private static object aprobo2;
        private static int superior;
        private static object estudiantes;
        private static int suma;
        private static object desaprobo;
        private static int suma3;

        public static object desaprobo1 { get; private set; }
        public static int promedio1 { get; private set; }
        public static int desaprobo2 { get; private set; }

        static int Main(string[] args)
        {
            double resultado, resultado(2), resultado(3), resultado(4);
            double total, total, total;
            int aprobado(1) = 0, aprobado(2) = 0, desaprobado1 = 0, desaprobado(2) = 0;
            double promedio(1), promedio(2), promedio(3);
            



            estudiante = new double[3];
            estudiante = new double[3];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("ingresar el punteo  del estudiante de la seccion A" + i);
                alumnos[i] = double.Parse(Console.ReadLine());
                if (alumnos[i] <= 65)
                {
                    aprobo(1) = aprobo(1) + 1;

                }
                else
                {
                    desaprobo1 = desaprobo1 + 1;
                }
                if (alumno[i] > 90)
                {
                    superior a nota de 90 = superior punteo de 90 + 1;
                }
                suma1 = suma1 + estudiantes[i];
                if (alumno[i] < 75)
                {
                    inferior a nota de 75 = inferior a nota de 75 + 1;
                }
            }

            resultado = (Convert.ToDouble(aprobo) * 100 / alumno.Length);
            resultado = (Convert.ToDouble(desaprobo1) * 100 / estudiantes.Length);
            promedio1 = suma1 / estudiantes.Length;


            for (int j = 0; j < estudiantes2.Length; j++)
            {
                Console.WriteLine("se ingresara la nota de estudiante de la seccion B" + j);
                alumno2[j] = double.Parse(Console.ReadLine());
                if (alumno[j] <= 65)
                {
                    aprobo2 = aprobo2 + 1;

                }
                else
                {
                    desaprobo2 = desaprobo2 + 1;
                }
                suma = suma + estudiante 2[j];
                if (alumno[j] > 90)
                {
                    superior 901 = superior 90 + 1;
                    
                    
                }
                if (estudiantes[j] < 75)
                {
                    inferior a punteo  de 75 = inferior 75+ 1;
                }
            }
            promedio = suma / alumno.Length;
                resultado(3) = (Convert.ToDouble(aprobo) * 100 / alumno.Length);
                resultado(4) = (Convert.ToDouble(desaprobo) * 100 /alumno.Length);
                total = alumno .Length + alumno.Length;
                total = desaprobo + desaprobo;
                total = Convert.ToDouble(total * 100 / total de );
                suma = suma1 + suma2;
                promedio = suma * 100 / total;
                superior = (90) + (90);
                inferior a = inferior a punteo de  75 + inferior a punteo de 75;




                Console.WriteLine(" porcentaje de alumnos desaprobados de la seccion A han sido de :" + resultado);
                Console.WriteLine(" porcentaje mostrado de alumnos que han sido desaprobados de la seccion B son los siguintes :" + resultado);
                Console.WriteLine("pocentaje de alumnos que fueron aprobados de la seccion A fue de :" + resultado);
                Console.WriteLine(" porcentaje de alumnos aprobados de la seccion fueron de  :" + resultado);
                Console.WriteLine(" porcentaje de desaprobdos de ambas  secciones es de :" + total);
            Console.WriteLine(V + promedio);

       Console.ReadKey();
            
        }
    }

   

