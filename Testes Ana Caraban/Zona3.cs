using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{
    internal class Zona3
    {
        int[] zona3; 
        public double ocupacao;

        public Zona3()
        {
            Random aleatorio = new Random();
            zona3 = new int[aleatorio.Next(25, 35)];

        }

        public void EstacionarZona3()
        {

            for (int i = 0; i < zona3.Length; i++)

                if (zona3[i] == 0)
                { zona3[i] = 1; return; }

            Console.WriteLine("Não há lugares vagos nesta zona");
        }


        public void RetirarZona3()
        {
            Random geradorDeNumerosAleatorios = new Random();
            int LugarRetirar = geradorDeNumerosAleatorios.Next(0, zona3.Length);

            zona3[LugarRetirar] = 0;

            //for (int i = 0; i < zona1.Length; i++)

            //    if (zona1[i] == 1)
            //    { zona1[i] = 0; return; }

        }





        public void Ocupacao()
        {
            //double ocupacao;
            double lugaresOcupados = 0;
            double lugaresVagos = 0;

            for (int i = 0; i < zona3.Length; i++)
            {
                if (zona3[i] == 1)
                { lugaresOcupados++; }
                else
                { lugaresVagos++; }

            }

            ocupacao = ((lugaresOcupados / (zona3.Length)) * 100);
            Console.WriteLine(ocupacao + " % de lugares ocupados na Zona 3");
            Console.WriteLine(lugaresOcupados + " lugares ocupados na Zona 3");
            Console.WriteLine(zona3.Length + " total de lugares na Zona 3");
        }
    }
}
