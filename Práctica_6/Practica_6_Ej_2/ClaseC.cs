using System;

namespace Practica_6_Ej_2
{
	public class ClaseC : ClaseB
	{
		public ClaseC()
		{
		}
		
		public override void ToString()
		{
			Console.WriteLine("Clase C");
			base.ToString();
		}
	}
}
