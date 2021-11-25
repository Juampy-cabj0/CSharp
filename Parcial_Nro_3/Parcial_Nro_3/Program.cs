using System;

namespace Parcial_Nro_3
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Aeropuerto a1 = new Aeropuerto("Latam", "Ezeiza", 10);
			
			Vuelo v1;
			
			Console.Write("Ingrese el ID del vuelo (para salir ingrese -1): ");
			int id = int.Parse(Console.ReadLine());
			
			while (id != -1)
			{
				Console.Write("Ingrese la fecha de salida (formato dd/mm/aaaa): ");
				string fecha = Console.ReadLine();
				
				Console.Write("Ingrese horario de salida (formato hh:mm)");
				string hora = Console.ReadLine();
				
				Console.Write("Ingrese el origen: ");
				string origen = Console.ReadLine();
				
				Console.Write("Ingrese el destino: ");
				string destino = Console.ReadLine();
				
				Console.Write("Ingrese la duración del vuelo: ");
				string duracion = Console.ReadLine();
				
				Console.Write("Ingrese conjunto de asiento (formato alfanúmerico): ");
				string conjunto = Console.ReadLine();
				
				v1 = new Vuelo(id, fecha, hora, origen, destino, duracion, conjunto);
				
				a1.agregarVuelo(v1);
				
				Console.Write("Ingrese el ID del vuelo (para salir ingrese -1): ");
				id = int.Parse(Console.ReadLine());
				
			}
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}