using System;
using System.Collections;

namespace Práctica_5_Ej_1
{
	/// <summary>
	/// Description of Profesor.
	/// </summary>
	public class Profesor
	{
		private string nombreApellido;
		private ArrayList listMateria;
		

			/*2) Implemente la clase Profesor para modelar profesores en una Universidad.
				  Agréguele como estado lo que considere necesario para el problema.
				  Considere que un profesor conoce la lista de materias que dicta.
                  Como comportamiento Implemente el método dictadoDeCurso(string materia);*/
		
		public Profesor(string nomApell)
		{
			nombreApellido = nomApell;
			listMateria = new ArrayList();
			
		}
		
		public void dictadoDeCurso(string materia)
		{
			//Busco un elemento repetido dentro del array
			
			bool existe = false;
			
			foreach (string elemento in listMateria) {
				
				if (elemento == materia) {
					existe = true;
					break;
				}
			}
			
			if (existe) {
				Console.WriteLine("Materia repetida");
			}
			else {
				listMateria.Add(materia);
			}
			
		}
		
		public void dictadoDeCurso2(string materia)
		{
			//Busco en el array si hay un elemento repetido con Contains
			
			if(listMateria.Contains(materia))
			{
				Console.WriteLine("Materia repetida");
			}
			
			//Si no se repite, lo agrego a la lista
			else
				listMateria.Add(materia);
			
		}
	
		//Sobrecargo la clase ToString para mostrar el objeto
		
		public override string ToString()
		{
			string aux = nombreApellido;
			return aux;
		}
		
		
		public void Mostrar()
		{
			foreach (Profesor elemento in listMateria) {
				Console.WriteLine("Las materias dictadas por el profesor {0}", nombreApellido+ "son: " +elemento);
			}
			
		}
		
		
	}
}
