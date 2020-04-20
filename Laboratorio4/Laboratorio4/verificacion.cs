using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class verificacion : Sensor
    {
        public int memoria = 0;
        public int Memoria  // read-write instance property
        {
            get => memoria;
            set => memoria = value;
        }
        bool encendida = false;
        Sensor n = new empaque();
        public void Encender()
        {
            encendida = true;
            Console.WriteLine("Se ha encendido v");
            n.Encender();
            verificar();
        }
        public void Apagar()
        {
            encendida = false;
            Console.WriteLine("Se apago la maquina v");
            n.Apagar();
        }
        public void Reiniciar()
        {
            memoria -= 10;
            Encender();
        }
        void verificar()
        {
            while (encendida == true)
            {
                memoria += 1;
                if (memoria == 40)
                {
                    Console.WriteLine("Verificacion Memoria llena");
                    Apagar();

                }
            }
        }
    }
}
