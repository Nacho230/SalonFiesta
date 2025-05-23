/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 21/5/2025
 * Time: 00:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Proyecto_n2_SalonFiesta
{
	/// <summary>
	/// Description of Servicio.
	/// </summary>
	public class Servicio
	{
		public string Nombre{get;set;}
		public string Descripcion{get;set;}
		public int Cantidad{get;set;}
		public double CostoUnitario{get;set;}
		
		
		public Servicio()
		{
		}
		
		public Servicio(string nombre, string descripcion,
		               int cantidad, double costoUnitario){
			
			this.Nombre = nombre;
			this.Descripcion = descripcion;
			this.Cantidad = cantidad;
			this.CostoUnitario = costoUnitario;
			
		}
		
		public double CalcularCostoTotal(){
			
			return (CostoUnitario * Cantidad);
			
		}
		
	}
}
