using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    interface Sensor
    {
        int Memoria
        {
            get;
            set;
        }
        
        void Encender();
        void Apagar();
        void Reiniciar();

        
    }
}
