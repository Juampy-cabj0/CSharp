using System;

namespace Parcial_2_Clinica
{
	public class Medico
	{
		private string nombreMedico;
		private string apellidoMedico;
		private int legajoMedico;
		private string especialidad;
		private string dia;
		private int cantHoras;
		
		public Medico(string nombreMedico, string apellidoMedico, int legajoMedico, string especialidad, string dia, int cantHoras)
		{
			this.nombreMedico = nombreMedico;
			this.apellidoMedico = apellidoMedico;
			this.legajoMedico = legajoMedico;
			this.especialidad = especialidad;
			this.dia = dia;
			this.cantHoras = cantHoras;
		}

		public string NombreMedico 
		{
			get { return nombreMedico; }
			set { nombreMedico = value; }
		}

		public string ApellidoMedico 
		{
			get { return apellidoMedico; }
			set { apellidoMedico = value; }
		}

		public int LegajoMedico 
		{
			get { return legajoMedico; }
			set { legajoMedico = value; }
		}

		public string Especialidad 
		{
			get { return especialidad; }
			set { especialidad = value; }
		}

		public string Dia 
		{
			get { return dia; }
			set { dia = value; }
		}

		public int CantHoras 
		{
			get { return cantHoras; }
			set { cantHoras = value; }
		}
	}
}
