using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{

    public class Pagamentos
    {
        public double pagamento;
        double totalZona1 = 0;
        double totalZona2 = 0;
        double totalZona3 = 0;

        TimeSpan horaDaSemanaInicio = new TimeSpan(9, 0, 0);
        TimeSpan horaDaSemanaFim = new TimeSpan(20, 0, 0);
        TimeSpan horaSabadoFim = new TimeSpan(14, 0, 0);

        int day = (int)DateTime.Now.DayOfWeek;

        //DateTime horaDaSemanaInicio = new DateTime (9, 0, 0);
        //DateTime horaDaSemanaFim = new DateTime(20, 0, 0);
        //DateTime horaSabadoFim = new DateTime(14, 0, 0);

        public void dinheiroPorZona()
        {
            Console.WriteLine("Total Zona 1: " + totalZona1 + " euros");
            Console.WriteLine("__________________________________");
            Console.WriteLine("Total Zona 2: " + totalZona2 + " euros");
            Console.WriteLine("__________________________________");
            Console.WriteLine("Total Zona 3: " + totalZona3 + " euros");
            Console.WriteLine("__________________________________");
        }

        public void pagamentoZona1()
        {

            Console.WriteLine("introduza as moedas");
            double pagamento = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(pagamento * 100 / 1.854838));

            //Console.WriteLine("introduza as moedas");
            //double pagamento = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("1pode parar até às: " + tempoPC.AddMinutes(pagamento * 100 / 1.854838));
            if (pagamento <= .8625)
            {


                if (day != 7 && day != 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay <= horaDaSemanaFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay <= new TimeSpan(23, 59, 59))
                {
                    Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(pagamento * 100 / 1.9167));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                    //break;
                }

                else if (day != 7 && day != 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay >= new TimeSpan(0, 0, 0))
                {
                    Console.WriteLine("5pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

                else if (day != 7 && day != 6 && DateTime.Now.TimeOfDay < horaDaSemanaInicio)
                {
                    Console.WriteLine("4pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

                else if (DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay > horaDaSemanaFim && DateTime.Now.TimeOfDay < horaDaSemanaFim)
                {
                    Console.WriteLine("2pode parar até amanhã às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay - horaDaSemanaFim));
                    totalZona1 += pagamento;
                    //z1.lugares--;

                }

                else if (DateTime.Now.TimeOfDay > horaDaSemanaFim)
                {
                    Console.WriteLine("3Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;

                }
                if (day == 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay <= horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("6Pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }
                else if (day == 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("pode parar até segunda às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay - horaSabadoFim));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

                else if (day == 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay < horaSabadoFim)
                { }
                if (day == 7) //vai aparecer a data errada na resposta
                {
                    Console.WriteLine("7Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

            }

            if (pagamento > .8625)
            {

                if (day != 7 && day != 6 && DateTime.Now.AddMinutes(45).TimeOfDay <= horaDaSemanaFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio && DateTime.Now.AddMinutes(45).TimeOfDay <= new TimeSpan(23, 59, 59))
                {
                    Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(45));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                    //break;
                }

                else if (day != 7 && day != 6 && DateTime.Now.AddMinutes(45).TimeOfDay >= new TimeSpan(0, 0, 0))
                {
                    Console.WriteLine("5pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, 45, 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

                else if (day != 7 && day != 6 && DateTime.Now.TimeOfDay < horaDaSemanaInicio)
                {
                    Console.WriteLine("4pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, 45, 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

                else if (DateTime.Now.AddMinutes(45).TimeOfDay > horaDaSemanaFim && DateTime.Now.TimeOfDay < horaDaSemanaFim)
                {
                    Console.WriteLine("2pode parar até amanhã às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(45).TimeOfDay - horaDaSemanaFim));
                    totalZona1 += pagamento;
                    //z1.lugares--;

                }

                else if (DateTime.Now.TimeOfDay > horaDaSemanaFim)
                {
                    Console.WriteLine("3Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(0, 45, 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;

                }
                if (day == 6 && DateTime.Now.AddMinutes(45).TimeOfDay <= horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("6Pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, 45, 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }
                else if (day == 6 && DateTime.Now.AddMinutes(45).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("pode parar até segunda às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(45).TimeOfDay - horaSabadoFim));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

                else if (day == 6 && DateTime.Now.AddMinutes(45).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay < horaSabadoFim)
                { }
                if (day == 7) //vai aparecer a data errada na resposta
                {
                    Console.WriteLine("7Pode parar até : " + horaDaSemanaInicio.Add(new TimeSpan(0, 45, 0)));
                    totalZona1 += pagamento;
                    //z1.lugares--;
                }

            }



        }

        public void pagamentoZona2()
        {

            Console.WriteLine("introduza as moedas");
            double pagamento = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(pagamento * 100 / 1.854838));

            //Console.WriteLine("introduza as moedas");
            //double pagamento = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("1pode parar até às: " + tempoPC.AddMinutes(pagamento * 100 / 1.854838));
            if (pagamento <= 2)
            {

                if (day != 7 && day != 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay <= horaDaSemanaFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay <= new TimeSpan(23, 59, 59))
                {
                    Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(pagamento * 100 / 1.9167));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                    //break;
                }

                else if (day != 7 && day != 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay >= new TimeSpan(0, 0, 0))
                {
                    Console.WriteLine("5pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

                else if (day != 7 && day != 6 && DateTime.Now.TimeOfDay < horaDaSemanaInicio)
                {
                    Console.WriteLine("4pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

                else if (DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay > horaDaSemanaFim && DateTime.Now.TimeOfDay < horaDaSemanaFim)
                {
                    Console.WriteLine("2pode parar até amanhã às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay - horaDaSemanaFim));
                    totalZona2 += pagamento;
                    //z1.lugares--;

                }

                else if (DateTime.Now.TimeOfDay > horaDaSemanaFim)
                {
                    Console.WriteLine("3Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;

                }
                if (day == 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay <= horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("6Pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }
                else if (day == 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("pode parar até segunda às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay - horaSabadoFim));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

                else if (day == 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.9167).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay < horaSabadoFim)
                { }
                if (day == 7) //vai aparecer a data errada na resposta
                {
                    Console.WriteLine("7Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.9167), 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

            }

            if (pagamento > 2)
            {

                if (day != 7 && day != 6 && DateTime.Now.AddMinutes(120).TimeOfDay <= horaDaSemanaFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio && DateTime.Now.AddMinutes(120).TimeOfDay <= new TimeSpan(23, 59, 59))
                {
                    Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(120));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                    //break;
                }

                else if (day != 7 && day != 6 && DateTime.Now.AddMinutes(120).TimeOfDay >= new TimeSpan(0, 0, 0))
                {
                    Console.WriteLine("5pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(2, 00, 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

                else if (day != 7 && day != 6 && DateTime.Now.TimeOfDay < horaDaSemanaInicio)
                {
                    Console.WriteLine("4pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(2, 00, 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

                else if (DateTime.Now.AddMinutes(120).TimeOfDay > horaDaSemanaFim && DateTime.Now.TimeOfDay < horaDaSemanaFim)
                {
                    Console.WriteLine("2pode parar até amanhã às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(120).TimeOfDay - horaDaSemanaFim));
                    totalZona2 += pagamento;
                    //z1.lugares--;

                }

                else if (DateTime.Now.TimeOfDay > horaDaSemanaFim)
                {
                    Console.WriteLine("3Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(2, 00, 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;

                }
                if (day == 6 && DateTime.Now.AddMinutes(120).TimeOfDay <= horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("6Pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(2, 0, 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }
                else if (day == 6 && DateTime.Now.AddMinutes(120).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio)
                {
                    Console.WriteLine("pode parar até segunda às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(120).TimeOfDay - horaSabadoFim));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

                else if (day == 6 && DateTime.Now.AddMinutes(120).TimeOfDay > horaSabadoFim && DateTime.Now.TimeOfDay < horaSabadoFim)
                { }
                if (day == 7) //vai aparecer a data errada na resposta
                {
                    Console.WriteLine("7Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(2, 0, 0)));
                    totalZona2 += pagamento;
                    //z1.lugares--;
                }

            }



        }

        public void pagamentoZona3()
        {
            Console.WriteLine("introduza as moedas");
            double pagamento = Convert.ToDouble(Console.ReadLine());



            //if (day != 7 && day != 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay <= horaDaSemanaFim && DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay <= horaDaSemanaFim && DateTime.Now.TimeOfDay > horaDaSemanaInicio && DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay <= new TimeSpan(23, 59, 59))
            //{
            //    Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333));
            //    totalZona3 += pagamento;
                //z3.lugares--;
                //break;
           // }

            //else if (day != 7 && day != 6 && DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay >= new TimeSpan(0, 0, 0))
            //{
            //    Console.WriteLine("5pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.03333333), 0)));
            //    totalZona3 += pagamento;
            //    //z1.lugares--;
            //}

            //else if (Zona.EDiaDaSemana(day) && DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay >= new TimeSpan(0, 0, 0))
            //{
            //    Console.WriteLine("5pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.03333333), 0)));
            //    totalZona3 += pagamento;
            //    z3.lugares--;
            //}

            //else if (day != 7 && day != 6 && DateTime.Now.TimeOfDay < horaDaSemanaInicio)
            //{
            //    Console.WriteLine("4pode parar até às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.03333333), 0)));
            //    totalZona3 += pagamento;
            //    //z3.lugares--;
            //}



            //else if (DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay > horaDaSemanaFim && DateTime.Now.TimeOfDay < horaDaSemanaFim)
            //{
            //    Console.WriteLine("2pode parar até amanhã às: " + horaDaSemanaInicio.Add(DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay - horaDaSemanaFim));
            //    totalZona3 += pagamento;
            //    //z3.lugares--;
            //}
            //else if (DateTime.Now.TimeOfDay > horaDaSemanaFim)
            //{
            //    Console.WriteLine("3Pode parar até amanhã às: " + horaDaSemanaInicio.Add(new TimeSpan(0, (Int32)(pagamento * 100 / 1.03333333), 0)));
            //    totalZona3 += pagamento;
            //    //z3.lugares--;
            //}
            if (pagamento <= 37.20)
            {
                if (day != 7 && day != 6 && horaDaSemanaInicio < DateTime.Now.TimeOfDay && DateTime.Now.TimeOfDay < horaDaSemanaFim)

                {
                    if (horaDaSemanaInicio < DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333).TimeOfDay && DateTime.Now.TimeOfDay < horaDaSemanaFim)
                    {
                        Console.WriteLine("1pode parar até às: " + DateTime.Now.AddMinutes(pagamento * 100 / 1.03333333));
                    }


                }
                else if (pagamento > 37.20)
                {
                    Console.WriteLine("Valor superior ao permitido.");
                }
            }












        }
    }
}

