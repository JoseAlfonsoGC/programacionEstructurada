using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_metodo_que_realizan_trabajo
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
                            suma();
                            break;
                        }
                    case 2:
                        {
                            resta();
                            break;
                        }
                    case 3:
                        {
                            multiplicacion();
                            break;
                        }
                    case 4:
                        {
                            divicion();
                            break;
                        }
                }
            } while (opcion != 5);

            Console.ReadLine();
        }
        //metodo que solo ejecuta codigo
        public static void suma()
        {
            double x = 0;
            double y = 0;
            double resultado = 0;

            Console.WriteLine("Dame el primer numero");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el primer numero");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = x + y;
            Console.WriteLine("El resultado de la suma es {0}",resultado);

        }
        public static void resta()
        {
            double x = 0;
            double y = 0;
            double resultado = 0;

            Console.WriteLine("Dame el primer numero");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el primer numero");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = x - y;
            Console.WriteLine("El resultado de la resta es {0}", resultado);

        }
        public static void multiplicacion()
        {
            double x = 0;
            double y = 0;
            double resultado = 0;

            Console.WriteLine("Dame el primer numero");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el primer numero");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = x * y;
            Console.WriteLine("El resultado de la mtp es {0}", resultado);

        }
        public static void divicion()
        {
            double x = 0;
            double y = 0;
            double resultado = 0;

            Console.WriteLine("Dame el primer numero");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el primer numero");
            y = Convert.ToDouble(Console.ReadLine());

            resultado = x / y;
            Console.WriteLine("El resultado de la divicion es {0}", resultado);

        }
    }
}
