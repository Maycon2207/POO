using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _18_ValidaCPF
{
    public class CPF : IDocumento
    {
        public string Numero { get; private set; }

        public CPF(string numero)
        {
            // Remove caracteres não numéricos
            Numero = Regex.Replace(numero, "[^0-9]", "");
        }

        public bool Validar()
        {
            if (Numero.Length != 11)
                return false;

            if (Regex.IsMatch(Numero, @"^(\d)\1{10}$"))
                return false;

            // Primeiro dígito verificador
            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += (Numero[i] - '0') * (10 - i);
            }

            int resto = soma % 11;
            int digX = resto < 2 ? 0 : 11 - resto;

            // Segundo dígito verificador
            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += (Numero[i] - '0') * (11 - i);
            }

            resto = soma % 11;
            int digY = resto < 2 ? 0 : 11 - resto;

            // Verifica os dois dígitos
            return digX == (Numero[9] - '0') && digY == (Numero[10] - '0');
        }
    }
}