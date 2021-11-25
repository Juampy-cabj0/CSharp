using System;

namespace Class
{
	/// <summary>
	/// Description of Punto.
	/// </summary>
	public class Punto
	{
		private double x;
		private double y;
		
		
		public Punto(double x, double y)
		{
			this.x = x;
			this.y = y;
		}
		
		public Punto()
		{
			x = 0;
			y = 0;
			
		}
		
		public Punto suma(Punto a)
		{
			Punto aux = new Punto(this.x + a.x, this.y + a.y);
			return aux;
		}
		
		
		public void mostrar()
		{
			Console.WriteLine("Variable X es: " +x+ " la variable Y es: " +y);
			
		}
		
		
	
	}
}
