using System;
using System.Collections;

namespace Parcial_Nro_3_Com_5
{
	/// <summary>
	/// Description of Inmobiliaria.
	/// </summary>
	public class Inmobiliaria
	{
		private string nombre;
		private ArrayList lista_Sucursales;
		
		
		public Inmobiliaria(string nom)
		{
			nombre = nom;
			lista_Sucursales = new ArrayList();
		}
		
		public void cargarSucursales(Sucursal xSucursal)
		{
			lista_Sucursales.Add(xSucursal);
		}
		
	}
}
