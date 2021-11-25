using System;
using System.Collections;

namespace Parcial_2_Clinica
{
	public class Clinica
	{
		protected string nombreClinica;
		protected int cuit;
		protected ArrayList listaMedicos;
		
		public Clinica(string nombreClinica, int cuit)
		{
			this.nombreClinica = nombreClinica;
			this.cuit = cuit;
			listaMedicos = new ArrayList();
		}

		// Contratar Medicos y listarMedicosGuardia(string dia)
		public void contratarMedico(Medico unMed)
		{
			listaMedicos.Add(unMed);
		}
		
		public void listarMedicosGuardia(string dia)
		{
			foreach (Medico medico in listaMedicos)
			{
				if (medico.Dia == dia)
				{
					Console.WriteLine("Nombre: {0}\n" +
					                  "Apellido: {1}\n" +
					                  "Legajo: {2}\n" +
					                  "Especialidad: {3}\n" +
					                  "Día: {4}\n" +
					                  "Cantidad de Horas: {4}\n",
					                  medico.NombreMedico, medico.ApellidoMedico, medico.LegajoMedico, medico.Dia, medico.CantHoras);
				}
			}
		}
		
		// Método de Ordenamiento //
		public void listaOrdenadaPorHora(ref ArrayList listMedicos)
		{
			for (int i = 0; i < listMedicos.Count-1; i++)
			{
				for (int j = i+1; j < listMedicos.Count; j++)
				{
					if (((Medico)listMedicos[i]).CantHoras > ((Medico)listMedicos[j]).CantHoras)
					{
						Medico intercambio = (Medico)listMedicos[i];
						listMedicos[i] = listMedicos[j];
						listMedicos[j] = intercambio;
					}
				}
			}
		}
		
		// Polimorfismo
		public virtual void imprimirDatos()
		{
			Console.WriteLine("Nombre de la Clínica: {0}\n" +
			                  "CUIT: {1}",
			                  nombreClinica, cuit);
		}
	}
}
