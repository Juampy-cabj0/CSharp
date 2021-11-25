using System;
using System.Collections;

namespace Practica_6_Ej_4
{
	public class Espectaculo
	{
		protected int sala;
		protected ArrayList listaObrasDeTeato;
			
			
		public Espectaculo(int sala)
		{
			this.sala = sala;
			listaObrasDeTeato = new ArrayList();
		}
		
		public void cargarObras(ObraDeTeatro obra)
		{
			listaObrasDeTeato.Add(obra);
		}
	}
}
