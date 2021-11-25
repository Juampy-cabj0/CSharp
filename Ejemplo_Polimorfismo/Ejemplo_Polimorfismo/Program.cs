using System;

namespace Ejemplo_Polimorfismo
{
	class Program
	{
		public static void Main(string[] args)
		{
			ClaseA var1= new ClaseA();
			ClaseB var2= new ClaseB();
			
			var2.ToString();
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
	
	public class ClaseA
	{
		public ClaseA()
		{
			
		}
		
		public virtual void ToString()
		{
			Console.WriteLine("Clase A");
		}
	}
	
	public class ClaseB : ClaseA
	{
		public ClaseB()
		{
			
		}
		
		public virtual void ToString()
		{
			Console.WriteLine("Clase B");
			base.ToString();
		}
	}
	
}