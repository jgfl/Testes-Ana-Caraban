using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{
    internal class Zona2
    {
        int[] zona2;
        public double ocupacao;

        public Zona2()
        {
            Random aleatorio = new Random();
            zona2 = new int[aleatorio.Next(16,24)];
        }

        public void EstacionarZona2()
        {

            for (int i = 0; i < zona2.Length; i++)

                if (zona2[i] == 0)
                { zona2[i] = 1; return; }

            Console.WriteLine("Não há lugares vagos nesta zona");
        }


        public void RetirarZona2()
        {
            Random geradorDeNumerosAleatorios = new Random();
            int LugarRetirar = geradorDeNumerosAleatorios.Next(0, zona2.Length);

            zona2[LugarRetirar] = 0;

            //for (int i = 0; i < zona1.Length; i++)

            //    if (zona1[i] == 1)
            //    { zona1[i] = 0; return; }

        }





        public void Ocupacao()
        {
            //double ocupacao;
            double lugaresOcupados = 0;
            double lugaresVagos = 0;

            for (int i = 0; i < zona2.Length; i++)
            {
                if (zona2[i] == 1)
                { lugaresOcupados++; }
                else
                { lugaresVagos++; }

            }

            ocupacao = ((lugaresOcupados / (zona2.Length)) * 100);
            Console.WriteLine(ocupacao + " % de lugares ocupados na Zona 2");
            Console.WriteLine(lugaresOcupados + " lugares ocupados na Zona 2");
            Console.WriteLine(zona2.Length + " total de lugares na Zona 2");

        }





    }



}

