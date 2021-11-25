using System;
using System.Collections;
using System.Collections.Generic;

namespace Parcial_Nro_3_Com_5
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Por cada operación realizada se ingresa el  apellido del cliente, el código de sucursal, el número de partida,
			//el tipo de operación y el importe. Informar al cliente el monto a abonar en concepto de comisión.
			//Al finalizar el proceso informar el monto total recaudado por las comisiones cobradas por las operaciones de venta realizadas.  (1p)
			
			int codSuc, importeInmueble, numPartida;
			string direcSucursal, locSucursal, tipoInmueble, apellidoTitular, nomInmobiliaria;
			
			Sucursal s1 = new Sucursal("", 0, "", "");
			Operacion operacion;
			
			ArrayList listaOrdenada  = s1.Lista_Operaciones_Inmobiliarias;
			
			int op = Menu();
			
			while (op != 5)
			{
				switch (op)
				{
					case 1:
						
						Console.Write("\nIngrese el nombre de la inmobiliaria (presione ENTER para salir): ");
						nomInmobiliaria = Console.ReadLine();
						
						while (nomInmobiliaria != "")
						{
							Console.Write("Ingrese el código de la sucursal: ");
							codSuc = int.Parse(Console.ReadLine());
							
							Console.Write("Ingrese la dirección: ");
							direcSucursal = Console.ReadLine();
							
							Console.Write("Ingrese la localidad: ");
							locSucursal = Console.ReadLine();
							
							s1 = new Sucursal(nomInmobiliaria, codSuc, direcSucursal, locSucursal);
							s1.cargarSucursales(s1);
							
							Console.Write("\nIngrese el nombre de la inmobiliaria (presione ENTER para salir): ");
							nomInmobiliaria = Console.ReadLine();
							
						}
						break;
						
					case 2:
						
						Console.Write("Ingrese el código de la sucursal: ");
						codSuc = int.Parse(Console.ReadLine());
						
						Console.Write("Ingrese el tipo de inmueble (alquiler o venta): ");
						tipoInmueble = Console.ReadLine();
						
						Console.Write("Ingrese el apellido de la persona titular del inmueble: ");
						apellidoTitular = Console.ReadLine();
						
						Console.Write("Ingrese el importe del inmueble: ");
						importeInmueble = int.Parse(Console.ReadLine());
						
						Console.Write("Ingrese el número de partida: ");
						numPartida = int.Parse(Console.ReadLine());
						
						operacion = new Operacion(codSuc, tipoInmueble, apellidoTitular, numPartida, importeInmueble);
						
						s1.agregar_Operaciones(operacion);
						
						ordenarPorIntercambio(ref listaOrdenada);
						
						break;
						
					case 3:
						
						foreach (Operacion element in listaOrdenada) 
						{
							Console.WriteLine(element.CodSucursal + "\n" +
							                  element.Tipo +"\n" +
							                  element.ApellidoTitular + "\n" +
							                  element.Importe + "\n" +
							                  element.NroPartida + "\n");
						}
						break;
						
						
				}
				Console.WriteLine();
				op = Menu();
			}
			
			
			
			
			
			
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Menu()
		{
			
			Console.Write("1. Agregar sucursal\n" +
			              "2. Realizar una operación\n" +
			              "3. Ver lista de operaciones\n" +
			              "4. Alquiler\n" +
			              "5. Salir\n" +
			              "\n" +
			              "Ingrese la opción numerica deseada: ");
			int opcion = int.Parse(Console.ReadLine());
			Console.WriteLine();
			return opcion;
		}
		
		private static void ordenarPorIntercambio (ref ArrayList datos)
		{
			int n = datos.Count;
			for (int i= 0 ; i<(n-1 ); i++)
			{
				for (int j=i+ 1 ; j<n; j++)
				{
					if ((( Operacion )datos[i]).Importe > ((Operacion) datos[j]).Importe)
					{
						Operacion swap = (Operacion) datos[i];
							datos[i] = datos[j];
							datos[j] = swap;
						}
				}
			}
		}
	}
}