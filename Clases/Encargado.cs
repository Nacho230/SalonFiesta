/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 21/5/2025
 * Time: 00:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_n2_SalonFiesta
{
	/// <summary>
	/// Description of Encargado.
	/// </summary>
	public class Encargado : Empleado
	{
		
		public double Plus{get;set;}
		
		public Encargado()
		{
		}
		
		
		public Encargado(string nombre, string apellido,
		                int dni, int legajo, double sueldo,
		                string tarea, double plus) : base(nombre,
		                                 apellido, dni, legajo,
		                                 sueldo, tarea){
			this.Plus = plus;
		}
			
		
		public double SueldoTotal(){
			
			return (sueldo+plus);
			
		}
			
		
		}
		
	
		
	}
		
		
		
	
}
