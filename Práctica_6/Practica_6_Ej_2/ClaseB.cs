using System;

namespace Practica_6_Ej_2
{
	public class ClaseB : ClaseA
	{
		public ClaseB()
		{
		}
		
		public override void ToString()
		{
			Console.WriteLine("Clase B");
			base.ToString();
		}
	}
}
