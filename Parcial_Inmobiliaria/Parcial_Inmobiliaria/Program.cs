using System;
using System.Collections;

namespace Parcial_Inmobiliaria
{
	class Program
	{
		public static void Main(string[] args)
		{
			Inmobiliaria inmo1 = new Inmobiliaria("Pérez y asociados");
			
			Console.Write("Desea cargar cargar Propiedades y a sus respectivos dueños? (s/n): " );
			string datos = Console.ReadLine();
			
			while (datos == "s")
			{
				Console.Write("\nCódigo de la propiedad: ");
				int codigo = int.Parse(Console.ReadLine());
				
				Console.Write("Dirección: ");
				string direc = Console.ReadLine();
				
				Console.Write("Superficie: ");
				float super = float.Parse(Console.ReadLine());
				
				Console.Write("Tipo de operación (Alquiler o Venta): ");
				string tipo = Console.ReadLine();
				
				Console.Write("Precio: ");
				double precio = double.Parse(Console.ReadLine());
				
				Console.Write("Cantidad de dormitorios: ");
				int cantDormi = int.Parse(Console.ReadLine());
				
				Console.Write("Estado (Disponible, Alquilada o Reservada): ");
				string estado = Console.ReadLine();
				
				Console.Write("DNI del dueño: ");
				int dni = int.Parse(Console.ReadLine());
				
				inmo1.agregarPropiedades(new Propiedad(codigo, direc, super, tipo, precio, cantDormi, estado, dni));
				
				Console.Write("Nombre y Apellido del dueño: ");
				string nomYape = Console.ReadLine();
				
				Console.Write("Ingrese el número de celular: ");
				int cel = int.Parse(Console.ReadLine());
				
				inmo1.agregarDuenio(new Dueño(nomYape, dni, cel));
				
				Console.Write("Desea cargar información? (s/n)?: " );
				datos = Console.ReadLine();
			}
			
			int codigoProp;
			int cantCancelaciones = 0;
			double precioTotalDeVenta = 0;
			
			int op = Menu();
			
			while (op > 0 && op < 5)
			{
				Console.Write("\nIngrese el código de la propiedad que desea alquilar: ");
				codigoProp = int.Parse(Console.ReadLine());
				
				if (op == 1 || op == 2 || op == 3) 
				{
					try 
					{
						string estado = inmo1.verificacionDeReserva(codigoProp);
						
						if (estado == "alquilada" || estado == "reservada") 
						{
							throw new PropiedadNoDisponible();
						}
						if (estado == "") 
						{
							throw new PropiedadNoExiste();
						}
					}
					
					catch (PropiedadNoDisponible)
					{
						Console.WriteLine("La propiedad NO se encuentra Disponible");
					}
					catch (PropiedadNoExiste)
					{
						Console.WriteLine("La propiedad no existe");
					}
				}
				
				switch (op)
				{
					case 1:
						inmo1.alquilerProp(codigoProp);
						break;
						
					case 2:
						precioTotalDeVenta += inmo1.ventaProp(codigoProp);
						break;
						
					case 3:
						Console.Write("Ingrese el valor de la seña: ");
						double valor = double.Parse(Console.ReadLine());
						
						inmo1.seniarProp(codigoProp, valor);
						break;
						
					case 4:
						inmo1.cancelarReserva(codigoProp);
						cantCancelaciones++;
						break;
				}
				op = Menu();
				
			}
			
			Console.WriteLine("\nEl monto total de propiedades vendidas es de: {0}\n" +
			                  "La cantidad de cancelaciones es de: {1}", precioTotalDeVenta, cantCancelaciones);
			
			PropVenta_Mas2Dormi(inmo1.ListaPropiedades, 0);
			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static int Menu()
		{
			Console.Write("\n          ATENCIÓN AL PÚBLICO\n" +
			              "----------------------------------------\n" +
			              "1) Alquiler\n" +
			              "2) Comprar\n" +
			              "3) Señar\n" +
			              "4) Cancelar reserva\n" +
			              "5) Salir\n" +
			              "Elija la operación que desea realizar: ");
			int op = int.Parse(Console.ReadLine());
			return op;
		}
		
		/*Función Recursiva*/ /*En esta ocasión, siempre debo castear los datos*/
		public static void PropVenta_Mas2Dormi(ArrayList listaProp, int pos)
		{
			if (pos < listaProp.Count)    /*El caso base de la da orden de corte. Siempre tiene que haber un caso base*/
			{
				/*Casteo la lista pasada por parametro para acceder a las propiedades*/
				if (((Propiedad)listaProp[pos]).TipoOpe == "venta" && ((Propiedad)listaProp[pos]).CantDormi > 2) 
				{
					Console.WriteLine("\nLista de propiedades con más de 2 habitaciones\n" +
					                  "Código: {0}\n" +
					                  "Precio: {1}\n" +
					                  "Cantidad de Dormitorios: {2}\n",
					                  ((Propiedad)listaProp[pos]).Codigo, ((Propiedad)listaProp[pos]).Precio, ((Propiedad)listaProp[pos]).CantDormi);
				}
				/*LLamo a la función e incremento la posición para ir accediendo a distintos elementos de la lista*/
				PropVenta_Mas2Dormi(listaProp, pos + 1);
			}
		}
	}
}