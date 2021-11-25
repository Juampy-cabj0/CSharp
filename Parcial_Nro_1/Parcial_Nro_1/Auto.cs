using System;

namespace Parcial_Nro_1
{
	public class Auto
	{
		private string marcaAuto;
		private string modeloAuto;
		private double precioAuto;
		
		public Auto(string marcaAuto, string modeloAuto, double precioAuto)
		{
			this.marcaAuto = marcaAuto;
			this.modeloAuto = modeloAuto;
			this.precioAuto = precioAuto;
		}

		public string MarcaAuto
		{
			get { return marcaAuto; }
			set { marcaAuto = value; }
		}

		public string ModeloAuto
		{
			get { return modeloAuto; }
			set { modeloAuto = value; }
		}

		public double PrecioAuto
		{
			get { return precioAuto; }
			set { precioAuto = value; }
		}
	}
}
