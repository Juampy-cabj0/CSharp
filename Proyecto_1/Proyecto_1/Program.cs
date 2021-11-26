using System;

namespace Proyecto_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Variables de Abogado //
			string nomYape, especialidad, especialidadExp;
			int dni;
			
			// Variables de Expediente //
			int nroExp;
			string titular, tipoTramite, estado;
			
			// Variable de respuesta para el loop //
			string resp;
			
			// Inicializo un Estudio //
			Estudio e = new Estudio("Perez y asociados");
			
			Console.WriteLine("*************************************\n" +
			                  "**** ESTUDIO 'PERÉZ Y ASOCIADOS' ****\n" +
			                  "*************************************\n" +
			                  "*************************************\n" +
			                  "******** ATENCIÓN AL CLIENTE ********\n" +
			                  "*************************************\n");
			do
			{
				string op = Menu();
				
				switch (op)
				{
					case "1":
						Console.Write("\nIngrese Nombre y Apellido del abogado: ");
						nomYape = Console.ReadLine();
						
						Console.Write("Ingrese el DNI: ");
						dni = int.Parse(Console.ReadLine());
						
						Console.Write("Ingrese el Tipo de Especialidad: ");
						especialidad = Console.ReadLine();
						
						e.agregarAbogado(new Abogado(nomYape, dni, especialidad));
						break;
						
					case "2":
						Console.Write("Ingrese el DNI del abogado que desea eliminar: ");
						dni = int.Parse(Console.ReadLine());
						
						e.eliminarAbogado(dni);
						break;
						
					case "3":
						foreach (Abogado ab in e.listadoAbogados())
						{
							Console.WriteLine(ab);
						}
						break;
						
					case "4":
						Console.Write("\nIngrese el Número de Expediente: ");
						nroExp = int.Parse(Console.ReadLine());
						
						Console.Write("Ingrese el Titular del Expediente: ");
						titular = Console.ReadLine();
						
						Console.Write("Ingrese el Tipo de Trámite: ");
						tipoTramite = Console.ReadLine();
						
						Console.Write("Ingrese el Estado del Expediente: ");
						estado = Console.ReadLine();
						
						if (e.listadoAbogados().Count != 0)
						{
							Console.WriteLine("\nLista de Abogado para asignar al Expediente:\n");
							
							foreach (Abogado ab in e.listadoAbogados())
							{
								Console.WriteLine(ab);
							}
							
							foreach (Abogado ab in e.listadoAbogados())
							{
								Console.Write("Ingrese el DNI del Abogado que desea asignarle el Expediente: ");
								dni = int.Parse(Console.ReadLine());
								
								if (ab.Dni == dni)
								{
									e.agregarExpediente(new Expediente(nroExp, titular, tipoTramite, estado, ab));
									e.sumarExpAbogado(dni);
									break;
								}
								break;
							}
							
						}
						
						else
						{
							Console.WriteLine("No hay Abogados para asignar al Expediente\n" +
							                  "Por favor, ingrese un Abogado\n");
						}
						break;
						
					case "5":
						Console.Write("\nIngrese el Número de Expediente: ");
						nroExp = int.Parse(Console.ReadLine());
						
						Console.Write("Ingrese el nuevo Estado del Expediente: ");
						estado = Console.ReadLine();
						
						e.modificarEstadoExp(nroExp, estado);
						break;
						
					case "6":
						Console.Write("\nIngrese el Número de Expediente que desea Eliminar: ");
						nroExp = int.Parse(Console.ReadLine());
						e.eliminarExp(nroExp);
						break;
						
					case "7":
						foreach (Expediente exp in e.listadoExp())
						{
							Console.WriteLine(exp);
						}
						
						break;
						
					case "8":
						Console.WriteLine("\nGracias por utilizar el programa.");
						resp = "n";
						continue;
						
					default:
						Console.WriteLine("Opción Incorrecta!\n" +
						                  "\nIngrese la Opción Númerica correctamente\n");
						break;
				}
				Console.Write("*********************************************************\n" +
				              "Desea continuar operando (s/n): ");
				resp = Console.ReadLine();
				
				if (resp == "n")
				{
					Console.WriteLine("\nHasta Pronto!");
				}
				else
					Console.Write("\n*********************************************************\n");
				
			}
			
			while(resp == "s");
			
			
			
			
			
			
			
			
			Console.Write("\nPress any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static string Menu()
		{
			Console.Write(" 1) Agregar Abogado\n" +
			              " 2) Eliminar Abogado\n" +
			              " 3) Listado de Abogados\n" +
			              " 4) Agregar Nuevo Expediente\n" +
			              " 5) Modificar Estado de Expediente\n" +
			              " 6) Eliminar Expediente\n" +
			              " 7) Listado de Expedientes\n" +
			              " 8) Salir\n");
			Console.Write("\nIngrese la opción deseada: ");
			string op = Console.ReadLine();
			return op;
		}
		
	}
}