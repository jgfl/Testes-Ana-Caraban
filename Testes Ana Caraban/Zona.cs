using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{
    public class Zona
    {
       
            public string nome;
            public double preco;
            public TimeSpan duracaoMax;
            public int lugares;
            int[] zona;

            public Zona()
            {
                this.nome = "";
                this.preco = 0;
                this.duracaoMax = new TimeSpan(0, 0, 0);
                this.lugares = 0;
                this.zona = new int[0];
            }

            public Zona(string anome, double apreco, TimeSpan aduracaoMax, int alugares)
            {
                this.nome = anome;
                this.preco = apreco;
                this.duracaoMax = aduracaoMax;
                this.lugares = alugares;
                this.zona = new int[alugares];
            }

            public void Info()
            {
                Console.WriteLine("O Preço por hora na " + this.nome + " é: " + this.preco + " euros." + " Se aplicável pode parar no máximo: " + this.duracaoMax + " e existem: " + this.lugares + " lugares");
            }

            public void Estacionar()
            {

                for (int i = 0; i < zona.Length; i++)

                    if (zona[i] == 0)
                    { zona[i] = 1; return; }

                Console.WriteLine("Não há lugares vagos nesta zona");
            }

            public void Retirar()
            {
                Random geradorDeNumerosAleatorios = new Random();
                int LugarRetirar = geradorDeNumerosAleatorios.Next(0, zona.Length);

                zona[LugarRetirar] = 0;

                //for (int i = 0; i < zona1.Length; i++)

                //    if (zona1[i] == 1)
                //    { zona1[i] = 0; return; }

        }



            public void Ocupacao()
                {
                    double ocupacao;
                    double lugaresOcupados = 0;
                    double lugaresVagos = 0;

                    for (int i = 0; i < zona.Length; i++)
                    {
                        if (zona[i] == 1)
                        { lugaresOcupados++; }
                        else
                        { lugaresVagos++; }

                    }

                    ocupacao = ((lugaresOcupados / (zona.Length)) * 100);
                    Console.WriteLine(ocupacao + " % de lugares ocupados na " + nome);
                    Console.WriteLine(lugaresOcupados + " lugares ocupados na " + nome);
                    Console.WriteLine(zona.Length + " total de lugares existentes na " + nome);
                }
        

    }
}
