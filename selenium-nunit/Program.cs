using Newtonsoft.Json;

namespace selenium_nunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.NewSession();
            Logger.LogMessage("Testing message");

            TeamsChromeTest teamsChromeTest = new TeamsChromeTest();
            // teamsChromeTest.SendFile();
            // teamsChromeTest.WriteMessage();

            TeamsFirefoxTest teamsFirefoxTest = new TeamsFirefoxTest();
            teamsFirefoxTest.SendFiles();
            // teamsFirefoxTest.WriteMessages();
        }
    }
}