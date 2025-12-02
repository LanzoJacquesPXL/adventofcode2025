namespace AdventOfCode
{
    internal class Day1
    {
        public static void Challenge1()
        {
            int value = 50;
            int zeroAmount = 0;

            string filePath = "C:\\Users\\12304002\\adventDay1.txt";
            using StreamReader reader = File.OpenText(filePath);

            string line = reader.ReadLine();
            while (line != null)
            {
                string direction = line.Substring(0, 1);
                int amount = int.Parse(line.Substring(1));

                if (direction.Equals("L"))
                {
                    value -= amount;
                }
                else
                {
                    value += amount;
                }
                value %= 100;
                if (value < 0)
                {
                    value += 100;
                }

                if (value == 0)
                {
                    zeroAmount++;
                }
                line = reader.ReadLine();
            }

            Console.WriteLine("Amount of times value reached zero: " + zeroAmount);
        }

        public static void Challenge2()
        {
            int value = 50;
            int zeroAmount = 0;
            bool previousValueIsZero = false;

            string filePath = "C:\\Users\\12304002\\adventDay1.txt";
            using StreamReader reader = File.OpenText(filePath);


            string line = reader.ReadLine();
            while (line != null)
            {
                string direction = line.Substring(0, 1);
                int amount = int.Parse(line.Substring(1));

                if (direction.Equals("L"))
                {
                    value -= amount;
                }
                else
                {
                    value += amount;
                }


                if (value >= 100)
                {
                    zeroAmount += value / 100;
                } else if (value <= 0)
                {
                    zeroAmount -= (value - 100) / 100;

                    if (previousValueIsZero)
                    {
                        zeroAmount--;
                    }
                }

                previousValueIsZero = false;

                value %= 100;
                if (value < 0)
                {
                    value += 100;
                }

                if (value == 0)
                {
                    previousValueIsZero = true;
                }

                line = reader.ReadLine();
            }

            Console.WriteLine("Amount of times value reached zero: " + zeroAmount);

        }

        public static void Challenge2Alternate()
        {
            int value = 50;

            string filePath = "C:\\Users\\12304002\\adventDay1.txt";
            using StreamReader reader = File.OpenText(filePath);

            string line = reader.ReadLine();
            while (line != null)
            {
                string direction = line.Substring(0, 1);
                int amount = int.Parse(line.Substring(1));

                if (direction.Equals("R"))
                {
                    value += amount;
                }
                else
                {
                    int remaining = amount % 100;
                    value += amount - remaining + (value - remaining) % 100;
                }

                line = reader.ReadLine();

            }
            Console.WriteLine(value / 100);
        }
    }
}
