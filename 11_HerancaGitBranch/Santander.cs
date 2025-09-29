using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_HerancaGitBranch
{
    internal class Santander : Banco
    {
        public override string LinhaDigitavel()
        {
            return "033.01";
        }
    }
}
