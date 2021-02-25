using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebServicesSOAP.ServiceReferenceCliente;


namespace WebServicesSOAP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            WebService1SoapClient wssoap = new WebService1SoapClient();
            Console.WriteLine(wssoap.HelloWorld());
            Console.WriteLine("Suma 1 + 3: "+ wssoap.prueba (1, 3).ToString());
            Console.WriteLine("division 7 + 12: " + wssoap.pruebaDividir(7, 12).ToString());
            Console.ReadKey();
            */
            WebServiceSOAPSoapClient wssoap = new WebServiceSOAPSoapClient();
            var Clientescompleto = wssoap.Cliente();

            foreach (var Cliente in Clientescompleto)
            {
                Console.WriteLine("NIF CLIENTE: " + Cliente.nif);
                Console.WriteLine("NOMBRE CLIENTE: " + Cliente.nombre);
                Console.WriteLine("APELLIDOS CLIENTE: " + Cliente.apellidos);
                Console.WriteLine("IMAIL CLIENTE: " + Cliente.email);
                Console.WriteLine("TELEFONO CLIENTE: " + Cliente.telefono);
                Console.WriteLine("----------------------\n\n");
                Console.ReadKey();
            }
        }
    }
}
