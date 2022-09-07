using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_problema_con_metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            double a = 0;
            double b = 0;
            double c = 0;
            do
            {
                Console.WriteLine("1-Suma. 2-Resta. 3-Multi. 4-Div. 5-Salir");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        {
                            c = suma();
                            Console.WriteLine("= {0}", c);
                            break;
                        }
                    case 2:
                        {
                            c = resta();
                            Console.WriteLine("= {0}", c);
                            break;
                        }
                    case 3:
                        {
                            c = multiplicacion();
                            Console.WriteLine("= {0}", c);
                            break;
                        }
                    case 4:
                        {
                            c = divicion();
                            Console.WriteLine("= {0}", c);
                            break;
                        }
                }
            } while (op != 5);
            public static Double suma()
            {
                double x = 0;
                double y = 0;
                double r = 0;
                Console.WriteLine("Dame el primer valor");
                x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dame el segundo valor");
                y = Convert.ToDouble(Console.ReadLine());

                r = x + y;
                return r;
            }
        }


        //ejemplo 01
        //los metodo suma y resta estan declarados en un logar que no  
        
        public static Double resta()
        {
            double x = 0;
            double y = 0;
            double r = 0;
            Console.WriteLine("Dame el primer valor");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el segundo valor");
            y = Convert.ToDouble(Console.ReadLine());

            r = x - y;
            return r;
        }
        public static Double multiplicacion()
        {
            double x = 0;
            double y = 0;
            double r = 0;
            Console.WriteLine("Dame el primer valor");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el segundo valor");
            y = Convert.ToDouble(Console.ReadLine());

            r = x * y;
            return r;
        }
        
    }
    public static Double divicion()
    {
        double x = 0;
        double y = 0;
        double r = 0;
        Console.WriteLine("Dame el primer valor");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Dame el segundo valor");
        y = Convert.ToDouble(Console.ReadLine());

        r = x / y;
        return r;
    }
}
