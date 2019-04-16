
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0722414_Assignment_4
{
    class Program
    {
        ArrayList Beowulf;

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Beowulf = new ArrayList();

        }
        public void Run() { this.ReadTextFiles(); }  

        public void ReadTextFiles()
        {
            //Read file using StreamReader.Reads file line by line 
            using (StreamReader file = new StreamReader("U:/Users/722414/c0722414assi4Beowulf.txt"))
            {
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    Beowulf.Add(ln);
                }
                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }

        }

        public int FindNumberOfBlankSpaces(string line)
        {
            int countletters = 0;
            int countSpaces = 0;

            foreach (char c in line)
            {
                if (char.IsLetter(c))
                {
                    countletters++;
                }
                if (char.IsWhiteSpace(c))
                {
                    countSpaces++;

                }

            }
            Console.WriteLine("Number of Blank Spaces: " + countSpaces);
            Console.WriteLine("Number of letters: " + countletters);
            return countletters;
        }

        public int FindNumberOfWords(string x)
        {
            int result = 0;

            x = x.Trim();

            if (x == "")
                return 0;
            
            while (x.Contains("  "))
                x = x.Replace("  ", " ");

            foreach (string y in x.Split(' '))
                result++;

            Console.WriteLine("Result is " + result);
            return result;

        }

    }
}

