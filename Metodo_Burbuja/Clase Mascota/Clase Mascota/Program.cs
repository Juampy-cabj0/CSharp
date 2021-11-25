using System;
using System.Collections;

namespace Clase_Mascota
{
	class Program
	{
		public static void Main(string[] args)
		{
			Veterinaria  vete;
			string sigue;
			vete= new Veterinaria();
			vete.NombreVete= "Huesitos";
			string nom, nomdue, esp;
			int edad;
			

			Console.WriteLine("Desea cargar una mascota?s/n");
			sigue= Console.ReadLine();
			
			while (sigue== "s")
			{
				Console.WriteLine("Ingrese nombre, dueño, especie y edad de una mascota");
				nom=Console.ReadLine();
				nomdue=Console.ReadLine();
				esp=Console.ReadLine();
				edad=int.Parse(Console.ReadLine());
				
				Mascota mas=new Mascota (nom,esp,nomdue,edad);
				vete.agregarMascota(mas);
				Console.WriteLine("Ingresa otra mascota?");
				sigue=Console.ReadLine();
			}
			
			int cant=0;
			
			Console.WriteLine("hay mascota a atender?s/n");
			sigue=Console.ReadLine();
			
			while (sigue == "s")
			{
				Console.WriteLine("Ingrese nombre de la mascota y del dueño:");
				nom = Console.ReadLine();
				nomdue = Console.ReadLine();
				
				Console.WriteLine("Ingrese diagnostico");
				string diag=Console.ReadLine();
				vete.atenderMascota(nom,nomdue,diag);
				
				cant+=1;
				
				Console.WriteLine("Hay otra mascota a atender?s/n");
				sigue=Console.ReadLine();
				
			}
			
			Console.WriteLine("El total de mascotas atendidas es {0}", cant);
			Console.ReadKey(true);
			

			/*imprimir el listado de mascotas con más de 5 años de edad*/

			Mascota [] conjmascotas=new Mascota[100];
			conjmascotas = vete.ListaMascotas;

			foreach( Mascota mas in conjmascotas)
			{
				if (mas.Edad > 5)
					Console.WriteLine(mas.Nombre);
			}
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}