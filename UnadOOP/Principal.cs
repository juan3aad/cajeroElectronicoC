using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    abstract class Principal
    {
        protected int transaccion, reti,deposi,trasferen,punto;
	protected String cta;
	private static int saldo,pto;
	//Scanner entrada=new Scanner(System.in);
	
	public void Operaciones() {
		
		int seleccion=0;
		
		do {
			Console.WriteLine("Por favor seleccionar una opción");
			Console.WriteLine("	1. Consulta de saldo");
			Console.WriteLine("	2. Retiro de efectivo");
			Console.WriteLine("	3. Deposito de efectivo");
			Console.WriteLine("	4. Realizar Transferencia a otra cuenta");
			Console.WriteLine("	5. Consulta puntos vive colombia");
			Console.WriteLine("	6. Salir");
			seleccion=int.Parse(Console.ReadLine());
			
			
			switch(seleccion)
			{
				case 1://Consulta de Saldo
					Principal mensajero1= new Consulta();
					mensajero1.transacciones();
					break;
				case 2://Retiro de efectivo
					Principal mensajero2= new Retiro();
					mensajero2.transacciones();
					break;
				
				case 3://Deposito de efectivo
					Principal mensajero3= new Deposito();
					mensajero3.transacciones();
					break;
					
				case 4://Trasferencia a otra cuenta
					Principal mensajero4= new Transferencia();
					mensajero4.transacciones();
					break;
					
				case 5://Consulta puntos vive colombia
					Principal mensajero5= new Punto();
					mensajero5.transacciones();
					break;
	
					
				case 6:
					Console.WriteLine("¡Gracias!, Vuelva pronto.");
					break;
				default:
						Console.WriteLine("--------------------------------------");
						Console.WriteLine("Opcion no disponible vuelva a ingresar");
                        Console.WriteLine("--------------------------------------");
                        break;
					
			}
			
						
		}while(seleccion !=6);
		
	}
//Metodo para solicitar cantidad de retiro
	public void retiro() {
        reti =int.Parse(Console.ReadLine());
	}
	
	//Metodo para realizar transferencia
	public void transferencia() {
		trasferen=int.Parse(Console.ReadLine());
		Console.WriteLine("Ingrese el numero de la cuenta");
        this.cta = Console.ReadLine();
	}
	
	//Metodo para solicitar Deposito
	public void deposito() {
        this.deposi = int.Parse(Console.ReadLine());

	}
	
	//Metodo para solicitar Deposito
		
	
	//Metodo abstracto
	public abstract void transacciones();
	
	public int getSaldo() {
		return saldo;
	}
	public void setSaldo(int saldo1) {
		saldo=saldo1;
	}
	public static int getPto() {
		return pto;
	}
	public static void setPto(int pto) {
		Principal.pto = pto;
	}

    }
}
