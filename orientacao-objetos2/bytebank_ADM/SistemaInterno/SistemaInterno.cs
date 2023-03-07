using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Incorreta!");
                return false;
            }
        }
    }
}
