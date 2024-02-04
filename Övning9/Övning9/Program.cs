using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Övning9
{
    internal class Program
    {
        static double convertToF(double C)
        {
            return ((C*9/5)+32);
        }
        static string goodWordGenerator(char letter)
        {
            Random rnd = new Random();
            List<string> matchingWords = new List<string>();

            //reading csv file
            string whole_file = System.IO.File.ReadAllText("positiveWords.csv");
            string[] lines = whole_file.Replace("\r", "").Split('\n');
            for(int i = 0; i < lines.Length - 1; i++)
            {   
                //get line from csv file
                string line = lines[i];
                string[] lineSepareted = line.Split(',');

                //add word to matching words if it starts with letter
                bool containsLetter = lineSepareted[1].StartsWith(Char.ToString(letter));
                if(containsLetter == true)
                {
                    matchingWords.Add(lineSepareted[1]);
                }
            }

            //returning random word from matchingWords
            int randomNumber = rnd.Next(matchingWords.Count);
            return (matchingWords[randomNumber]);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(convertToF(20));
            Console.WriteLine(goodWordGenerator('a'));

        }
    }
}
