using System;
using System.Collections;

namespace Proyecto_1
{
	public class Estudio
	{
		private string nombreEstudio;
		private ArrayList listaAbogados;
		private ArrayList listaExpedientes;
		
		public Estudio(string nombreEstudio)
		{
			this.nombreEstudio = nombreEstudio;
			listaAbogados = new ArrayList(5);
			listaExpedientes = new ArrayList();
		}

		public string NombreEstudio
		{
			get { return nombreEstudio; }
			set { nombreEstudio = value; }
		}
		
		public void agregarAbogado(Abogado abogado)
		{
			bool existe = false;
			if (listaAbogados.Count != 0)
			{
				foreach (Abogado ab in listaAbogados)
				{
					if (ab.Equals(abogado))
					{
						existe = true;
						Console.WriteLine("\nEl abogado ya existe en la base de datos\n");
						break;
					}
				}
			}
			
			if (!existe)
			{
				try
				{
					if (listaAbogados.Count > 4)
					{
						throw new BuffetLleno();
					}
					
					listaAbogados.Add(abogado);
					Console.WriteLine("\nEl abogado fue ingresado con éxito\n");
				}
				catch (BuffetLleno)
				{
					Console.WriteLine("\nBuffet de Abogados lleno\n");
				}
			}
		}
		
		public void eliminarAbogado(int dni)
		{
			bool existe = false;
			foreach (Abogado ab in listaAbogados)
			{
				if (ab.Dni == dni)
				{
					existe = true;
					eliminarAbogadoDelExp(ab.Dni);
					listaAbogados.Remove(ab);
					Console.WriteLine("\nEl abogado fue eliminado con éxito\n");
					break;
				}
			}
			
			if(!existe)
			{
				if (listaAbogados.Count == 0)
				{
					Console.WriteLine("\nLista de Abogados vacía\n");
				}
				else
					Console.WriteLine("\nEl abogado no existe en la base de datos\n");
			}
		}
		
		public ArrayList listadoAbogados()
		{
			return listaAbogados;
		}
		
		public void agregarExpediente(Expediente unExp)
		{
			bool existeExp = false;
			if (listaExpedientes.Count != 0)
			{
				foreach (Expediente exp in listaExpedientes)
				{
					if (exp.Equals(unExp))
					{
						existeExp = true;
						Console.WriteLine("\nEl Expediente ingresado ya se encuentra en la base de datos\n");
						break;
					}
				}
			}
			
			if (!existeExp)
			{
				if (unExp.AbogadoAcargo.CantExpAsig < 6)
				{
					listaExpedientes.Add(unExp);
					Console.WriteLine("\nEl expediente fue ingresado con éxito\n");
				}
			}
		}
		
		public void modificarEstadoExp(int numExp, string estado)
		{
			bool existe = false;
			foreach (Expediente exp in listaAbogados)
			{
				if (exp.Numero == numExp)
				{
					existe = true;
					exp.Estado = estado;
					Console.WriteLine("\nEl estado del expediente fue modificado con éxito\n");
					break;
				}
			}
			
			if (!existe)
			{
				if (listaAbogados.Count == 0)
				{
					Console.WriteLine("\nLista de Expedientes vacía\n");
				}
				else
					Console.WriteLine("\nNo existe el Número de Expediente ingresado\n");
			}
		}
		
		public void eliminarExp(int numExp)
		{
			foreach (Expediente exp in listaExpedientes)
			{
				if (exp.Numero == numExp)
				{
					restarExpAbogado(exp.AbogadoAcargo.Dni);
					listaExpedientes.Remove(exp);
					Console.WriteLine("\nEl expediente se elimino con éxito\n");
					break;
				}
			}
			
		}
		
		public void restarExpAbogado(int dni)
		{
			foreach (Abogado ab in listaAbogados)
			{
				if (ab.Dni == dni)
				{
					if (ab.CantExpAsig > 0)
					{
						ab.CantExpAsig--;
					}
					
					break;
				}
			}
		}
		
		public void sumarExpAbogado(int dni)
		{
			
			foreach (Abogado ab in listaAbogados)
			{
				if (ab.Dni == dni)
				{
					try
					{
						if (ab.CantExpAsig > 5)
						{
							throw new LimiteDeExpedientes();
						}
						
						ab.CantExpAsig += 1;
						break;
					}
					catch (LimiteDeExpedientes)
					{
						Console.WriteLine("\nEl Abogado asignado al Expediente no tiene disponibilidad\n");
					}
				}
			}
		}
		
		public int cantExpeACargo(int dni)
		{
			int resultado = 0;
			
			if (listaAbogados.Count != 0)
			{
				foreach (Abogado ab in listaAbogados)
				{
					if (ab.Dni == dni)
					{
						resultado = ab.CantExpAsig;
					}
				}
			}
			return resultado;
		}
		
		public ArrayList listadoExp()
		{
			return listaExpedientes;
		}
		
		// Asigno valores
		public void eliminarAbogadoDelExp(int dni)
		{
			foreach (Expediente exp in listaExpedientes)
			{
				if (exp.AbogadoAcargo.Dni == dni)
				{
					exp.AbogadoAcargo.NomYape = " ";
					exp.AbogadoAcargo.Dni = 0;
					exp.AbogadoAcargo.Especialidad = " ";
					exp.AbogadoAcargo.CantExpAsig = 0;
				}
			}
		}
	}
}
