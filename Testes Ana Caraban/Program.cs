// See https://aka.ms/new-console-template for more information

//int day = (int)DateTime.Now.DayOfWeek;
//Console.WriteLine(day);
//Console.WriteLine(DateTime.Now.Date);

////Console.WriteLine("Introduza um inteiro:");
////int dia = int.Parse(Console.ReadLine());
//int clientes=0;
//double[] array = new double[clientes];
//double total =0;
//double pagamento;


////Console.WriteLine("valor:");
//while (day == 3)
//{
//    for (int i = 0; i <= clientes; i++)
//    {
//        //Console.WriteLine("valor:");
//        //array[i] = total;
//        Console.WriteLine("pagamento");
//        pagamento = Convert.ToDouble(Console.ReadLine());
//        total += pagamento;
//        //array[i] = pagamento;
//        //array[i] = total;
//        clientes++;
//        Console.WriteLine("total = "+ total);


//    }
//    Console.WriteLine(total);

//    for (int j = 0; j < clientes; j++)
//    {
//        Console.WriteLine(array[j]);
//    }
//}   

using Testes_Ana_Caraban;



var horaActual = DateTime.Now;
Console.WriteLine(horaActual);
DateTimeOffset thisDate = new DateTimeOffset(2021, 12, 26, 15, 24, 16, TimeSpan.Zero);
Console.WriteLine(thisDate);
Console.WriteLine(thisDate.AddYears(-1).AddHours(+5).TimeOfDay);



MaquinaDoTempo m = new MaquinaDoTempo(2021, 12, 25, 12, 00, 00);
var horaTeste = m.DiaHora();
Console.WriteLine(horaTeste);
int day = (int)horaTeste.DayOfWeek;
Console.WriteLine(day);

Parquimetro p = new Parquimetro();
p.MenuInicial();


