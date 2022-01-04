using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testes_Ana_Caraban
{
    public class MaquinaDoTempo
    {
        int ano;
        int mes;
        int dia;
        int hora;
        int minuto;
        int segundo;
        public MaquinaDoTempo() 
        { 
            this.ano = 0;
            this.mes = 0;
            this.dia = 0;
            this.hora = 0;
            this.minuto = 0;
            this.segundo = 0;
        }
        public MaquinaDoTempo(int _ano, int _mes, int _dia, int _hora, int _minuto, int _segundo) 
        {
            this.ano = _ano;
            this.mes = _mes;
            this.dia = _dia;
            this.hora = _hora;
            this.minuto = _minuto;
            this.segundo = _segundo;
        }
        
        
        public DateTime DiaHora() 
        {
          
            return new DateTime(ano, mes, dia, hora, minuto, segundo);
           
        }

        


    }
}
