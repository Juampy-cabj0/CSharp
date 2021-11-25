using System;
using System.Collections;

namespace Parcial_2_Clinica
{
	public class Oftalmologia : Clinica
	{
		private string horaDeGuardia; // Desde - Hasta
		
		public Oftalmologia(string nombreClinica, int cuit, string horaDeGuardia) : base(nombreClinica, cuit)
		{
			this.horaDeGuardia = horaDeGuardia;
		}

		public string HoraDeGuardia {
			get { return horaDeGuardia; }
			set { horaDeGuardia = value; }
		}
		
		public ArrayList ListaMedicos
		{
			set { listaMedicos = value; }
			get { return listaMedicos; }
		}
		
		public double cantEspeTransplanteCorneas()
		{
			int cantEspeTransplanteCorneas = 0;
			
			foreach (Medico medico in listaMedicos)
			{
				if (medico.Especialidad == "transplante de corneas")
				{
					cantEspeTransplanteCorneas++;
				}
			}
			if (listaMedicos.Count != 0)
			{
				cantEspeTransplanteCorneas = (cantEspeTransplanteCorneas * 100) / listaMedicos.Count;
			}
			return cantEspeTransplanteCorneas;
		}
		
		
		// Polimorfismo
		public override void imprimirDatos()
		{
			base.imprimirDatos();      //Imprime el mensaje de la clase base (superclase)
			Console.WriteLine("Horario de Guardia: {0}\n", horaDeGuardia);
		}
	}
}
