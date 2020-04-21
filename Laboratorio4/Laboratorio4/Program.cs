using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Sensor r = new Recepcion();
            Sensor a = new Almacenamiento();
            Sensor e = new Ensamblaje();
            Sensor v = new verificacion();
            Sensor m = new empaque();
            Central c = new Central(r,a,e,v,m);
            bool de = true;
            bool j = true;
            c.Empezar();
            
            while (de == true)
            {

                c.Revisar();
                System.Threading.Thread.Sleep(1000);
                i += 1;
                if (i == 45)
                {
                    Console.WriteLine("Dia finalizado");
                    c.Terminar();
                    break;
                }
               
            }
           
            Console.Read();

            
        }
    }
}
