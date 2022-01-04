using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{
    public class Parquimetro
    {
        //juntas zonas 1 2 e 3 numa unica classe
        Zona1 z1 = new Zona1();   
        Zona2 z2 = new Zona2();
        Zona3 z3 = new Zona3();
        Pagamentos p = new Pagamentos();
        public void MenuInicial()
        {
            Console.WriteLine("-----------------            Bem-vindo            -----------------");
            Console.WriteLine("-----------------       Sistema Parquímetro       -----------------");
            Console.WriteLine("                            Dia e Hora                             ");
            Console.WriteLine("                        1. Administrador");
            Console.WriteLine("                        2. Cliente");
            Console.WriteLine("                        3. Opções");
            Console.WriteLine("                        0. Sair");
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Escolha a opção pretendida");
            int opcaoMenuInicial = int.Parse(Console.ReadLine());
            if (opcaoMenuInicial == 1) { Administrador(); }
            if (opcaoMenuInicial == 2) { Cliente(); }
            if (opcaoMenuInicial == 3) { Opcao(); }
            if (opcaoMenuInicial == 0) { }
        }

        public void Administrador()
        {
            Console.WriteLine("-----------------            Administrador         -----------------");
            Console.WriteLine("                        1. Ver Zonas");
            Console.WriteLine("                        2. Ver histórico");
            Console.WriteLine("                        3. Ver máquinas");
            Console.WriteLine("                        4. Voltar");
            Console.WriteLine("                        0. Sair");
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Escolha a opção pretendida");
            int opcaoAdministrador = int.Parse(Console.ReadLine());
            if (opcaoAdministrador == 1) 
                {
                z1.Ocupacao();
                Console.WriteLine("__________________________________");
                z2.Ocupacao();
                Console.WriteLine("__________________________________");
                z3.Ocupacao();
                Console.WriteLine("__________________________________");
                Console.WriteLine("__________________________________");
                MenuInicial();
                }
            if (opcaoAdministrador == 2) { }
            if (opcaoAdministrador == 3) 
            { 
                p.dinheiroPorZona();
                Console.WriteLine("__________________________________");
                Console.WriteLine("__________________________________");
                MenuInicial();
            }
            if (opcaoAdministrador == 4) { MenuInicial(); }
            if (opcaoAdministrador == 0) { }
        }

        public void Cliente()
        {
            Console.WriteLine("-----------------            Cliente         -----------------");
            Console.WriteLine("                        1. Estacionar");
            Console.WriteLine("                        2. Ver zonas");
            Console.WriteLine("                        3. Ver histórico");
            Console.WriteLine("                        4. Voltar");
            Console.WriteLine("                        0. Sair");
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("Escolha a opção pretendida");
            int opcaoCliente = int.Parse(Console.ReadLine());
            if (opcaoCliente == 1) { Estacionar(); MenuInicial(); }
            if (opcaoCliente == 2) 
            {
                z1.Ocupacao();
                Console.WriteLine("__________________________________");
                z2.Ocupacao();
                Console.WriteLine("__________________________________");
                z3.Ocupacao();
                Console.WriteLine("__________________________________");
                Console.WriteLine("__________________________________");
                MenuInicial();
            }
            if (opcaoCliente == 3) { }
            if (opcaoCliente == 4) { MenuInicial(); }
            if (opcaoCliente == 0) { }





        }

        public void Estacionar()
        {
            Console.WriteLine("                        1. Zona 1");
            Console.WriteLine("                        2. Zona 2");
            Console.WriteLine("                        3. Zona 3");
            Console.WriteLine("Escolha a opção pretendida");
            int opcaoEstacionar = int.Parse(Console.ReadLine());
            if (opcaoEstacionar == 1) 
            {   
                z1.EstacionarZona1();
                //ERRO.MM QD N HA LUGARES DISPONIVEIS PEDE MOEDA
                if (z1.ocupacao < 100)
                {
                    p.pagamentoZona1();
                    MenuInicial();
                }
                else { MenuInicial(); }
               
            }
            if (opcaoEstacionar == 2) 
            {
                z2.EstacionarZona2();               
                if (z2.ocupacao < 100)
                {
                    p.pagamentoZona2();
                    MenuInicial();
                }
                else { MenuInicial(); }

            }
            if (opcaoEstacionar == 3) 
            {
                z3.EstacionarZona3();
                if (z3.ocupacao < 100)
                {
                    p.pagamentoZona3();
                    MenuInicial();
                }
                else { MenuInicial(); }
            }
        }

        public void Opcao() 
        {
            Random geradorDeNumerosAleatorios = new Random();
            int zonaARetirar=geradorDeNumerosAleatorios.Next(1, 4); //Tive de por o intervalo de (1, 4) pq o intervalo de (1, 3) só gerava o valor 1 e 2

            if (zonaARetirar == 1)
            {
                z1.RetirarZona1();
                MenuInicial();
            }
            if (zonaARetirar == 2)
            {
                z2.RetirarZona2();
                MenuInicial();
            }
            if (zonaARetirar == 3)
            {
                z3.RetirarZona3();
                MenuInicial();
            }


        }

        public void Sair() { }


        
        
        
        }


    }

