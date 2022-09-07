using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_estructuras
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
            empleado uno;
            uno.nombre = "Jose";
            uno.edad = 27;
            uno.id = 567;
            uno.sueldo = 10500.50;

            Console.WriteLine(uno);

            Console.ReadLine();
        }
    }
}
