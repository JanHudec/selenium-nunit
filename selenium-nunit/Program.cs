﻿using Newtonsoft.Json;

namespace selenium_nunit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program is running!");

            Logger.NewSession();
            Logger.LogMessage("Testing message");

            TeamsChromeTest teamsChromeTest = new TeamsChromeTest();
            teamsChromeTest.SendFile();
            // teamsChromeTest.WriteMessage();

            Console.WriteLine("Program finished.");
        }
    }
}