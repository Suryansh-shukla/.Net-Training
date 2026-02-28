using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Logging
{
    public class Logger
    {
        public static readonly string filePath = "errorlog.txt";
        public static void LogError(string message, string stackTrace)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))// True so that it(file) is in Append mode
                {
                    writer.WriteLine("================================");
                    writer.WriteLine($"Timestamp    : {DateTime.Now}");
                    writer.WriteLine($"Message      : {message}");
                    writer.WriteLine($"StackTrace   : {stackTrace}");
                    writer.WriteLine("================================");
                    writer.WriteLine();
                }
            }
            catch (Exception e)
            {
                //Avoid Crashing of Application due to Logging Failure
                Console.WriteLine("Failed to log error: " + e.Message);
            }
        }
    }
}
