using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class empaque : Sensor
    {
        public int memoria = 0;
        public int Memoria  // read-write instance property
        {
            get => memoria;
            set => memoria = value;
        }
        bool encendida = false;
        public void Encender()
        {
            encendida = true;
            Console.WriteLine("Se ha encendido m");
            empaquetar();
        }
        public void Apagar()
        {
            encendida = false;
            Console.WriteLine("Se apago la maquina m");
        }
        public void Reiniciar()
        {
            memoria -= 10;
            Encender();
        }

        void empaquetar()
        {
            while (encendida == true)
            {
                memoria += 1;
                if (memoria == 70)
                {
                    Console.WriteLine("empaque Memoria llena");
                    Apagar();

                }
            }
        }
    }
}
