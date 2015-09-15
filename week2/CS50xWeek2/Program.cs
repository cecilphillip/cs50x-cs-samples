using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2Services;

namespace CS50xWeek2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteZipFile();
            Console.Read();
        }

        private static void ErrorHandlingSample()
        {
            var service = new MovieService();
            try
            {
                Console.Out.WriteLine("Scheduling a movie");
                service.ScheduleMovie(null, DateTime.Now);

                // what happens here

            }
            catch (NullReferenceException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine("Something bad happened");
                Console.ResetColor();
                return;

            }
            catch(MovieSchedulingException ex)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Error.WriteLine("Could not schedule movie");
                Console.ResetColor();
            }
            finally
            {
                // what happens here
                Console.WriteLine("Did this run");
            }

            Console.WriteLine("All Done");
        }

        private static void ReadTextFile()
        {
            //using (TextReader textReader = File.OpenText("quotes.txt"))
            //{
            //    string fileContents;
            //    // Not good for large files
            //    fileContents = textReader.ReadToEnd();
            //    Console.WriteLine(fileContents);
            //}

            using (TextReader textReader = File.OpenText("quotes.txt"))
            {
                string line;
                // better 
                while ((line = textReader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }

        private static void WriteTextFile()
        {
            using (TextWriter writer = File.AppendText("test.txt")) //Creates file if it doesn't exisit
            {
                writer.WriteLine("To be or not to be,");
                writer.WriteLine("That is the question.");
            }
        }

        private static void WriteZipFile()
        {
            using (FileStream zipToOpen = File.Open(@"compressed.zip", FileMode.Create)) // this mode overwrites an exisiting file
            {
                using (ZipArchive archive = new ZipArchive(zipToOpen, ZipArchiveMode.Update))
                {
                    ZipArchiveEntry readmeEntry = archive.CreateEntry("hi.txt");
                    using (StreamWriter writer = new StreamWriter(readmeEntry.Open()))
                    {
                        writer.WriteLine("Hi Mom!");
                        writer.WriteLine("========================");
                    }

                    archive.CreateEntryFromFile("quotes.txt", "quotes.txt");
                    archive.CreateEntry("me").Open();
                }
            }
        }
    }
}
