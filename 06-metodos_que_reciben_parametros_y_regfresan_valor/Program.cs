using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_metodos_que_reciben_parametros_y_regfresan_valor
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            double a = 0;
            double b = 0;
            double r = 0;

            do
            {
                Console.WriteLine("1-Suma. 2-Resta. 3-Multi. 4-Div. 5-Salir");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());
                            
                            r = suma(a, b);

                            Console.WriteLine("El resultado de la resta es {0}", r);

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());

                            r = resta(a, b);

                            Console.WriteLine("El resultado de la resta es {0}", r);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());

                            r = multiplicacion(a, b);

                            Console.WriteLine("El resultado de la resta es {0}", r);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());

                            r = divicion(a, b);

                            Console.WriteLine("El resultado de la resta es {0}", r);
                            break;
                        }
                }
            } while (op != 5);

        }
        public static double suma(double x, double y)
        {
            double resultado = 0;

            resultado = x + y;

            return resultado;
        }
        public static double resta(double x, double y)
        {
            double resultado = 0;

            resultado = x + y;

            return resultado;
        }
        public static double multiplicacion(double x, double y)
        {
            double resultado = 0;

            resultado = x + y;

            return resultado;
        }
        public static double divicion(double x, double y)
        {
            double resultado = 0;

            resultado = x + y;

            return resultado;
        }
    }
}
