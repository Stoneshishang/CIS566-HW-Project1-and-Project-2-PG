using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Open configuration file
            StreamReader configFile = null;
            try
            {
                configFile = new StreamReader("configuration.txt");
            }
            catch(FileNotFoundException exception)
            {
                Console.WriteLine("File not found: " + exception.FileName + " \n\nPress any key to exit.");
                Console.ReadKey();
                return;
            }

            // Test each generation in the config file
            string line;
            while ((line = configFile.ReadLine()) != null)
            {
                WordGeneration word = WordGenerationFactory.GetGui(line);
                if (word != null)
                {
                    word.testGui();
                    Console.WriteLine("\n");
                }
            }

            configFile.Close();

            // Exit application
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
