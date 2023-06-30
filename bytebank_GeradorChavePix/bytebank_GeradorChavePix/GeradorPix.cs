using System;

namespace bytebank_GeradorChavePix
{
	/// <summary>
	/// Classe que gera chaves PIX usando o formato Guid.
	/// </summary>
	public static class GeradorPix
	{
		/// <summary>
		/// Método que retorna uma chave aleatória Pix
		/// </summary>
		/// <returns>Retorna uma chave Pix no formato String.</returns>
		public static string GetChavePix()
		{
			return Guid.NewGuid().ToString();
		}

        /// <summary>
        /// Método que retorna uma lista aleatória de chaves Pix
        /// </summary>
		/// <param name="numeroChaves">Quantidade de chaves a serem geradas.</param>
        /// <returns>Lista de strings de chaves Pix.</returns>
        public static List<string> GetChavesPix(int numeroChaves)
		{
            var chaves = new List<string>();
            if (numeroChaves <= 0)
			{
				return chaves;
            }
			else
			{
				
				for (int i = 0; i < numeroChaves; i++)
				{
					chaves.Add(Guid.NewGuid().ToString());
				}
				return chaves;
			}
		}
	}
}

