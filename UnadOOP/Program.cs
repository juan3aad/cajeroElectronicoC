using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnadOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            String clav = "";
            String op = "";

            do
            {

                Console.WriteLine("Ingrese la clave");
                clav = Console.ReadLine();
                if (clav.Equals("12345"))
                {
                    Console.WriteLine("Ingreso Correcto");

                    Principal mensajero = new Consulta();
                    mensajero.setSaldo(500);
                    mensajero.Operaciones();

                }
                else
                {
                    Console.WriteLine("Error al ingreso");
                }
                Console.WriteLine("Regresar al ingreso de la clave S/N");
                op = Console.ReadLine();

                Console.ReadKey();
            } while (op.Equals("S"));

        }
    }
}
