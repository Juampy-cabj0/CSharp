using System;
using System.Collections;

namespace Clase_Mascota
{
	/// <summary>
	/// Description of Veterinaria.
	/// </summary>
	public class Veterinaria
	{
		
		/* Vamos a realizar una aplicación que:
            cree una instancia de la clase Veterinaria de nombre “Huesitos” en donde se carguen varias mascotas.
            simule la atención de alguna mascota.
            indique la cantidad total de mascotas atendidas al final del proceso.
           Imprima el listado de mascotas de mas de 5 años */
		
		private string nombreVete;
		private Mascota [] listaMascotas;
		private int cantidadMascotas;
		
		public Veterinaria()
		{
			listaMascotas = new Mascota [100];
			cantidadMascotas=0;
		}
		public string NombreVete{
			set { nombreVete=value;}
			get { return nombreVete;}
		}
		public int CantidadMascotas{
			set { cantidadMascotas=value;}
			get { return cantidadMascotas;}
		}
		public Mascota[] ListaMascotas
		{
			get { return listaMascotas;}
		}
		public void agregarMascota(Mascota unaM)
		{  
			listaMascotas[cantidadMascotas] = unaM;
			cantidadMascotas+=1;
		}
		
		public void eliminarMascota(Mascota unaM)
		{    
			int pos=Array.IndexOf(listaMascotas,unaM);
			listaMascotas[pos] = null; //en un Array no se puede borrar elemento
			cantidadMascotas-=1; 
		}

		public int totalMascotas()
		{     
			return cantidadMascotas;
		}

		public Mascota verDatosDeUnaMascota( int pos)
		{
			return  listaMascotas[pos];
		}
		
		public void atenderMascota(string nameM, string nameDue, string nuevodiag)
		{
			foreach(Mascota m in listaMascotas)
			{
				if ((m.Nombre==nameM) && (m.NombreDelDueño==nameDue) )
				{  
					m.Diagnostico=nuevodiag;
					break;
				}
			}
		}		
		
	}
}
