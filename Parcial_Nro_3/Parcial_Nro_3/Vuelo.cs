using System;
using System.Collections;

namespace Parcial_Nro_3
{
	/// <summary>
	/// Description of Avion.
	/// </summary>
	public class Vuelo
	{
		private int codigoVuelo;
		private string fechaSalida;
		private string horaSalida;
		private string origen;
		private string destino;
		private string duracionVuelo;
		private string conjuntoAsiento;
		private ArrayList listaAsientos;
		
		public Vuelo(int codigoVuelo, string fechaSalida, string horaSalida, string origen, string destino, string duracionVuelo, string conjuntoAsiento)
		{
			this.codigoVuelo = codigoVuelo;
			this.fechaSalida = fechaSalida;
			this.horaSalida = horaSalida;
			this.origen = origen;
			this.destino = destino;
			this.duracionVuelo = duracionVuelo;
			this.conjuntoAsiento = conjuntoAsiento;
			listaAsientos = new ArrayList();
		}
		
		public int CodigoVuelo
		{
			set { codigoVuelo = value; }
			get { return codigoVuelo; }
		}
		
		public string FechaSalida
		{
			set { fechaSalida = value; }
			get { return fechaSalida; }
		}
		
		public string HoraSalida
		{
			set { horaSalida = value; }
			get { return horaSalida; }
		}
		
		public string Origen
		{
			set { origen = value; }
			get { return origen; }
		}
		
		public string Desttino
		{
			set { destino = value; }
			get { return destino; }
		}
		
		public string DuracionVuelo
		{
			set { duracionVuelo = value; }
			get { return duracionVuelo; }
		}
		
		public string ConjuntoAsiento
		{
			set { conjuntoAsiento = value; }
			get { return conjuntoAsiento; }
		}
		
		public ArrayList ListaAsientos
		{
			set { listaAsientos = value; }
			get { return listaAsientos; }
		}
		
		public void ventaPasaje(int codVuelo, int nroAsiento, int dni, string estado, string apellido)
		{
			bool existe = false;
			Asiento a1 = new Asiento(codigoVuelo, nroAsiento, dni, estado, apellido);
			
			
			foreach (Asiento elemento in listaAsientos) 
			{
				if (elemento.CodVuelo == codVuelo && elemento.NroAsiento == nroAsiento) 
				{
					existe = true;
					break;
				}
			}
			
			if (existe) 
			{
				Console.WriteLine("El asiento esta ocupado.");
			}
			
			else
			{
				listaAsientos.Add(a1);
				Console.WriteLine("\nEl vuelo ha sido reservado correctamente.");
			}
			
			
		}
		
		public void ocuparAsiento(Asiento asiento)
		{
			listaAsientos.Add(asiento);
		}
		
		public void cancelarVuelo(int dni)
		{
			bool existe = false;
			int cont = 0;
			
			foreach (Asiento element in listaAsientos)
			{
				if (element.DniPasajero == dni) 
				{
					existe = true;
					cont++;
					break;
				}
			}
			
			if (existe) 
			{
				listaAsientos.RemoveAt(cont);
				Console.WriteLine("\nEl vuelo ha sido cancelado correctamente.");
			}
			
			else
			{
				Console.WriteLine("\nLa persona no cuenta con un vuelo.");
			}
			
		}
		
		
	}
}
