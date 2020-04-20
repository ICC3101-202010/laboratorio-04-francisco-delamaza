using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Central
    {
        private Sensor proceso;
        public Central(Sensor a)
        {
            proceso = a;
           

        }
        public void Empezar()
        {

            proceso.Encender();


            
        }
        public void Revisar()
        {
            
        }
    }
}
