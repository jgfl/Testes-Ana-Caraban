using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{
    internal class Zona1
    {
        
        int[] zona1;
        public double ocupacao;

        public Zona1()
        {
                Random aleatorio = new Random();
                zona1 = new int[aleatorio.Next(5,15)];
        }

        public void EstacionarZona1()
        {
            for (int i = 0; i < zona1.Length; i++)

                if (zona1[i] == 0)
                { zona1[i] = 1; return; }

            Console.WriteLine("Não há lugares vagos nesta zona");
        }


        public void RetirarZona1()
        {
            Random geradorDeNumerosAleatorios = new Random();
            int LugarRetirar = geradorDeNumerosAleatorios.Next(0, zona1.Length);

            zona1[LugarRetirar] = 0;

            //for (int i = 0; i < zona1.Length; i++)

            //    if (zona1[i] == 1)
            //    { zona1[i] = 0; return; }

        }





        public void Ocupacao()
        {
            //double ocupacao;
            double lugaresOcupados = 0;
            double lugaresVagos = 0;

            for (int i = 0; i < zona1.Length; i++)
            {
                if (zona1[i] == 1)
                { lugaresOcupados++; }
                else
                { lugaresVagos++; }

            }
            
            ocupacao = ((lugaresOcupados / (zona1.Length)) * 100);
            Console.WriteLine(ocupacao + " % de lugares ocupados na Zona 1");
            Console.WriteLine(lugaresOcupados + " lugares ocupados na Zona 1");
            Console.WriteLine(zona1.Length + " total de lugares na Zona 1");

        }

        



    }
}
