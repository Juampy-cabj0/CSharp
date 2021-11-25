using System;

namespace Práctica_5_Ej_1
{
	/// <summary>
	/// Description of Horario.
	/// </summary>
	public class Horario
	{
		private string dia, hora, materia;
		
		
		public Horario(string xDia, string xHora, string xMateria)
		{
			dia = xDia;
			hora = xHora;
			materia = xMateria;
			
		}
		
		public string Dia
		{
			set { dia = value; }
			get { return dia; }
		}
		public string Hora
		{
			set { hora = value; }
			get { return hora; }
		}
		public string Materia
		{
			set { materia = value; }
			get { return materia; }
		}
		
	}
}
