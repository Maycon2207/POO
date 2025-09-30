using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Calendario
    {
        private int ano;
        private Mes mes;
        private DateTime primeiroDiaMes;
        private int[,] calendario;

        public Calendario(int ano, Mes mes)
        {
            this.ano = ano;
            this.mes = mes;
            primeiroDiaMes = new DateTime(ano, (int)mes, 1);
            calendario = new int[6, 7];
            gerarCalendario();
        }

        private void gerarCalendario()
        {
            int diasDoMes = DateTime.DaysInMonth(ano, (int)mes);

            //primeiroDiaMes = new DateTime(ano, mes, 1);
            int diaSemanaInicio = (int)primeiroDiaMes.DayOfWeek;

            //calendario = new int[6, 7];
            int dia = 1;

            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (semana == 0 && diaSemana < diaSemanaInicio)
                    {
                        calendario[semana, diaSemana] = 0;
                    }
                    else if (dia <= diasDoMes)
                    {
                        calendario[semana, diaSemana] = dia;
                        dia++;
                    }
                }
            }
        }

        public void ImprimirCalendario()
        {
            Console.WriteLine($"\nCalendário de " +
                                $"{primeiroDiaMes.ToString("MMMM")} de {ano}");

            Console.WriteLine("DOM\tSEG\tTER\tQUA\tQUI\tSEX\tSAB");

            Feriado[] diasFeriados = RetornaFeriados();
            //bool ehFeriado;

            //impressão do calendário
            for (int semana = 0; semana < 6; semana++)
            {
                for (int diaSemana = 0; diaSemana < 7; diaSemana++)
                {
                    if (calendario[semana, diaSemana] != 0)
                    {
                        /*ehFeriado = false;

                        for (int posicaoFeriados = 0; posicaoFeriados < diasFeriados.Length ; posicaoFeriados++)
                        {
                            if( diasFeriados[posicaoFeriados] != null && diasFeriados[posicaoFeriados].Dia == calendario[semana,diaSemana]) 
                            {
                                ehFeriado = true;
                                break;
                            }
                        }*/

                        //if (diasFeriados.Contains(calendario[semana, diaSemana]) || diaSemana == 0)
                        //if (ehFeriado || diaSemana == 0)
                        if (diasFeriados.Any(feriado => feriado != null && feriado.Dia == calendario[semana, diaSemana]) || diaSemana == 0)
                            Console.ForegroundColor = ConsoleColor.Red;

                        Console.Write(calendario[semana, diaSemana].ToString("D2") + "\t");

                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nFeriados: ");
            /*for (int i = 0; i < diasFeriados.Length; i++)
            {
                if (diasFeriados[i] > 0)
                {
                    Console.Write($"{diasFeriados[i].ToString("D2")}\t");
                }
            }*/
            foreach (Feriado diaFeriado in diasFeriados)
            {
                if (diaFeriado != null)
                    Console.Write($"{diaFeriado.Dia:D2}-{diaFeriado.Descricao} \t");

            }

        }

        private Feriado[] RetornaFeriados()
        {
            List<Feriado> feriados = new List<Feriado>();

           // if (mes == 1)
                feriados.Add(new Feriado(1, "Confraternização Universal"));
            else if (mes == Mes.Janeiro)
            {
                feriados.Add(new Feriado(4, "Aniversário da Cidade"));
                feriados.Add(new Feriado(21, "Tiradentes"));
            }
            else if (mes == Mes.Maio) feriados.Add(new Feriado(1, "Dia do Trabalho"));
            else if (mes == Mes.Julho) feriados.Add(new Feriado(9, "Revolução Constitucionalista de SP"));
            else if (mes == Mes.Setembro) feriados.Add(new Feriado(7, "Independência do Brasil"));
            else if (mes == Mes.Outubro)  feriados.Add(new Feriado(12, "Nossa Senhora Aparecida"));
            else if (mes == Mes.Novembro)
            {
                feriados.Add(new Feriado(2, "Finados"));
                feriados.Add(new Feriado(15, "Proclamação da República"));
                feriados.Add(new Feriado(20, "Consciência Negra"));
            }
            else if (mes == Mes.Dezembro)
            {
                feriados.Add(new Feriado(8, "Padroeira da Cidade"));
                feriados.Add(new Feriado(25, "Natal"));
            }

            DateTime domingoDePascoa = DomingoDePascoa();
            DateTime carnaval = domingoDePascoa.AddDays(-47);
            DateTime sextaFeiraSanta = domingoDePascoa.AddDays(-2);
            DateTime corpusChristi = domingoDePascoa.AddDays(60);

            if ((Mes)domingoDePascoa.Month == mes)
                feriados.Add(new Feriado(domingoDePascoa.Day, "Páscoa"));

            if ((Mes)carnaval.Month == mes)
                feriados.Add(new Feriado(carnaval.Day, "Carnaval"));

            if ((Mes)sextaFeiraSanta.Month == mes)
                feriados.Add(new Feriado(sextaFeiraSanta.Day, "Sexta-feira Santa"));

            if ((Mes)corpusChristi.Month == mes)
                feriados.Add(new Feriado(corpusChristi.Day, "Corpus Christi"));

 
            return feriados.ToArray();
        }

    }
}
