using System;

namespace Ejemplo_Class
{
	class Program
	{
		public static void Main(string[] args)
		{
			Veterinaria v1 = new Veterinaria("Huesitos");

			cargarMascotas(v1);
			
			for (int i = 0; i < v1.Cant_Mascotas; i++) {
				Console.WriteLine();
				Console.WriteLine( v1.Lista_Mascota[i]); /* Muestro el objeto entero sobreescribiendo el método ToString */
				
			}
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		
		public static void cargarMascotas(Veterinaria v)
		{
			string nom_Mascota;
			string nom_dueño;
			string raza;
			string diag;
			int edad;
			Mascota m;
			
			Console.Write("Ingrese el nombre de la mascota: ");
			nom_Mascota = Console.ReadLine();
			
			while (nom_Mascota != "")
			{
				
				Console.Write("Ingrese el nombre del dueño: ");
				nom_dueño = Console.ReadLine();
				
				Console.Write("Ingrese la raza de la mascota: ");
				raza = Console.ReadLine();
				
				Console.Write("Ingrese la edad de la mascota: ");
				edad = int.Parse(Console.ReadLine());
				
				m = new Mascota(nom_Mascota, nom_dueño, raza, edad);
				
				Console.Write("Ingrese el diagnostico: ");
				diag = Console.ReadLine();
				
				m.Diagnostico = diag;
				
				v.agregarMascota(m);
				
				Console.WriteLine();
				
				Console.Write("Ingrese el nombre de la mascota: ");
				nom_Mascota = Console.ReadLine();
				
			}
		}
		
		
	}
}