using System;
using System.Collections;

namespace Concesionario
{

	public class Concesionario
	{
		protected ArrayList autos;
		protected string nombre;
		protected string gerente;
		
		public Concesionario()
		{
			
		}
		
		public Concesionario(string xNombre, string xGerente)
		{
			nombre = xNombre;
			gerente = xGerente;
			autos = new ArrayList();
		}
		
		public ArrayList Autos
		{
			set { autos = value; }
			get { return autos; }
		}
		
		public string NombreCon
		{
			set { nombre = value; }
			get { return nombre; }
		}
		
		public string Gerente
		{
			set { gerente = value; }
			get { return gerente; }
		}
		
		
		public void agregarAutos(Auto e)
		{
			autos.Add(e);  
		}
		
		public void listado()
		{
			foreach (Auto element in autos) {
				if (element.Precio > 250000) {
					Console.WriteLine("Autos que superan el precio de $250.000: \n" +
					                  "Marca: {0}\n" +
					                  "Modelo: {1}", element.Marca, element.Modelo);
				}
			}
		}
		
		public virtual void imprimirDatos()
		{
			Console.WriteLine("Concesionaria: {0}\n" +
			                  "Gerente a cargo: {1}", nombre, gerente);
		}
				
		
	}
	
}
