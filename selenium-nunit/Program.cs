namespace selenium_nunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is running!");

            Logger.NewSession();
            Logger.LogMessage("Testing message");

            Console.WriteLine("Program finished.");
        }
    }
}