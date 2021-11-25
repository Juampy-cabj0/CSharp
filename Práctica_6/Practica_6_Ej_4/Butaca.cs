using System;

namespace Practica_6_Ej_4
{
	public class Butaca
	{
		private string nomEsp;
		private string apeEsp;
		private int dniEsp;
		private int catEntraEsp;
		private string estado;
		private int numButacaEsp;
		
		public Butaca(string estado, int numButacaEsp)
		{
			this.estado = estado;
			this.numButacaEsp = numButacaEsp;
		}
		
		
		public Butaca(string nombre, string apellido, int dni, int catEntraEsp, int numBut)
		{
			nomEsp = nombre;
			apeEsp = apellido;
			dniEsp = dni;
			this.catEntraEsp = catEntraEsp;
			numButacaEsp = numBut;
		}

		public string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		public string NomEsp 
		{
			get { return nomEsp; }
			set { nomEsp = value; }
		}

		public string ApeEsp 
		{
			get { return apeEsp; }
			set { apeEsp = value; }
		}

		public int DniEsp 
		{
			get { 	return dniEsp; }
			set { 	dniEsp = value; }
		}

		public int CatEntraEsp 
		{
			get { return catEntraEsp; }
			set { catEntraEsp = value; }
		}
		public int NumButacaEsp 
		{
			get { return numButacaEsp; }
			set { numButacaEsp = value; }
		}
	}
}
