using System;

namespace Practica_6_Ej_4
{
	public class Espectador
	{
		private string nombre;
		private string apellido;
		private int dni;
		private int cantEntradas;
		private int [] numButaca;
		
		public Espectador(string nombre, string apellido, int dni, int cantEntradas)
		{
			this.nombre = nombre;
			this.apellido = apellido;
			this.dni = dni;
			this.cantEntradas = cantEntradas;

		}
		

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		public int CantEntradas 
		{
			get { return cantEntradas; }
			set { cantEntradas = value; }
		}
		
		public int [] NumButaca
		{
			get { return numButaca; }
			set { numButaca = value; }
		}
	}
}
