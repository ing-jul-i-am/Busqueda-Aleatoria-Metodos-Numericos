using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_busqueda_aleatoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Definimos nuestros puntos iniciales
            double xu = 5;
            double xl = -1;

            double Fval, Fbest=999999999;
            double xBest=0;
            double xTemp;
            Random rnd = new Random();
            double[] r = new double[10000];

            Console.WriteLine("Ingrese el numero de iteraciones deseado: (Maximo 10000)");
            int n = Convert.ToInt32(Console.ReadLine());

            //Aca generamos n valores random para hacer las iteraciones
            //Los valores son entre 0 y 1.
            for (int i = 0; i < n; i++)
            {
                r[i] = rnd.NextDouble();
            }

            Console.WriteLine("Valores de F(x) generados:");
            //Aca iteramos haciendo uso de los n valores random
            for(int i = 0; i < n; i++)
            {
                xTemp = xl + (xu - xl) * r[i];
                Fval = F(xTemp);
                Console.WriteLine($"F({xTemp}) = {Fval}");
                if(Fval < Fbest)
                {
                    Fbest = Fval;
                    xBest = xTemp;
                }
            }

            //Mostramos en pantalla los resultados obtenidos
            Console.WriteLine($"El valor minimo encontrado para F(x) fue: {Fbest}.");
            Console.WriteLine($"Con el valor de x = {xBest}.");
            Console.ReadKey();


        }

        //F(x) es la funcion de dos variables
        static double F(double x)
        {
            double z = Math.Pow((x-2),6) + Math.Pow((x-4),3) - Math.Pow(x,2);
            return z;
        }
    }
}
