using System;
using System.Collections;

namespace Practica_6_Ej_3
{
	public class Profesor
	{
		protected string materia;
		protected int cupoDisponible;
		protected ArrayList alumnos;
		
		public Profesor(string materia, int cupo)
		{
			this.materia = materia;
			cupoDisponible = cupo;
			alumnos = new ArrayList();
		}
		
		public void altaAlumno(Alumno e)
		{
			alumnos.Add(e);
			cupoDisponible -= 1;
		}
		
		public int Cupo
		{
			set { cupoDisponible = value; }
			get { return cupoDisponible; }
		}
		
		public ArrayList Alumnos
		{
			set { alumnos = value; }
			get { return alumnos; }
		}
	}
}
