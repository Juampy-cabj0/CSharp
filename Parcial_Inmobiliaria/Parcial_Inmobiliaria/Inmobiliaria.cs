using System;
using System.Collections;

namespace Parcial_Inmobiliaria
{
	/// <summary>
	/// Description of Inmobiliaria.
	/// </summary>
	public class Inmobiliaria
	{
		private string nombre;
		private ArrayList listaDuenios;
		private ArrayList listaPropiedades;
		
		
		public Inmobiliaria(string nombre)
		{
			this.nombre = nombre;
			listaDuenios = new ArrayList();
			listaPropiedades = new ArrayList();
		}

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public ArrayList ListaDuenios
		{
			get { return listaDuenios; }
			set { listaDuenios = value; }
		}

		public ArrayList ListaPropiedades
		{
			get { return listaPropiedades; }
			set { listaPropiedades = value; }
		}
		
		public void agregarPropiedades(Propiedad propiedad)
		{
			listaPropiedades.Add(propiedad);
			Console.WriteLine("\nLa propiedad fue agregada con éxito\n");
		}
		
		public void eliminarProp(int codProp)
		{
			foreach (Propiedad prop in listaPropiedades) 
			{
				if (prop.Codigo == codProp) 
				{
					eliminarDuenio(prop.Dni);
					listaPropiedades.Remove(prop);
					Console.WriteLine("\nLa propiedad ha sido eliminada de nuestra base de datos\n");
				}
			}
			
		}
		
		public void agregarDuenio(Dueño duenio)
		{
			listaDuenios.Add(duenio);
			Console.WriteLine("\nEl dueño fue agregado con éxito\n");

		}
		
		public void eliminarDuenio(int dniDuenio)
		{
			foreach (Dueño duenio in ListaDuenios) 
			{
				if (duenio.Dni == dniDuenio) 
				{
					listaDuenios.Remove(duenio);
					Console.WriteLine("\nEl dueño ha sido eliminada de nuestra base de datos\n");
				}
			}
		}
		
		public string verificacionDeReserva(int codPropiedad)
		{
			foreach (Propiedad prop in listaPropiedades) 
			{
				if (prop.Codigo == codPropiedad) 
				{
					return prop.Estado;
				}
			}
			return "";
		}
		
		public void alquilerProp(int codProp)
		{
			foreach (Propiedad element in listaPropiedades)
			{
				if (element.Codigo == codProp && element.Estado == "disponible")
				{
					element.Estado = "Alquilado";
					Console.WriteLine("\nSu alquiler se realizó con éxito\n");
				}
			}
		}
		
		public double ventaProp(int codProp)
		{
			double precioVenta = 0;
			
			foreach (Propiedad element in listaPropiedades)
			{
				if (element.Codigo == codProp && element.Estado == "disponible")
				{
					precioVenta = element.Precio;
					eliminarProp(codProp);
					Console.WriteLine("\nLa venta se realizó con éxito\n");
					break;
				}
			}
			return precioVenta;
		}
		
		public void seniarProp(int codProp, double senia)
		{
			foreach (Propiedad prop in listaPropiedades) 
			{
				if (prop.Codigo == codProp && prop.Estado == "disponible") 
				{
					prop.Senia = senia;
					prop.Estado = "reservada";
					Console.WriteLine("\nLa seña se genero con éxito\n");
				}
			}
		}
		
		public void cancelarReserva(int codProp)
		{
			foreach (Propiedad prop in listaPropiedades) 
			{
				if (prop.Codigo == codProp && prop.Estado == "reservada")
				{
					prop.Senia = 0;
					prop.Estado = "disponible";
					Console.WriteLine("Su cancelación se realizó con éxito");
				}
			}
		}
	}
}
