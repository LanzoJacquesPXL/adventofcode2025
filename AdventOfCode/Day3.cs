using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class Day3
    {
        public static void Challenge1()
        {
            int sum = 0;
            string filePath = "C:\\Users\\12304002\\adventDay3.txt";
            using StreamReader reader = File.OpenText(filePath);

            string line = reader.ReadLine();
            while (line != null)
            {
                int highestNumber = 0;
                int highestIndex = -1;
                for (int i = 0; i < line.Length - 1; i++)
                {
                    int currentNumber = line[i];
                    if (currentNumber > highestNumber)
                    {
                        highestNumber = currentNumber;
                        highestIndex = i;
                        if (currentNumber == '9')
                        {
                            break;
                        }
                    }
                }

                int secondNumber = 0;
                for (int j = highestIndex + 1; j < line.Length; j++)
                {
                    int currentSecondNumber = line[j];
                    if (currentSecondNumber > secondNumber)
                    {
                        secondNumber = currentSecondNumber;
                        if (currentSecondNumber == '9')
                        {
                            break;
                        }
                    }
                }

                string value = "" + (char)highestNumber + (char)secondNumber;
                sum += int.Parse(value);
                line = reader.ReadLine();
            }

            Console.WriteLine("The sum is: " + sum);
        }

        public static void Challenge2()
        {
            long sum = 0;
            string filePath = "C:\\Users\\12304002\\adventTest.txt";
            using StreamReader reader = File.OpenText(filePath);

            string line = reader.ReadLine();
            while (line!= null)
            {
                int need = 12;
                int pos = 0;
                int maxStart = line.Length - need;
                string result = "";

                for (int k = 0; k < need; k++)
                {
                    char best = '0';
                    int bestIndex = pos;

                    for (int i = pos; i <= maxStart + k; i++)
                    {
                        if (line[i] > best)
                        {
                            best = line[i];
                            bestIndex = i;

                            if (best == '9') 
                                break;
                        }
                    }

                    result += best;
                    pos = bestIndex + 1;
                }

                sum += long.Parse(result);
                line = reader.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
