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
	/// Description of SalonFiesta.
	/// </summary>
	public class SalonFiesta
	{
		
		public string Nombre{get;set;}
		
		private ArrayList empleados;
		//private int cantEmpleados;
		
		private ArrayList serviciosDisponibles;
		//private int cantServicios
		
		private ArrayList eventos;
		//private int cantEventos;
 		
		
		public SalonFiesta(string nombre){ //constructor con argumentos, inicializamos las listas y nombre
			
			this.Nombre = nombre;
			empleados = new ArrayList();
			serviciosDisponibles = new ArrayList();
			eventos = new ArrayList();
			
		}
		
		
		public SalonFiesta() // constructor vacio. aburrido.
		{
		}
		
		// EMPPLEADO
		
		public void AgregarEmpleado(Empleado empleado){
			
			empleados.Add(empleado);
			
		}
		
		public void EliminarEmpleado(int dni){
			
			foreach (Empleado e in empleados) {
				
				if (e.Dni == dni) {
					
					empleados.Remove(e);
				}else{
					Console.WriteLine("No existe");
				}
				
			}
			
		}
		
		public int DevolverCantEmpleados(){
			
			return empleados.Count;
			
		}
		
		public Empleado RecuperarEmpleado(int pos){
			
			return (Empleado)empleados[pos];
			
		}
		
		public bool ExisteEmpleado(int dni){
			
			foreach (Empleado e in empleados) {
				
				if (e.Dni == dni) {
					
					return empleados.Contains(e);
				}
				else{
					return false;
				}
				
			}
			
		}
		
		public ArrayList RetornarEmpleados(){
			
			return empleados;
			
		}
		
		
		//SERVICIO
		
		public void AgregarServicio(Servicio servicio){
			
			serviciosDisponibles.Add(servicio);
			
		}
		
		public void EliminarServicio(string nombre){
			
			foreach (Servicio s in serviciosDisponibles) {
				
				if (s.Nombre == nombre) {
					
					serviciosDisponibles.Remove(s);
					
				}else{
					Console.WriteLine("No existe un servicio con ese nombre pues");
				}
				
			}
			
		}
		
		public int DevolverCantServicios(){
			
			return serviciosDisponibles.Count;
			
		}
		
		public Servicio RecuperarServicio(int pos){
			
			return (Servicio)serviciosDisponibles[pos];
			
		}
		
		public bool ExisteEmpleado(string nombre){
			
			foreach (Servicio s in serviciosDisponibles) {
				
				if (s.Nombre == nombre) {
					
					return serviciosDisponibles.Contains(s);
				}
				else{
					return false;
				}
				
			}
			
		}
		
		public ArrayList RetornarServicios(){
			
			return serviciosDisponibles;
			
		}
		
		//EVEntos
		
		public void AgregarEvento(Evento evento){
			
			eventos.Add(evento);
			
		}
		
		public void EliminarEvento(int dni){
			
			foreach (Evento e in eventos) {
				
				if (e.DniCliente == dni) {
					eventos.Remove(e);
					
				}else{
					Console.WriteLine("No existe un evento con ese dni");
					
				}
				
			}
			
		}
		
		public int DevolverCantEventos(){
			
			return eventos.Count;
			
		}
		
		public Evento RecuperarEvento(int pos){
			
			return (Evento)eventos[pos];
			
		}
		
		public bool ExisteEvento(int dni){
			
			foreach (Evento e in eventos) {
				
				if (e.DniCliente == dni) {
					
					return eventos.Contains(e);
				}
				else{
					return false;
				}
				
			}
			
		}
		
		public ArrayList RetornarEventos(){
			
			return eventos;
			
		}
		
		
		
		
		
		
		
	}
}
