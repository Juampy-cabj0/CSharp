using System;

namespace Proyecto_1
{
	public class Expediente
	{
		private int numero;
		private string titular;
		private string tipoTramite;
		private string estado;
		private Abogado abogadoAcargo;
		private DateTime fechaPresentacion;
		
		
		public Expediente(int numero, string titular, string tipoTramite, string estado, Abogado abogado)
		{
			this.numero = numero;
			this.titular = titular;
			this.tipoTramite = tipoTramite;
			this.estado = estado;
			abogadoAcargo = abogado;
			fechaPresentacion = DateTime.Now;
		}

		public int Numero 
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Titular 
		{
			get { return titular; }
			set { titular = value; }
		}

		public string TipoTramite 
		{
			get { return tipoTramite; }
			set { tipoTramite = value; }
		}

		public string Estado 
		{
			get { return estado; }
			set { estado = value; }
		}

		public Abogado AbogadoAcargo {
			get { return abogadoAcargo; }
			set { abogadoAcargo = value; }
		}
		
		public DateTime FechaPresentacion 
		{
			get { return fechaPresentacion; }
			set { fechaPresentacion = value; }
		}
		
		public override bool Equals(object obj)
		{
			Expediente otro = obj as Expediente;  // as = como //
			
			// Si el parámetro es nulo, devuelve falso.
			if (otro == null)
			{
				return false;
			}
			
			// Si el parámetro no se puede convertir a Expediente, devuelve falso.
			if ((Object)otro == null)
			{
				return false;
			}
			
			// Devuelve verdadero si los campos coinciden:
			return this.numero == otro.numero;
		}
		
		public override string ToString()
		{
			return string.Format("------------------------------------\n" +
			                     "Número de Expediente: {0}\n" +
			                     "Titular: {1}\n" +
			                     "Tipo Tramite: {2}\n" +
			                     "Estado: {3}\n" +
			                     "Fecha y Hora: {4}\n" +
			                     "------------------------------------\n" +
			                     "--------- Abogado a cargo: ---------\n" +
			                     "------------------------------------\n" +
			                     "Nombre de Abogado: {5}\n" +
			                     "DNI: {6}\n" +
			                     "Especialidad: {7}\n" +
			                     "------------------------------------\n",
			                     numero, titular, tipoTramite, estado, fechaPresentacion, AbogadoAcargo.NomYape, AbogadoAcargo.Dni, AbogadoAcargo.Especialidad);
		}

	}
}
