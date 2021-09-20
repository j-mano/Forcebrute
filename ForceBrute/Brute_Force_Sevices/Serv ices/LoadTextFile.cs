using System;
namespace Brute_Force_Sevices.Services
{
    public class LoadTextFile
    {
        public static string[] Loadtextfile()
        {
            string[] line =
            {
            };

            try
            {
                line = System.IO.File.ReadAllLines(@"WriteLines.txt");
            }
            catch
            {
                throw new InvalidOperationException("Error while loading from file");
            }

            return line;
        }
    }
}
