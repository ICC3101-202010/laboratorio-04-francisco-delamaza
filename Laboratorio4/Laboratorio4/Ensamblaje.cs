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
        bool encendida = false;
        Sensor n = new verificacion();
        public void Encender()
        {
            encendida = true;
            Console.WriteLine("Se ha encendido e");
            n.Encender();
            ensamblar();
        }
        public void Apagar()
        {
            encendida = false;
            Console.WriteLine("Se apago la maquina e");
            n.Apagar();
            
        }
        public void Reiniciar()
        {
            memoria -= 10;
            Encender();

        }
        void ensamblar()
        {
            while (encendida == true)
            {
                memoria += 1;
                if (memoria == 27)
                {
                    Console.WriteLine("Ensamblaje Memoria llena");
                    Apagar();

                }
            }
        }
    }
}
