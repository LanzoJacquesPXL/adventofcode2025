using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day2
    {
        public static void Challenge1()
        {
            long sum = 0;

            string filePath = "C:\\Users\\12304002\\adventDay2.txt";

            string input = File.ReadAllText(filePath);
            string[] sections = input.Split(',');
            foreach (string section in sections)
            {
                string[] range = section.Split('-');
                long start = long.Parse(range[0]);
                long end = long.Parse(range[1]);
                for (long i = start; i <= end; i++)
                {
                    string value = i.ToString();
                    string firstHalf = value.Substring(0, value.Length / 2);
                    string secondHalf = value.Substring(value.Length / 2);
                    if (firstHalf.Equals(secondHalf))
                    {
                        sum += i;
                    }
                }
            }
            Console.WriteLine("Sum of invalid ID's is " + sum);
        }

        public static void Challenge2()
        {
            long sum = 0;

            string filePath = "C:\\Users\\12304002\\adventDay2.txt";

            string input = File.ReadAllText(filePath);
            string[] sections = input.Split(',');
            foreach (string section in sections)
            {
                string[] range = section.Split('-');
                long start = long.Parse(range[0]);
                long end = long.Parse(range[1]);
                for (long i = start; i <= end; i++)
                {
                    string value = i.ToString();
                    for (int j = 1; j < value.Length; j++)
                    {
                        string subsection = value.Substring(0, j);
                        if (String.Concat(Enumerable.Repeat(subsection, value.Length/j)).Equals(value))
                        {
                            sum += i;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Sum of invalid ID's is " + sum);
        }
    }
}
