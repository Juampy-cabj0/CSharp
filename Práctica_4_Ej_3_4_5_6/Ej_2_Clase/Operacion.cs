using System;

namespace Ej_2_Clase
{
//	7) Cree una clase llamada Operación con tres campos: operando1, operando2 y operador. 
//	   Cada instancia creada deberá devolver el resultado correspondiente mediante la llamada a un método evaluar que será encargado de efectuar la operación solicitada. 
//	   El programa de aplicación deberá imprimir todos los resultados calculados.
//       Ejemplo:
//          Operación op=new Operación(5,4,”+”);
//          res=op.evaluar();
//          Console.WriteLine(res);
	
	
	

	public class Operacion
	{
		private string operador;
		private double operando1;
		private double operando2;
			
		public Operacion(int operando1, int operando2, string operador)
		{
			this.operando1 = operando1;
			this.operando2 = operando2;
			this.operador = operador;
		}
		
		public double evaluar()
		{
			switch (operador) {
				case "+":
					return operando1 + operando2;
					
				case "-":
					return operando1 - operando2;
					
				case "*":
					return operando1 * operando2;
					
				case "/":
					if (operando1 != 0 && operando2 != 0) {
						return (double)(operando1 / operando2);
					}
					
					Console.WriteLine("No se puede realizar una división por cero");
					break;
					
			}
			
			return 0;
		}
	}
}
