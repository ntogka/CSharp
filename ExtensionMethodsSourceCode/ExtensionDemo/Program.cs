using CustomExtensions;
using System;

namespace ExtensionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            "This is a demo".PrintToConsole();

            ISimpleLogger logger = new SimpleLogger();
            logger.Log("Test Error", "ERror");
            logger.LogError("This is an error");
            logger.LogWarning("This is a warning.");
            Console.WriteLine("Goodbye");

            // person.Print().LogInfo().SaveToDatabase(myDBConnection);
            // SaveToDatabase(LogInfo(Print(person)));
        }
    }
}
