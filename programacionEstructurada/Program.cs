using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programacionEstructurada
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double numero3;
            double numero4;
            double numero5;
            double promedio = 0;
            numero1 = pedir(1);
            numero2 = pedir(2);
            numero3 = pedir(3);
            numero4 = pedir(4);
            numero5 = pedir(5);
            promedio = (numero1 + numero2 + numero3 + numero4 + numero5) / 5.0;
            Console.WriteLine("El promedio es {0}", promedio);
            Console.ReadLine();
        }
        public static double pedir(int n)
        {
            double valor;
            Console.WriteLine("Calificacion numero {0} " + n);
            valor = Convert.ToDouble(Console.ReadLine());

            return valor;
        }
    }
}
