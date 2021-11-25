using System;
using System.Collections;

namespace Práctica_5_Ej_1
{
	/// <summary>
	/// Description of Universidad.
	/// </summary>
	public class Universidad
	{
		private ArrayList listaMateriasUniversidad;
		
		
		
		
		public Universidad()
		{
			/*4) Utilizando las clases definidas en los ejercicios anteriores implemente la clase Universidad que permita:
              a) La inscripción de alumnos a materias
              b) La asignación de profesores a las materias
              c) Listar el profesor y los alumnos de una determinada materia*/
			
			listaMateriasUniversidad = new ArrayList();
			
			
			
		}
		
		public void agregarMateria(Materia mate)
		{
			listaMateriasUniversidad.Add(mate);
		}
		
		public void asigProfeMate(string materia, Profesor profe)
		{
			foreach (Materia elemento in listaMateriasUniversidad) {
				
				if (elemento.Nombre == materia) {
					elemento.Profe = profe;
				}
				
			}
		}
		
		public void mostrarMateria(string mate)
		{
			bool encontro = false;
			
			foreach (Materia elemento in listaMateriasUniversidad) {
				if (elemento.Nombre == mate) {
					encontro = true;
					Console.WriteLine(elemento);
				}
				
			}
			
			if (!encontro) {
				throw new MateriaInexistente();
			}
			
		}
		
		
		public void mostrarLista()
		{
			Console.WriteLine("Esta es la lista de materias con un profe asignado");
			
			foreach (Materia x in listaMateriasUniversidad) {
				Console.WriteLine("Nombre: {0}, Profesor: {1}", x.Nombre, x.Profe);
			}
		}
		
		
	}
}
