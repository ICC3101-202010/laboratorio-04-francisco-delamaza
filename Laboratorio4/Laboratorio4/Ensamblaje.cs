using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Ensamblaje : Sensor
    {
        public int memoria = 0;
        public int Memoria  // read-write instance property
        {
            get => memoria;
            set => memoria = value;
        }
        public bool encendida = false;
        public bool Encendida  // read-write instance property
        {
            get => encendida;
            set => encendida = value;
        }
        
        public void Encender()
        {
            encendida = true;
            Console.WriteLine("Se ha encendido e");
            
            new Task(ensamblar).Start();
        }
        public void Apagar()
        {
            encendida = false;
            Console.WriteLine("Se apago la maquina e");
            

        }
        public void Reiniciar()
        {
            memoria -= 27;
            Encender();

        }
        void ensamblar()
        {
            while (encendida == true)
            {
                memoria += 1;
                System.Threading.Thread.Sleep(1000);
                if (memoria == 38)
                {
                    Console.WriteLine("Ensamblaje Memoria llena");
                    Apagar();

                }
            }
        }
    }
}
