namespace WcfServer 
{
    public class HelloService : IHelloService
    { 
        public string SayHello(string name)
        {
            return $"Hello {name} from the WCF server!";
        }
    }
}