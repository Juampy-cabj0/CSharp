using System;

namespace Practica_6_Ej_3
{
	public class Coordinador : Profesor
	{
		private string area;
		
		public Coordinador(string materia, int cupo, string area) : base(materia, cupo)
		{
			this.area = area;
		}
	}
}
