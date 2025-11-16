// Amir Moeini Rad
// November 16, 2025

// Main Concept: Windows Communication Foundation (WCF) framework.

// WCF is a framework for building service-oriented applications.
// It is not part of .NET Core or .NET 5+ and is only available in the .NET Framework.
// WCF is the predecessor of ASP.NET Web API in Microsoft’s ecosystem for building HTTP services.
// In other words, WCF was Microsoft's framework for building HTTP web services using the SOAP protocol before ASP.NET Web API was introduced.
// By default, WCF uses SOAP messages (XML envelopes) for communication.
// WCF automatically handles SOAP message formatting, serialization, metadata (WSDL), and service contracts.

// This application should be run with admin privilages in order to host the WCF service on the specified port.

using System;
using System.ServiceModel;

namespace WcfServer
{
    // This app will host the HelloService.
    // Therefore, this app acts as the WCF server.
    // A service is hosted (here in a console app).
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Windows Communication Foundation (WCF) Server in .NET Framework");
            Console.WriteLine("---------------------------------------------------------------\n");


            // Define a host for the service: HelloService.
            // This means that the service will be hosted in the current application domain.
            // The HelloService will be accessible at the specified base address.
            // In other words, we are defining a web API endpoint for the service.
            using (ServiceHost host = new ServiceHost(typeof(HelloService), new Uri("http://localhost:8080/HelloService")))
            {
                // The 'AddServiceEndpoint' method is used to add an endpoint to the service host.
                // Endpoint is where the service can be accessed by clients, defined by address, binding, and contract.
                // The 'BasicHttpBinding' class is used to define the binding for the endpoint.
                // Binding defines how the service and client communicate, including protocols and message formats.
                // "" indicates that the endpoint address is the same as the base address.
                host.AddServiceEndpoint(typeof(IHelloService), new BasicHttpBinding(), "");

                host.Open(); // Open the host to start listening for incoming messages.
                Console.WriteLine("WCF Service is running...");
                Console.ReadKey();
            }

            Console.WriteLine("\nWCF Service was shut down.");

            Console.WriteLine("\nDone.");
        }
    }
}