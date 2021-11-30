using System;
using System.Collections;

namespace Proyecto_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			// Variables de Abogado //
			string nomYape, especialidad;
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
						Console.WriteLine("\n !ATENCIÓN!\n" +
						                  "\nLuego de eliminar el Abogado, debe reasignar un nuevo Abogado a los Expedientes a cargo de este\n");
						
						Console.Write("Ingrese el DNI del abogado que desea eliminar: ");
						dni = int.Parse(Console.ReadLine());
						
						int cantExpe = e.cantExpeACargo(dni);
						
						if (e.listadoAbogados().Count != 0 && cantExpe > 0)
						{
							Console.WriteLine("\nExpedientes a cargo del Abogado que desea eliminar:\n");
							
							e.mostrarExp(dni);
							
							Console.Write("\nIngrese el número del Expediente para asignar un nuevo Abogado: ");
							int numExp = int.Parse(Console.ReadLine());
							int cont = 0;
							
							while (cont < cantExpe)
							{
								
								foreach (Expediente exp in e.listadoExp())
								{
									if (exp.Numero == numExp)
									{
										Console.WriteLine("\nLista de Abogados disponibles: \n");
										
										foreach (Abogado ab in e.listadoAbogados())
										{
											if (ab.Dni != dni)
											{
												Console.WriteLine(ab);
											}
										}
									}
								}
								
								Console.Write("DNI del Abogado que desea asignarle al Expediente: ");
								int dniNuevo = int.Parse(Console.ReadLine());
								
								foreach (Abogado abo in e.listadoAbogados())
								{
									if (abo.Dni == dniNuevo)
									{
										foreach (Expediente expe in e.listadoExp())
										{
											expe.AbogadoAcargo = abo;
											e.sumarExpAbogado(dniNuevo);
											Console.WriteLine("\nEl nuevo Abogado ha sido asignado con éxito\n");
											break;
										}
										break;
									}
									break;
								}
								cont++;
								Console.Write("\nIngrese el número del siguiente Expediente: ");
								numExp = int.Parse(Console.ReadLine());
							}
						}
						
						else
						{
							Console.WriteLine("\nEl Abogado ingresado no poseé Expedientes a Cargo\n");
							e.eliminarAbogado(dni);
						}
						
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
							
							Console.Write("Ingrese el DNI del Abogado que desea asignarle el Expediente: ");
							dni = int.Parse(Console.ReadLine());
							
							foreach (Abogado ab in e.listadoAbogados())
							{
								if (ab.Dni == dni)
								{
									e.agregarExpediente(new Expediente(nroExp, titular, tipoTramite, estado, ab));
									e.sumarExpAbogado(dni);
								}
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