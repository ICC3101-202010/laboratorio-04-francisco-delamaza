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
            Sensor r = new Recepcion();
            Central c = new Central(r);
            
            c.Empezar();
            Console.Read();
            

            
        }
    }
}
