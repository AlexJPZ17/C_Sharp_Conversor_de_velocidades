using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_velocidades
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaramos dos variable
            int opcion, repetir = 0;
            //Mandamos a llamar a la clase Conversor
            Conversor con = new Conversor();
            //Instrucción do while que se repetirá de acuerdo a lo que este en la variable repetir
            do
            {
                //Mostramos los mensajes y obtenemos el dato ingresado
                Console.WriteLine("Escoja una de las opciones");
                Console.WriteLine("1 - Convertir m/s a km/h");
                Console.WriteLine("2 - Convertir km/h a m/s");
                opcion = Convert.ToInt32(Console.ReadLine());
                //Instrucción switch que evalúa la variable opción
                switch (opcion)
                {
                    case 1:
                        con.Conversor1();
                        break;
                    case 2:
                        con.Conversor2();
                        break;
                    default:
                        Console.WriteLine("Opción errónea");
                        break;
                }
                //Colocamos un mensaje con una opción 
                Console.WriteLine("Si desea repetir coloque el valor de 1 o cualquier tecla para salir");
                repetir = Convert.ToInt32(Console.ReadLine());
            } while (repetir == 1);
        }
    }
}
