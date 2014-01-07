using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_velocidades
{
    class Conversor
    {
        //Declaramos una variable
        double velocidad;
        //Método que obtiene el dato m/s y lo convierte a km/h
        public void Conversor1()
        {
            Console.WriteLine("Introduzca una velocidad en m/s");
            velocidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(velocidad + " m/s = " + velocidad * 3600 / 1000 + " km/h");
        }
        //Método que obtiene el dato km/h y lo convierte a m/s
        public void Conversor2()
        {
            Console.WriteLine("Introduzca una velocidad en km/h");
            velocidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(velocidad + " km/h = " + velocidad * 1000 / 3600 + " m/s");
        }
    }
}
