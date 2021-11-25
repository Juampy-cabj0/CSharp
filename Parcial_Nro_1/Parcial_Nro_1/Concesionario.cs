using System;
using System.Collections;

namespace Parcial_Nro_1
{
	public class Concesionario
	{
		protected ArrayList listaAutos;
		protected string nombreConcesionario;
		protected string gerenteConcesionario;
		
		public Concesionario(string nombreConcesionario, string gerenteConcesionario)
		{
			this.nombreConcesionario = nombreConcesionario;
			this.gerenteConcesionario = gerenteConcesionario;
			listaAutos = new ArrayList();
		}
		
		public void agregarAutos(Auto car)
		{
			listaAutos.Add(car);
		}
		
		public void listadoDeAutos()
		{
			foreach (Auto auto in listaAutos)
			{
				if (auto.PrecioAuto > 250000)
				{
					Console.WriteLine("Marca: {0}	Modelo: {1}	Precio: {2}", auto.MarcaAuto, auto.ModeloAuto, auto.PrecioAuto);
				}
			}
		}
		
		// Polimorfismo en Herencia //
		public virtual void imprimirDatos()
		{
			Console.WriteLine("Nombre del Concesionario: {0}	Gerente: {1}", nombreConcesionario, gerenteConcesionario);
		}
		
		// Método de Ordenamiento //
		public ArrayList listaOrdenadaPorPrecio(ref ArrayList listAutos)
		{
			for (int i = 0; i < listAutos.Count-1; i++)
			{
				for (int j = i+1; j < listAutos.Count; j++)
				{
					if (((Auto)listAutos[i]).PrecioAuto < ((Auto)listAutos[j]).PrecioAuto)
					{
						// Al usar este método, siempre debo usar una variable de intermediario //
						Auto intercambio = (Auto)listAutos[i];
						listAutos[i] = listAutos[j];
						listAutos[j] = intercambio;
					}
				}
			}
			return listAutos;
		}
		
		public int cantidadFiat()
		{
			int contFiat = 0;
			
			foreach (Auto auto in listaAutos)
			{
				if (auto.MarcaAuto == "fiat")
				{
					contFiat++;
				}
			}
			return contFiat;
		}
		

		
		public ArrayList ListaAutos
		{
			get { return listaAutos; }
			set { listaAutos = value; }
		}

		public string NombreConcesionario
		{
			get { return nombreConcesionario; }
			set { nombreConcesionario = value; }
		}

		public string GerenteConcesionario
		{
			get { return gerenteConcesionario; }
			set { gerenteConcesionario = value; }
		}
	}
}
