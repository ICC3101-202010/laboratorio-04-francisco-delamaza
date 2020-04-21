using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    class Central
    {
        private Sensor r;
        private Sensor l;
        private Sensor e;
        private Sensor v;
        private Sensor m;

        public Central(Sensor a, Sensor b ,Sensor c , Sensor d, Sensor k)
        {
            r = a;
            l = b;
            e = c;
            v = d;
            m = k;
        }
        public void Empezar()
        {
            r.Encender();
            l.Encender();
            e.Encender();
            v.Encender();
            m.Encender();



        }
        public void Terminar()
        {
            r.Apagar();
            l.Apagar();
            e.Apagar();
            v.Apagar();
            m.Apagar();
        }
        public void Revisar()
        {
            if (r.Encendida == false && l.Encendida==true)
            {
                l.Apagar();
                e.Apagar();
                v.Apagar();
                m.Apagar();
                Console.WriteLine("Reiniciando Recepcion.....");
                System.Threading.Thread.Sleep(2000);
                r.Reiniciar();
                l.Encender();
                e.Encender();
                v.Encender();
                m.Encender();
            }
            else if (l.Encendida == false && e.Encendida == true)
            {
                
                e.Apagar();
                v.Apagar();
                m.Apagar();
                Console.WriteLine("Reiniciando Almacenamiento.....");
                System.Threading.Thread.Sleep(2000);
                l.Reiniciar();
                if (e.Encendida==true)
                {
                    
                    e.Encender();
                    v.Encender();
                    m.Encender();

                }
                
            }
            else if (e.Encendida == false && v.Encendida == true)
            {
                
                v.Apagar();
                m.Apagar();
                Console.WriteLine("Reiniciando Ensamblaje.....");
                System.Threading.Thread.Sleep(2000);
                e.Reiniciar();
                if (v.Encendida == true)
                {

                    
                    v.Encender();
                    m.Encender();

                }
                
            }
            else if (v.Encendida == false && m.Encendida == true)
            {
                
                m.Apagar();
                Console.WriteLine("Reiniciando Verificacion.....");
                System.Threading.Thread.Sleep(2000);
                v.Reiniciar();
                if (m.Encendida == true)
                {


                    
                    m.Encender();

                }

               
            }
            else if (m.Encendida== false)
            {
                Console.WriteLine("Reiniciando Empaque.....");
                System.Threading.Thread.Sleep(2000);
                m.Reiniciar();
            }
            


        }
    }
}
