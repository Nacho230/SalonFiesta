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
	class Program
	{
		public static void Main(string[] args)
		{
			
			int opc = 0;
			SalonFiesta salon = new SalonFiesta("Salon pulguitas");
			
			Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
			Console.WriteLine("1. Agregar un servicio");
			Console.WriteLine("2. Eliminar un servicio");
			Console.WriteLine("3. Dar de alta un empleado/encargado");
			Console.WriteLine("4. Dar de baja un empleado/encargado");
			Console.WriteLine("5. Reservar un salón para evento");
			Console.WriteLine("6. Cancelar un evento");
			Console.WriteLine("7. Impresion de datos");
			Console.WriteLine("8. Salir");
			
			Console.WriteLine("Ingrese un valor del menú: ");
			opc = int.Parse(Console.ReadLine());
			
			while (opc != 8) {
			
			
			switch (opc) {
				
				case 1:
					AgregarServicio(salon);
					break;
				
				case 2:
					EliminarServicio(salon);
					break;
				
				case 3:
					DarAltaEmpleado(salon);
					break;
				
				case 4:
					DarBajaEmpleado(salon);
					break;
				
				case 5:
					//ReservarSalon(salon);
					break;
				
				case 6:
					//CancelarEvento(salon);
					break;
				
				case 7:
					//MostrarDatos();
					break;
					
				default:
					Console.WriteLine("Ingresa bien el valor, bobis");
					break;
				
			}
			
			
			
			
			Console.WriteLine("\n--- MENÚ PRINCIPAL ---");
			Console.WriteLine("1. Agregar un servicio");
			Console.WriteLine("2. Eliminar un servicio");
			Console.WriteLine("3. Dar de alta un empleado/encargado");
			Console.WriteLine("4. Dar de baja un empleado/encargado");
			Console.WriteLine("5. Reservar un salón para evento");
			Console.WriteLine("6. Cancelar un evento");
			Console.WriteLine("7. Impresion de datos");
			Console.WriteLine("8. Salir");
			Console.WriteLine("Ingrese un valor del menú!");
			opc = int.Parse(Console.ReadLine());
			}
			
			
			
			
			Console.Write("Saliendo . . . ");
			Console.ReadKey(true);
		}
		
		
		
		public static void AgregarServicio(SalonFiesta salon){
			
			Servicio servicio;
			string nombre, descripcion;
			int cantidad;
			double costo;
			
			Console.WriteLine("Agregaremos un servicio!");
			
			Console.WriteLine("Introduzca el nombre del servicio: ");
			nombre = Console.ReadLine();
			
			Console.WriteLine("Introduzca la descripcion del servicio: ");
			descripcion = Console.ReadLine();
			
			Console.WriteLine("Introduzca la cantidad: ");
			cantidad = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Introduzca el costo del servicio: ");
			costo = double.Parse(Console.ReadLine());
			
			servicio = new Servicio(nombre,descripcion,cantidad,costo);
			
			salon.AgregarServicio(servicio);
			
			Console.WriteLine("Servicio agregado con exito!"); //Mensaje para mostrar luego con verificaciones/excepciones
			
			
		}
		
		public static void EliminarServicio(SalonFiesta salon){
			
			string nombre;
			
			Console.WriteLine("Eliminaremos un servicio!");
			
			Console.WriteLine("Introduzca el nombre del servicio a eliminar: ");
			nombre = Console.ReadLine();
			
			salon.EliminarServicio(nombre);
			
			
		}
		
		
		public static void DarAltaEmpleado(SalonFiesta salon){
			
			Empleado empleado;
			Encargado encargado;
			string nombre, apellido, tarea;
			int dni, legajo,opc;
			double sueldo, plus;
			
			Console.WriteLine("Agregaremos un empleado a nuestra base de datos!");
			
			Console.WriteLine("Introduzca el nombre del empleado: ");
			nombre = Console.ReadLine();
			
			Console.WriteLine("Introduzca el apellido del empleado: ");
			apellido = Console.ReadLine();
			
			Console.WriteLine("Introduzca el dni del empleado: ");
			dni = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Introduzca el legajo del empleado: ");
			legajo = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Introduzca la tarea del empleado: ");
			tarea = Console.ReadLine();
			
			Console.WriteLine("Introduzca el sueldo del empleado: ");
			sueldo = double.Parse(Console.ReadLine());
			
			Console.WriteLine("El empleado, " + "'"+apellido +"'" + " es encargado?");
			Console.WriteLine("1. Si, es encargado");
			Console.WriteLine("2. No es encargado");
			opc = int.Parse(Console.ReadLine());
			
			if (opc == 1) { // Agregar excepcion. Solo 1 o 2, nada mas.
				
				Console.WriteLine("Los encargados cobran un plus, ingrese el valor extra: ");
				plus = double.Parse(Console.ReadLine());
				
				encargado = new Encargado(nombre,apellido,dni,legajo,sueldo,tarea,plus);
				salon.AgregarEmpleado(encargado);
				Console.WriteLine("Encargado agregado correctamente!");
				
			}else{
				
				empleado = new Empleado(nombre,apellido,dni,legajo,sueldo,tarea);
				salon.AgregarEmpleado(empleado);
				Console.WriteLine("Empleado agregado correctamente!");
				
			}
			
			
			
		}
		
		
		public static void DarBajaEmpleado(SalonFiesta salon){
			
			
			int dni;
			
			Console.WriteLine("Eliminaremos un empleado de nuestra base de datos!");
			
			Console.WriteLine("Introduzca el dni del empleado a eliminar: ");
			dni = int.Parse(Console.ReadLine());
			
			salon.EliminarEmpleado(dni);
			
		}
		
		public static void ReservarSalon(SalonFiesta salon){
			
			//Reservar el salón para un evento. El cliente puede incluir en su pedido un solo servicio o
			//varios. El salón toma una sola reserva para la misma fecha. En caso de que ya tenga una
			//reserva previa se levanta una excepción indicando lo ocurrido. Al confirmar la reserva se le
			//asigna un encargado al evento.
			
			Evento evento;
			
			string nombreCliente,tipo;
			int dniCliente;
			double anticipo;
			DateTime fecha,horario;
		
			
			Console.WriteLine("Proceso para reservar un salon");
								
			/*public string NombreCliente{get;set;}
		public int DniCliente{get;set;}
		public DateTime Fecha{get;set;}
		public DateTime Horario{get;set;}
		public string Tipo{get;set;}
		public double MontoAnticipo{get;set;}
		public Encargado EncargadoEvento{get;set;}
		public ArrayList ServiciosContratados{get;set;}*/
		}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	}
}