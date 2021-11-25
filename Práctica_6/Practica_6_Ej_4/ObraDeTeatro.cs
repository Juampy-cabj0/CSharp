using System;
using System.Collections;

namespace Practica_6_Ej_4
{
	public class ObraDeTeatro : Espectaculo
	{
		private string titulo;
		private double precio;
		private Butaca b1;
		private Butaca [] listaButacas;
		
		public ObraDeTeatro(int sala, string titulo, double precio) : base(sala)
		{
			this.titulo = titulo;
			this.precio = precio;
			listaButacas = new Butaca[10];
			
			for (int i = 0; i < listaButacas.Length; i++)
			{
				Butaca butacaInicial = new Butaca("libre", i+1);
				listaButacas[i] = butacaInicial;
			}
			
		}
		
		public void venderEntrada(Espectador unEsp)
		{
			bool ocupado = false;
			
			string nomEsp = unEsp.Nombre;
			string apeEsp = unEsp.Apellido;
			int dniEsp = unEsp.Dni;
			int cantEntEsp = unEsp.CantEntradas;
			
			
			
			
//			foreach (Butaca element in listaButacas)
//			{
//				if (element.Estado == "ocupado")
//				{
//					ocupado = true;
//					Console.WriteLine("La butaca ya esta ocupada");
//					break;
//				}
//			}

//			if (!ocupado)
//			{
				for (int i = 0; i < cantEntEsp; i++)
				{
//					if (b1.Estado != "libre")                                    /* No me reconoce la condicion de (b1.Estado == "libre") */
//					{                                                            /* A su vez, repite la persona acorde a las entradas solicitadas */
						b1 = new Butaca(nomEsp, apeEsp, dniEsp, cantEntEsp, i+1);
						listaButacas[i] = b1;                                    /* Cuando quiero seguir cargando personas para guardarlas, me pisa la anterior y guarda la ultima ingresada*/
						b1.Estado = "ocupado";                                   /* Busco que el numero de butacas sea asignado mediante el orden de compra */
						                                                        /* Probe con varias formas pero, no me estoy dando cuenta de mi error */
//					}
				}
				
				Console.WriteLine("\nLa butaca fue reservada con éxito\n");
//			}
			
			
			
		}
		
		
		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}

		public double Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		public Butaca[] ListaButacas
		{
			get { return listaButacas; }
			set { listaButacas = value; }
		}
	}
}
