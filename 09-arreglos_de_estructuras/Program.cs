using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_arreglos_de_estructuras
{
    class Program
    {
        public struct empleado
        {
            public string nombre;
            public int edad;
            public int id;
            public double sueldo;
            public override string ToString()
            {
                StringBuilder cadena = new StringBuilder();

                cadena.AppendFormat("Empleado: {0}, Nombre: {1} \r\nEdad: {2}, sueldo: {3}", id, nombre, edad, sueldo);

                return cadena.ToString();
            }
        }
        static void Main(string[] args)
        {
            //variable de tipo empleado
            //empleado uno;
            //uno.nombre = "Jose";
            //uno.edad = 27;
            //uno.id = 567;
            //uno.sueldo = 10500.50;

            //Console.WriteLine(uno);
            int n = 0;
            empleado[] gente = new empleado[3];
            string dato = "";
            //pedir informacion
            for(n=0; n < 3; n++)
            {
                Console.WriteLine("Dame el id");
                gente[n].id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dane el nombre");
                gente[n].nombre = Console.ReadLine();
                Console.WriteLine("Dame la edad");
                gente[n].edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dame elsueldo");
                gente[n].sueldo = Convert.ToDouble(Console.ReadLine());
            }
            for(n=0; n<3; n++)
            {
                Console.WriteLine(gente[n]);
                Console.WriteLine("---------------");

            }

            Console.ReadLine();
        }
    }
}
