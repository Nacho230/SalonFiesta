/*
 * Created by SharpDevelop.
 * User: nacho
 * Date: 21/5/2025
 * Time: 00:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections;

namespace Proyecto_n2_SalonFiesta
{
	/// <summary>
	/// Description of Evento.
	/// </summary>
	public class Evento
	{
		
		public string NombreCliente{get;set;}
		public int DniCliente{get;set;}
		public DateTime Fecha{get;set;}
		public DateTime Horario{get;set;}
		public string Tipo{get;set;}
		public double MontoAnticipo{get;set;}
		public Encargado EncargadoEvento{get;set;}
		public ArrayList ServiciosContratados{get;set;}
		
		
		public Evento()
		{
		}
		
		public Evento(string nombreCliente, int dniCliente,
		             DateTime fecha, DateTime horario,
		            string tipo, double montoAnticipo){
			
			ServiciosContratados = new ArrayList();
			this.NombreCliente = nombreCliente;
			this.DniCliente = dniCliente;
			this.Fecha = fecha;
			this.Horario = horario;
			this.Tipo = tipo;
			this.MontoAnticipo = montoAnticipo;
			
			EncargadoEvento = new Encargado();
			
			}
		
		public double CalcularCostoTotal(){
			
			//se calcula en base al precio de los servicios 
			//contratados y la cantidad
			
			double total = 0;
			
			foreach (Servicio s in ServiciosContratados) {
				
				total += s.CalcularCostoTotal();
				
			}
			
			return total;
			
		}
		
		
	}
}
