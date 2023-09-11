namespace selenium_nunit
{
    public static class Logger
    {
        // Here you can change the logging file location or name
        private static string logFilePath = "../../../log.txt";

        public static void LogMessage(string message)
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    DateTime currentTime = DateTime.Now;

                    string logEntry = $"{currentTime.ToString("yyyy-MM-dd HH:mm:ss")} - {message}";

                    writer.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while logging the message: {ex.Message}");
            }
        }

        public static void NewSession()
        {
            try
            {
                using (StreamWriter writer = File.AppendText(logFilePath))
                {
                    writer.WriteLine("------starting a new session------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while logging the message: {ex.Message}");
            }
        }
    }
}
