using System;
using System.Collections;

namespace Parcial_Nro_3
{
	/// <summary>
	/// Description of Aeropuerto.
	/// </summary>
	public class Aeropuerto
	{
		private string nombre, ubicacion;
		private int vuelosDiarios;
		private ArrayList listaVuelos;
		
		public Aeropuerto(string nombre, string ubicacion, int vuelosDiarios)
		{
			this.nombre = nombre;
			this.ubicacion = ubicacion;
			this.vuelosDiarios = vuelosDiarios;
			listaVuelos = new ArrayList();
			
		}
		
		public string Nombre
		{
			set { nombre = value; }
			get { return nombre; }
		}
		
		public string Ubicacion
		{
			set { ubicacion = value; }
			get { return ubicacion; }
		}
		
		public int VuelosDiarios
		{
			set { vuelosDiarios = value; }
			get { return vuelosDiarios; }
		}
		
		public ArrayList ListaVuelos
		{
			set { listaVuelos = value; }
			get { return listaVuelos; }
		}
		
		public void agregarVuelo(Vuelo vuelo)
		{
			listaVuelos.Add(vuelo);
		}
		
		
	}
}
