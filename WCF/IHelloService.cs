// The main .NET namespace (and assembly/reference) that contains all the core classes used to build WCF services and WCF clients.
using System.ServiceModel;

namespace WcfServer 
{
    // The 'ServiceContractAttribute' class is used to define a service contract in WCF.
    // WCF uses Service Contracts (interfaces) to define API operations.
    [ServiceContract]
    public interface IHelloService
    {
        // The 'OperationContractAttribute' class is used to define an operation in a WCF service contract.
        [OperationContract]
        string SayHello(string name);
    }
}