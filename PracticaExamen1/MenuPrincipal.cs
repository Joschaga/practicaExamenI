using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    class MenuPrincipal : Cajero
    {
        static Cajero cajero = new Cajero();
        static int seleccion;

        public static void menu()
        {
            seleccion = 0;
            do
            {
                Console.WriteLine("****Menú Principal****");
                Console.WriteLine("****¿Qué trámite desea realizar?****");
                Console.WriteLine("1 --> Pago de Servicios Públicos");
                Console.WriteLine("2 --> Cambio de Cheques");
                Console.WriteLine("3 --> Depósitos");
                Console.WriteLine("4 --> Emisión de Tarjetas de Crédito/Débito/Prepago");
                Console.WriteLine("5 --> Emisión de Chequeras o Bonos");
                Console.WriteLine("6 --> Créditos Hipotecarios y Compra de Auto");
                Console.WriteLine("7 --> Salir");
                Console.WriteLine("Digite una opción");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {
                    case 1: cajero.pagoServicios(); break;
                    case 2: cajero.cambioCheques(); break;
                    case 3: cajero.depositos(); break;
                    case 4: cajero.emisionTarjetas(); break;
                    case 5: cajero.otrasEmisiones(); break;
                    case 6: cajero.creditos(); break;
                    case 7: break;

                    default:
                        Console.WriteLine("No digitó una opción valida, vuelva a ingresar una opción");
                        Console.WriteLine("Presione cualquier tecla para continuar");
                        Console.Read();
                        break;

                }
            } while (seleccion != 7);
        }
    }
}
