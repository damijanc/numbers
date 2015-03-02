using System;
using System.Collections.Generic;
using CAXperts.Core.FileUtil;
using CAXperts.Core.ParseUtil;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string filepath = @"C:\development\private\CAExperts\NumberParserExtended.txt";

                IFileUtil filehelper = new FileUtil();
                IParseUtil parser = new ParseUtil();

                if (args.Length == 1)
                {
                    filepath = args[0];
                }

                //read the file
                List<String> lines = filehelper.Read(@filepath);
                //retrieve the numbers
                List<int> numbers = parser.Parse(lines);
                //display them
                Console.WriteLine(String.Join(" ", numbers));
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("File was not found. Please check your path.");
            }
            catch (System.IO.FileLoadException)
            {
                Console.WriteLine("Unable to load file.Please check file permissions.");
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                Console.WriteLine("Unable to load file.Please check your path.");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            Console.ReadLine();

        }
    }
}
