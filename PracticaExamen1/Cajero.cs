using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace PracticaExamen1
{
    public class Cajero
    {
        //Atributos
        protected string nombre { get; set; }
        protected string cedula { get; set; }
        protected string telefono { get; set; }
        protected string direccion { get; set; }
        protected int numeroCaja { get; set; }
        protected int montoTotal { get; set; }

        //Constructor
        public Cajero(string nom, string ced, string tel, string dir, int numCaja, int monTotal)
        {
            nombre = nom;
            cedula = ced;
            telefono = tel;    
            direccion = dir;
            numeroCaja = numCaja;
            montoTotal = monTotal;
        }

        //Getters & Setters
        public string GetNombre() { return nombre; }
        public string GetCedula() { return cedula; }
        public string GetTelefono() { return telefono; }
        public string GetDireccion() { return direccion; }
        public int GetNumeroCaja() { return numeroCaja; }
        public int GetMontoTotal() { return montoTotal; }

        public void SetNombre(string nom)
        {
            nombre = nom;
        }
        public void SetCedula(string ced)
        {
            cedula = ced;
        }
        public void SetTelefono(string tel)
        {
            telefono = tel;
        }
        public void SetDireccion(string dir)
        {
            direccion = dir;
        }
        public void SetNumeroCaja(int numCaja)
        {
            numeroCaja = numCaja;
        }
        public void SetMontoTotal(int monTotal)
        {
            montoTotal = monTotal;
        }

        public Cajero()
        {
        }

        //Métodos
        public void crearCajero()
        {
            string nom, ced, tel, dir;
            Console.WriteLine("Ingrese su Nombre");
            nom = Console.ReadLine();
            Console.WriteLine("Ingrese su Cédula");
            ced = Console.ReadLine();
            Console.WriteLine("Ingrese su Número de Teléfono");
            tel = Console.ReadLine();
            Console.WriteLine("Ingrese su Dirección");
            dir = Console.ReadLine();
            Console.WriteLine("***Se ha creado el cajero***" +
                              "\nNombre: " + nom + "." +
                              "\nCédula: " + ced + "." +
                              "\nTeléfono: " + tel + "." +
                              "\nDirección: " + dir + ".");
            MenuPrincipal.menu();
            Console.Read();
        }
        public void asignarCajeroCaja()
        {
            string ced;
            int numCaja;
            Console.WriteLine("Ingrese su Cédula");
            ced = Console.ReadLine();
            Console.WriteLine("Ingrese el Número de Caja");
            numCaja = int.Parse(Console.ReadLine());
            Console.Read();
        }
        public void cierreCaja()
        {
            int numCaja, montoTotal;
            Console.WriteLine("Ingrese el Número de Caja");
            numCaja = int.Parse(Console.ReadLine());
            montoTotal = int.Parse(Console.ReadLine());
            Console.Read();
        }
        public void pagoServicios()
        {
            int luz = 1, telef = 2;
            int[] tipoServicio = new int[10];
            for (int i = 0; i < tipoServicio.Length; i++)
            {
                Console.WriteLine("Ingrese el Servicio a Pagar:");
                Console.WriteLine("1 --> Recibo de Luz");
                Console.WriteLine("2 --> Recibo de Telefóno");
                Console.WriteLine("3 --> Recibo de Agua");
                tipoServicio[i] = int.Parse(Console.ReadLine());
                if (tipoServicio[i] == luz)
                    Console.WriteLine("\n***************************************" +
                                      "\n***************************************" +
                                      "\n***************************************" +
                                      "\n*****Usted pagará su recibo de Luz*****" +
                                      "\n***************************************" +
                                      "\n***************************************" +
                                      "\n***************************************");
                else
                    if (tipoServicio[i] == telef)
                    Console.WriteLine("\n********************************************" +
                                      "\n********************************************" +
                                      "\n********************************************" +
                                      "\n*****Usted pagará su recibo de Teléfono*****" +
                                      "\n********************************************" +
                                      "\n********************************************" +
                                      "\n********************************************");
                else
                    Console.WriteLine("\n****************************************" +
                                      "\n****************************************" +
                                      "\n****************************************" +
                                      "\n*****Usted pagará su recibo de Agua*****" +
                                      "\n****************************************" +
                                      "\n****************************************" +
                                      "\n****************************************");
                Console.WriteLine("\n************************************************************************" +
                                  "\n************************************************************************" +
                                  "\n************************************************************************" +
                                  "\n*****Su recibo ha sido pagado, gracias por usar nuestros servicios.*****" +
                                  "\n************************************************************************" +
                                  "\n************************************************************************" +
                                  "\n************************************************************************");
                MenuPrincipal.menu();
                Console.Read();
            }
        }
        public void cambioCheques()
        {
            Console.WriteLine("\n*********************************************" +
                              "\n*********************************************" +
                              "\n*********************************************" +
                              "\n*****Usted procederá a cambiar un cheque*****" +
                              "\n*********************************************" +
                              "\n*********************************************" +
                              "\n*********************************************");
            Console.WriteLine("\n**************************************************************************" +
                              "\n**************************************************************************" +
                              "\n**************************************************************************" +
                              "\n*****Su cheque ha sido cambiado, gracias por usar nuestros servicios.*****" +
                              "\n**************************************************************************" +
                              "\n**************************************************************************" +
                              "\n**************************************************************************");
            MenuPrincipal.menu();
            Console.Read();
        }
        public void depositos()
        {
            Console.WriteLine("\n********************************" +
                              "\n********************************" +
                              "\n********************************" +
                              "\n*****Usted hará un depósito*****" +
                              "\n********************************" +
                              "\n********************************" +
                              "\n********************************");
            Console.WriteLine("\n*****************************************************************************" +
                              "\n*****************************************************************************" +
                              "\n*****************************************************************************" +
                              "\n*****Su depósito ha sido realizado, gracias por usar nuestros servicios.*****" +
                              "\n*****************************************************************************" +
                              "\n*****************************************************************************" +
                              "\n*****************************************************************************");
            MenuPrincipal.menu();
            Console.Read();
        }

        public void emisionTarjetas()
        {
            int tarjetaCredito = 1, tarjetaDebito = 2;
            int[] tipoTarjeta = new int[10];
            for (int i = 0; i < tipoTarjeta.Length; i++)
            {
                Console.WriteLine("¿Qué tipo de tarjeta requiere solicitar?");
                Console.WriteLine("1 --> Tarjeta de Crédito");
                Console.WriteLine("2 --> Tarjeta de Débito");
                Console.WriteLine("3 --> Tarjeta de Prepago");
                tipoTarjeta[i] = int.Parse(Console.ReadLine());
                if (tipoTarjeta[i] == tarjetaCredito)
                    Console.WriteLine("\n****************************************************" +
                                      "\n****************************************************" +
                                      "\n****************************************************" +
                                      "\n*****Usted ha solicitado una tarjeta de Crédito*****" +
                                      "\n****************************************************" +
                                      "\n****************************************************" +
                                      "\n****************************************************");
                else
                    if (tipoTarjeta[i] == tarjetaDebito)
                    Console.WriteLine("\n***************************************************" +
                                      "\n***************************************************" +
                                      "\n***************************************************" +
                                      "\n*****Usted ha solicitado una tarjeta de Débito*****" +
                                      "\n***************************************************" +
                                      "\n***************************************************" +
                                      "\n***************************************************");
                else
                    Console.WriteLine("\n*************************************************" +
                                      "\n*************************************************" +
                                      "\n*************************************************" +
                                      "\n*****Usted ha solicitado una tarjeta Prepago*****" +
                                      "\n*************************************************" +
                                      "\n*************************************************" +
                                      "\n*************************************************");
                Console.WriteLine("\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n*****Gracias por usar nuestros servicios.*****" +
                                  "\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n**********************************************");
                MenuPrincipal.menu();
                Console.Read();
            }
        }

        public void otrasEmisiones()
        {
            int chequera = 1;
            int[] tipoTramite = new int[10];
            for (int i = 0; i < tipoTramite.Length; i++)
            {
                Console.WriteLine("¿Desea emitir una chequera ó un bono?");
                Console.WriteLine("1 --> Emitir Chequera");
                Console.WriteLine("2 --> Emitir Bono");
                tipoTramite[i] = int.Parse(Console.ReadLine());
                if (tipoTramite[i] == chequera)
                    Console.WriteLine("\n***************************************************************" +
                                      "\n***************************************************************" +
                                      "\n***************************************************************" +
                                      "\n*****Su solicitud de emisión de Chequera ha sido ingresada*****" +
                                      "\n***************************************************************" +
                                      "\n***************************************************************" +
                                      "\n***************************************************************");
                else
                    Console.WriteLine("\n***********************************************************" +
                                      "\n***********************************************************" +
                                      "\n***********************************************************" +
                                      "\n*****Su solicitud de emisión de Bono ha sido ingresada*****" +
                                      "\n***********************************************************" +
                                      "\n***********************************************************" +
                                      "\n***********************************************************");
                Console.WriteLine("\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n*****Gracias por usar nuestros servicios.*****" +
                                  "\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n**********************************************");
                MenuPrincipal.menu();
                Console.Read();
            }
        }

        public void creditos()
        {
            int credito = 1;
            int[] tipoCredito = new int[10];
            for (int i = 0; i < tipoCredito.Length; i++)
            {
                Console.WriteLine("¿Desea solicitar un crédito?");
                Console.WriteLine("1 --> Crédito Hipotecario");
                Console.WriteLine("2 --> Crédito para Automóvil");
                tipoCredito[i] = int.Parse(Console.ReadLine());
                if (tipoCredito[i] == credito)
                    Console.WriteLine("\n***************************************************************" +
                                      "\n***************************************************************" +
                                      "\n***************************************************************" +
                                      "\n*****Su solicitud de Crédito Hipotecario ha sido ingresada*****" +
                                      "\n***************************************************************" +
                                      "\n***************************************************************" +
                                      "\n***************************************************************");
                else
                    Console.WriteLine("\n******************************************************************" +
                                      "\n******************************************************************" +
                                      "\n******************************************************************" +
                                      "\n*****Su solicitud de Crédito para Automóvil ha sido ingresada*****" +
                                      "\n******************************************************************" +
                                      "\n******************************************************************" +
                                      "\n******************************************************************");
                Console.WriteLine("\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n*****Gracias por usar nuestros servicios.*****" +
                                  "\n**********************************************" +
                                  "\n**********************************************" +
                                  "\n**********************************************");
                MenuPrincipal.menu();
                Console.Read();
            }
        }

        //Interfaces
        interface ICajero1
        {
            void emisionTarjetas();
            void pagoServicios();
        }
        interface ICajero2
        {
            void otrasEmisiones();
            void pagoServicios();
        }
        interface ICajero3
        {
            void creditos();
            void pagoServicios();
        }

        /*public class Caja1 : ICajero1
        {
        }

        public class Caja2 : ICajero2
        {
        }

        public class Caja3 : ICajero3
        {
        }*/

        /*enum categoriaServicios
        {
            4 //Bajo
            5 //Medio
            6 //Alto
        }*/

    }
}
