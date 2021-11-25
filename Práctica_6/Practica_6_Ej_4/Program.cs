using System;

namespace Practica_6_Ej_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			const double precio = 1500;
			int recaudacion = 0;
			
			ObraDeTeatro obra1 = new ObraDeTeatro(1, "El fantasma de la opera", precio);
			
			Console.WriteLine("Ingrese los datos de la persona que desea adquirir una entrada: \n");
			
			Console.Write("Nombre: ");
			string nom = Console.ReadLine();
			
			while (nom != "")
			{
				Console.Write("Apellido: ");
				string ape = Console.ReadLine();
				
				Console.Write("DNI: ");
				int dni = int.Parse(Console.ReadLine());
				
				Console.Write("Cantidad de entradas: ");
				int cantEnt = int.Parse(Console.ReadLine());
				
				Espectador e1 = new Espectador(nom, ape, dni, cantEnt);
				obra1.venderEntrada(e1);
				
				Console.Write("Nombre: ");
			    nom = Console.ReadLine();
				
				
			}
			
			foreach (Butaca b in obra1.ListaButacas) /* Esto es para verificar que la informacion se cargue correctamente */
			{
				Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}", b.NomEsp, b.ApeEsp, b.DniEsp, b.CatEntraEsp, b.Estado, b.NumButacaEsp); 
			}

			
			
			Console.WriteLine();
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	   /* 4) Dado el siguiente enunciado:
             Un espectáculo se realiza en una sala con una capacidad determinada de butacas. Una obra de teatro es un espectáculo que tiene un título descriptivo y un precio. 
			 Cada espectador que compra una entrada informa su nombre y apellido, su dni y se le asigna un número de butaca.
			
           A. Diseñar las clases Espectaculo, ObraDeTeatro, Butaca y Espectador (defina sus variables de instancia) e implementar de cada una el constructor correspondiente, usando herencia cuando sea necesario.
			
           B. Implementar el método venderEntrada(Espectador unEsp) que le asigna una butaca libre al espectador y modifica la información correspondiente a la obra de teatro (cantidad de butacas libres y la ocupación de la butaca). 
			  A qué clase pertenece este método?
			
           C. En un programa de aplicación (Main) cree la obra de teatro ‘El fantasma de la ópera’, ingresando por teclado el precio de la misma. 
			  Simule la venta de entradas a varios espectadores, asignándole su butaca siempre y cuando haya entradas disponibles.
			  Al final del proceso informe la cantidad total de entradas solicitadas, la cantidad que fueron vendidas y la recaudación final. */
		
		
		
		
	}
}