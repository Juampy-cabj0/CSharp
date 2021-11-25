using System;

namespace Parcial_Inmobiliaria
{
	/// <summary>
	/// Description of Propiedad.
	/// </summary>
	public class Propiedad
	{
		private int codigo;
		private string direccion;
		private float superficie;
		private string tipoOpe; /* venta o alquiler*/
		private double precio;
		private int cantDormi;
		private string estado; /* disponible, alquilada o reservada*/
		private int dni;
		private double senia; /* en caso de estar reservada, dice cual es el monto señado */
		
		public Propiedad(int codigo, string direccion, float superficie, string tipoOpe, double precio, int cantDormi, string estado, int dni)
		{
			this.codigo = codigo;
			this.direccion = direccion;
			this.superficie = superficie;
			this.tipoOpe = tipoOpe;
			this.precio = precio;
			this.cantDormi = cantDormi;
			this.estado = estado;
			this.dni = dni;
			senia = 0;
			
		}

		public int Codigo 
		{
			get { return codigo; }
			set { codigo = value; }
		}

		public string Direccion 
		{
			get { return direccion; }
			set { direccion = value; }
		}

		public float Superficie 
		{
			get { return superficie; }
			set { superficie = value; }
		}

		public string TipoOpe 
		{
			get { return tipoOpe; }
			set { tipoOpe = value; }
		}

		public double Precio 
		{
			get { return precio; }
			set { precio = value; }
		}

		public int CantDormi
		{
			get { return cantDormi; }
			set { cantDormi = value; }
		}

		public string Estado 
		{
			get { return estado; }
			set { estado = value; }
		}

		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		public double Senia 
		{
			get { return senia; }
			set { senia = value; }
		}
	}
}
