using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
    internal class Designers : Funcionario
    {

        public override double GetBonificacao()
        {
            return this.Salario * 0.17;
        }
        public override void AumentarSalario()
        {
            this.Salario *= 0.11;
        }

        public Designers(string cpf) : base(cpf, 3000) { }
    }
}
