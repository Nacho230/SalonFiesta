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
	/// Description of Empleado.
	/// </summary>
	public class Empleado
	{
		
		public string Nombre { get; set; }
		public string Apellido { get; set; }
		public int Dni { get; set; }
		public int Legajo { get; set; }
		public double Sueldo { get; set; }
		public string Tarea { get; set; }
		
		
		public Empleado()
		{
		}
		
		public Empleado(string nombre, string apellido, int dni,
		                int legajo, double sueldo, string tarea)
		{
			this.Nombre = nombre;
			this.Apellido = apellido;
			this.Dni = dni;
			this.Legajo = legajo;
			this.Sueldo = sueldo;
			this.Tarea = tarea;
		}
	}
}
