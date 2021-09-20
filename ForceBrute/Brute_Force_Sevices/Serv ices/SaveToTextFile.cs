using System;
using System.IO;
using System.Threading.Tasks;

namespace Brute_Force_Sevices.Services
{
    public class SaveToTextFile
    {
        public SaveToTextFile()
        {

        }

        /// <summary>
        /// This function saves the input and outpuded text of the calculation.
        /// Input 1 is inpuded tex and input 2 outpuded <paramref name="InputedText"/>.
        /// The entries is entered in the end.
        /// </summary>
        /// <returns></returns>
        /// <param name="InputedText"></param>
        /// <param name="CalculatedText"></param>
        public static void Save(string InputedText, string CalculatedText)
        {
            try
            {
                string[] LoadedLines = LoadTextFile.Loadtextfile();

                string[] Lines =
                {
                   LoadedLines.ToString(), InputedText, CalculatedText
                };

                File.WriteAllLines("WriteLines.txt", Lines);
            }
            catch
            {
                throw new InvalidOperationException("Error while saving");
            }
        }
    }
}
