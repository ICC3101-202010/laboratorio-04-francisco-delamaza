using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Almacenamiento : Sensor
    {
        public int memoria = 0;
        public int Memoria  // read-write instance property
        {
            get => memoria;
            set => memoria = value;
        }
        bool encendida = false;
        Sensor n = new Ensamblaje();
        public void Encender()
        {
            
            encendida = true;
            Console.WriteLine("Se ha encendido a");
            almacenar();
            n.Encender();
            
        }
        public void Apagar()
        {
            encendida = false;
            Console.WriteLine("Se apago la maquina a");
            n.Apagar();
        }
        public void Reiniciar()
        {
            memoria -= 10;
            Encender();

        }
        void almacenar()
        {
            while (encendida == true)
            {
                memoria += 1;
                System.Threading.Thread.Sleep(100);
                Console.WriteLine("aa+=1");
                if (memoria == 8)
                {
                    Console.WriteLine("Almacenamiento Memoria llena");
                    Apagar();

                }
            }
            
        }
    }
}
