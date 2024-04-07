namespace Apka_bazodanowa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            APITest t = new APITest();
            t.GetData().Wait();
        }
    }
}
