using System;
using System.Collections;

namespace Práctica_5_Ej_1
{
	/// <summary>
	/// Description of Materia.
	/// </summary>
	public class Materia
	{
		private string nomMateria;
		private Profesor profe;
		private ArrayList listaAlumno;
		
		//3) Implemente la clase Materia que permita asociarle el profesor y la lista de los alumnos inscriptos en ella
		
		public Materia(string nom, Profesor xProfe, ArrayList lista)
		{
			nomMateria = nom;
			profe = xProfe;
			listaAlumno = lista;
		}
		
		public Materia(string nom, Profesor xProfe)
		{
			nomMateria = nom;
			profe = xProfe;
			listaAlumno = new ArrayList();
		} 
		
		public Materia(string nom)
		{
			nomMateria = nom;
			listaAlumno = new ArrayList();
		} 
		
		public void ingresarAlumno(Alumnos al)
		{
			listaAlumno.Add(al);
		}
		
		public string Nombre
		{
			set{ nomMateria = value; }
			get { return nomMateria; }
		}
		
		public Profesor Profe
		{
			set { profe = value; }
			get { return profe; }
		}
		
	}
}
