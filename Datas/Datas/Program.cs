using System;
using System.Globalization;

namespace Datas
{
    class Program
    {
        static void Main(string[] args){
            Console.Clear();

            //var data = new DateTime();(Cria a estrutura pad.)
            //O now determina o datetime do exato momento
            //var data = DateTime.Now;
            /*var data = new DateTime(2020, 10, 12, 15, 23, 14);
            Console.WriteLine(data);
            Console.WriteLine(data.Day);
            Console.WriteLine(data.Month);
            Console.WriteLine(data.Year);
            Console.WriteLine(data.Hour);
            Console.WriteLine(data.Minute);
            Console.WriteLine(data.Second);
            */

            //var data = DateTime.Now;

            //Pra exibir Y-year M-Minute S-Segundo
            //var formatada = String.Format("{0:dd/MM/yyyy hh:mm}", data);
            //Console.WriteLine(formatada);

            //Formatadores pré-definido d-data, t-hora, T, D, r, s, u, f - combina tudo
            //var formatada = String.Format("{0:t}", data);
            //Console.WriteLine(formatada);

            //var data2 = DateTime.Now;
            //Utilizado para somar dias meses ou ano no calendário
            /*Console.WriteLine(data2.AddDays(-12));
            Console.WriteLine(data2.AddMonths(1));
            Console.WriteLine(data2.AddYears(1));
            */

            /*var pt = new CultureInfo("pt-PT");
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");
            var de = new CultureInfo("de-DE");
            var atual = CultureInfo.CurrentCulture;

            Console.WriteLine(DateTime.Now.ToString("D", atual));
            */
            /*var utcDate = DateTime.UtcNow;
            Console.WriteLine(utcDate.ToLocalTime());
            //Colocar a data para um local especifico independente de onde esteja
            var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("New Zealand Standard Time");
            Console.WriteLine(timeZoneAustralia);
            //Colocar a hora para um local especifico independente de onde esteja
            var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(utcDate, timeZoneAustralia);
            Console.WriteLine(horaAustralia);
            */
            //Imprimir a lista de todos os timezones
            /*var utcDate = DateTime.UtcNow;
            var timezones = TimeZoneInfo.GetSystemTimeZones();
            foreach (var timezone in timezones) {
                Console.WriteLine(timezone.Id);
                Console.WriteLine(timezone);
                Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcDate, timezone));
                Console.WriteLine("--------------------");
            }
            */
            //Formato universal de calculo de horas, minutos e segundos
            /*var timeSpan = new TimeSpan();
            Console.WriteLine(timeSpan);

            var timeSpanNanoSegundos = new TimeSpan(1);
            Console.WriteLine(timeSpanNanoSegundos);

            var timeSpanHoraMinutoSegundo = new TimeSpan(5, 12, 8);
            Console.WriteLine(timeSpanHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

            var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

            Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
            Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));
            */
            //Quantidade de dias no mês
            Console.WriteLine(DateTime.DaysInMonth(2022, 2));
            //Dizer ou não se está no horário de verão 
            Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
            //Método para o final de semana
            static bool IsWeekend(DayOfWeek today) {
                return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
            }
            //Saber se o dia é final de semana
            Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
            
        }
    }
}
