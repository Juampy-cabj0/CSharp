using System;

namespace Parcial_Inmobiliaria
{
	/// <summary>
	/// Description of Dueño.
	/// </summary>
	public class Dueño
	{
		private string nomYape;
		private int dni;
		private int celular;
		
		public Dueño(string nomYape, int dni, int celular)
		{
			this.nomYape = nomYape;
			this.dni = dni;
			this.celular = celular;
		}

		public string NomYape {
			get {
				return nomYape;
			}
			set {
				nomYape = value;
			}
		}

		public int Dni {
			get {
				return dni;
			}
			set {
				dni = value;
			}
		}

		public int Celular {
			get {
				return celular;
			}
			set {
				celular = value;
			}
		}
	}
}
