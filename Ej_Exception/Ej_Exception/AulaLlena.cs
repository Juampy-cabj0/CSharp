using System;

namespace Ej_Exception
{
	/// <summary>
	/// Description of AulaLlena.
	/// </summary>
	public class AulaLlena : Exception  // Creo una nueva excepcion dandole como herencia la clase Exception
	{
		
		public string motivo;
		
		public AulaLlena(string mot)
		{
			motivo = mot;
		}
	}
}
