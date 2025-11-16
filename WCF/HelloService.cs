namespace WcfServer 
{
    public class HelloService : IHelloService
    { 
        public string SayHello(string name)
        {
            return $"\nHello {name} from the WCF server!";
        }
    }
}