using System;
using System.Collections;

namespace Parcial_Nro_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Concesionario s1 = new Sucursal(1, "Belgrano", "Tu Auto Ya", "Juan");
			
			Console.WriteLine("CARGAR DATOS DE LOS AUTOS\n" +
			                  "-------------------------");
			
			Console.Write("Marca: ");
			string marca = Console.ReadLine();
			
			while (marca != "")
			{
				Console.Write("Modelo: ");
				string modelo = Console.ReadLine();
				
				Console.Write("Precio: ");
				double precio = double.Parse(Console.ReadLine());
				
				s1.agregarAutos(new Auto(marca, modelo, precio));
				
				Console.Write("Marca: ");
				marca = Console.ReadLine();
			}
			
			int contFiat = s1.cantidadFiat();
			
			Console.WriteLine("La cantidad de autos Fiat ingresados es de: {0}", contFiat);
			
			
			ArrayList listaOrdenada = s1.ListaAutos;
			
			s1.listaOrdenadaPorPrecio(ref listaOrdenada);
			
			foreach (Auto auto in listaOrdenada)
			{
				Console.WriteLine("Modelo: {0}, Marca: {1}, Precio: {2}", auto.ModeloAuto, auto.MarcaAuto, auto.PrecioAuto);
			}
			
			int [] listaNum = new int[]{5, -5, -1, -10};
			
			Console.WriteLine("\nLa suma es: {0}", sumaNumColeccion(listaNum, 0));
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		// Función Recursiva // Suma de valores positivos //
		public static int sumaNumColeccion(int [] listaNum, int pos)
		{
			int suma = 0;
			
			if (pos < listaNum.Length)
			{
				if (listaNum[pos] > 0)
				{
					suma += listaNum[pos];
					return suma + sumaNumColeccion(listaNum, pos+1);
				}
			}

			return suma;
		}
	}
}