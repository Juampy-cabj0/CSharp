using System;
using System.Collections;

namespace Práctica_5_Ej_1
{
	/// <summary>
	/// Description of Alumnos.
	/// </summary>
	public class Alumnos
	{
		private string nombreApellido, dni, materia, dia, horario;
		private ArrayList listHorario;
		
			/*1) Implemente la clase Alumno para modelar alumnos en una Universidad. 
			 	  Agréguele como estado lo que considere necesario para el problema. 
				  Piense como implementaría los horarios de cursada de un alumno? 
				    (piense que debe guardar día, hora y materia a cursar en ese horario).
                  Como comportamiento Implemente el método  inscripcionACursada(string diahora, string materia); */
		
		public Alumnos(string nomApell, string xDni)
		{
			nombreApellido = nomApell;
			dni = xDni;
			listHorario = new ArrayList();
			
		}
		
		public Alumnos(string xMateria, string xDia, string xHora)
		{
			materia = xMateria;
			dia = xDia;
			horario = xHora;
		}
		
		public void inscripcionACursada(string dia, string hora, string materia)
		{
			//Busco en el array que no coincida el dia y horario de cursada 
			
			bool ocupado = false;
			
			foreach (Horario elemento in listHorario) {
				if (dia == elemento.Dia) {
					if (hora == elemento.Hora) {
						ocupado = true;
						break;
					}
				}
			}
			
			//Niego el valor de ocupado
			if (!ocupado) {
				Horario h = new Horario(dia, hora, materia);
				listHorario.Add(h);
			}
			
		}
		
		
		
	}
}
