using System;

namespace Ej_Clase
{
	/// <summary>
	/// Description of Hora.
	/// </summary>
	public class Hora
	{
		private int hora;
		private int min;
		private int seg;
		
		public Hora(int h, int m, int s)
		{
			hora = h;
			min = m;
			seg = s;
		}
		
		public Hora(string h)
		{
			string [] parte = h.Split(new char [] {':'});
			hora = int.Parse(parte[0]);
			min = int.Parse(parte[1]);
			seg = int.Parse(parte[2]);
			
		}
		
		public void imprimir()
		{
			Console.WriteLine("Hora : " +hora+ " Min: " +min+ " Seg: " +seg);
		}
		
	}
}
