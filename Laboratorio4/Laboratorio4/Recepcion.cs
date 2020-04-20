using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Recepcion : Sensor
    {
        public int memoria = 0;
        
        public int Memoria  // read-write instance property
        {
            get => memoria;
            set => memoria = value;
        }
        bool encendida = false;
        Sensor n = new Almacenamiento();
        public void Encender()
        {
            
            encendida = true;
            recepcion();
            Console.WriteLine("Se ha encendido r");
            
            
            n.Encender();
            

        }
        public void Apagar()
        {
            encendida = false;
            Console.WriteLine("se Apago la maquina r");
            n.Apagar();
        }
        public void Reiniciar()
        {
            memoria -= 10;
            Encender();

        }
       void recepcion()
        {
            while (encendida == true)
            {
                memoria += 1;
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("+=1");
                if (memoria == 20)
                {
                    Console.WriteLine("Recepcion Memoria llena");
                    Apagar();

                }

            }
            

            
        }
    }
}
