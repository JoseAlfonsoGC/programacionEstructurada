using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_metodos_problema_resuelto
{
    class Program
    {
        static void Main(string[] args)
        {
            string mdcuadrado;
            double mdcuartoCuadrado = 0, mdcuartox = 0, mdcuartoy = 0;
            int cantidadCuartos = 0;
            string preCocina="", preBaño="", preJardin="";
            string preCocinaMedCuadrado="", preBañoMedCuadrado = "", preJardinMedCuadrado = "";
            Console.WriteLine("Calculadora de obra");
            Console.WriteLine("Ingrese el numero de habitaciones que tendra la obra: ");
            Console.WriteLine("Tiene las medidas cuadraticas de los cuartos deceados s|n : ");
            mdcuadrado = Console.ReadLine();
            if(mdcuadrado =="s" || mdcuadrado == "S")
            {
                Console.WriteLine("Ingresa las medidas al cuadraro: ");
                mdcuartoCuadrado = Convert.ToDouble(Console.ReadLine());

            }else if(mdcuadrado =="n" || mdcuadrado == "N")
            {
                Console.WriteLine("-Ingresa las medidas para el calculo al cuadrado-");
                Console.WriteLine("Ingresa las medidas de x: ");
                mdcuartox = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ingresa las medidas de y: ");
                mdcuartoy = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ingrese la cantidad de cuartos que requiere su obra");
            cantidadCuartos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Su obra requiere de una cocina s/n ?");
            preCocina = Console.ReadLine();
            if (preCocina=="s")
            {
                Console.WriteLine("tienen las medidas al cuadrado s/n?");
                pre
                if ()
                {

                }
                else
                {

                }
            }
            else
            {

            }
            Console.WriteLine("Su obra requiere de un baño s/n ?");
            preBaño = Console.ReadLine();

            if (preBaño=="s")
            {
                Console.WriteLine("tienen las medidas al cuadrado s/n?");
                if ()
                {

                }
                else
                {

                }
            }
            else
            {

            }
            Console.WriteLine("Su obra requiere de un jardin s/n ?");
            preJardin = Console.ReadLine();

            if (preJardin=="s")
            {
                if ()
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }
    }
}
