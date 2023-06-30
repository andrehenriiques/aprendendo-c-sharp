using System;
namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
	public class AutenticacaoUtil
	{
		public bool ValidarSenha(string senhaVerdadeira, string senhaTentativa)
		{
			return senhaVerdadeira.Equals(senhaTentativa);
        }
	}
}

