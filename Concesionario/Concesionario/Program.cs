using System;
using System.Collections;

namespace Concesionario
{
	class Program
	{
		public static void Main(string[] args)
		{
//			En una aplicación cree  la sucursal  “Tu auto ya” de Belgrano, y luego simule la carga de varios autos para vender.
//			Al final del proceso informe cuál es la cantidad de autos de marca Fiat ingresados al local para su venta.(2p)
			
			
			Auto a1 = new Auto("Fiat", "Uno", 300000);
			Auto a2 = new Auto("Ford", "Ka", 400000);
			Auto a3 = new Auto("Fiat", "Argo", 900000);
			
			Sucursal s1 = new Sucursal(1234, "Belgrano", "Tu auto ya", "Juan");
			
			s1.agregarAutos(a1);
			s1.agregarAutos(a2);
			s1.agregarAutos(a3);
			
			int cont = 0;
			
			
			foreach (Auto element in s1.Autos) {
				if (element.Marca == "Fiat") {
					cont++;
				}
			}
			
			
			
			Console.WriteLine();
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}