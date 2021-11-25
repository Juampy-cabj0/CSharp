using System;
using System.Collections;

namespace Parcial_Nro_3_Com_5
{
	/// <summary>
	/// Description of Sucursal.
	/// </summary>
	public class Sucursal : Inmobiliaria
	{
		private int codigo;
		private string direccion, localidad;
		private ArrayList lista_Operaciones_Inmobiliarias;
		
		public Sucursal(string nom, int xCodigo, string xDireccion, string xLocalidad):base(nom)
		{
			codigo = xCodigo;
			direccion = xDireccion;
			localidad = xLocalidad;
			lista_Operaciones_Inmobiliarias = new ArrayList();
		}
		
		public int Codigo
		{
			set { codigo = value; }
			get { return codigo; }
		}
		
		public string Direccion
		{
			set { direccion = value; }
			get { return direccion; }
		}
		
		public string Localidad
		{
			set { localidad = value; }
			get { return localidad; }
		}
		
		public ArrayList Lista_Operaciones_Inmobiliarias
		{
			set { lista_Operaciones_Inmobiliarias = value; }
			get { return lista_Operaciones_Inmobiliarias; }
		}
		
		public void agregar_Operaciones(Operacion operacion)
		{
			lista_Operaciones_Inmobiliarias.Add(operacion);
		}		
		
	}
}
