using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Calendario
{
    internal class Feriado : IComparable<Feriado>
    {
        public int Dia {  get; set; }
        public string Descricao {  get; set; }

        public Feriado(int dia, string descricao)
        {
            this.Dia = dia;
            this.Descricao = descricao;
        }
        public int CompareTo(Feriado other)
        {
            if (other == null) return 1;

            // Exemplo: ordenar por Dia
            return this.Dia.CompareTo(other.Dia);

            // Se quiser ordenar por Descrição, seria:
            // return this.Descricao.CompareTo(other.Descricao);
        }
    }
}
