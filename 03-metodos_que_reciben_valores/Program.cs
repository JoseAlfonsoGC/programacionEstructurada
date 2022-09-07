using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_metodos_que_reciben_valores
{
    class Program
    {
        static void Main(string[] args)
        {
            //operaciones aritmeticas conmetodos
            string dato = "";
            int opcion = 0;
            double a = 0;
            double b = 0;
            double c = 0;

            do
            {
                Console.WriteLine("1-Suma. 2-Resta. 3-Multi. 4-Div. 5-Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());
                            suma(a,b);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());
                            suma(a, b);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());
                            suma(a,b);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Dame el primer numero");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Dame el primer numero");
                            b = Convert.ToDouble(Console.ReadLine());
                            suma(a, b);
                            break;
                        }
                }
            } while (opcion != 5);

            Console.ReadLine();
        }
        //metodo que solo ejecuta codigo
        public static void suma(double x, double y)
        {
            double resultado = 0;

            resultado = x + y;

            Console.WriteLine("El resultado de la resta es {0}", resultado);
        }
        public static void resta(double x, double y)
        {
            double resultado = 0;

            resultado = x - y;

            Console.WriteLine("El resultado de la resta es {0}", resultado);
        }
        public static void multiplicacion(double x, double y)
        {
            double resultado = 0;

            resultado = x * y;

            Console.WriteLine("El resultado de la resta es {0}", resultado);
        }
        public static void divicion(double x, double y)
        {
            double resultado = 0;

            resultado = x / y;

            Console.WriteLine("El resultado de la resta es {0}", resultado);
        }
    }
}
