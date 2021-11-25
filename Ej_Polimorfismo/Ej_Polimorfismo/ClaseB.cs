using System;

namespace Ej_Polimorfismo
{
	/// <summary>
	/// Description of ClaseB.
	/// </summary>
	public class ClaseB : ClaseA
	{
		public ClaseB()
		{
		}
		
		public override void ToString()
		{
			base.ToString();
			Console.WriteLine("Clase B");
			
		}
	}
}
