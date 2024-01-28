namespace DZ111111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1

            Console.WriteLine("Enter your int: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num >= 1 && num <= 100)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz ");
                }
                if (num % 5 == 0)
                {
                    Console.WriteLine("Buzz ");
                }
            }
            else
            {
                Console.WriteLine("Invalid int!!!");
            }

            //Task2

            Console.WriteLine("Input a ");
            float nummmm = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iput % ");
            int perc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(perc + " percent from " + nummmm + " = " + nummmm / 100 * perc);

            //Task3

            int supnum = 0;
            bool decision = true;
            while (true)
            {

                if (decision == false)
                {
                    break;
                }

                supnum *= 10;

                Console.WriteLine("Input: ");
                supnum += Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("0 to stop/1 to continue");
                if (Convert.ToInt32(Console.ReadLine()) == 0)
                {
                    decision = false;
                }
                else
                {
                    decision = true;
                }
            }
            Console.WriteLine(supnum);

            //Task4

            int[] digits = new int[6];
            int num_to_split;
            Console.WriteLine("Input 6 digits long number: ");
            do
            {
                num_to_split = Convert.ToInt32(Console.ReadLine());
            } while (num_to_split < 100000 && num_to_split > 999999);

            for (int i = 0; i < 6; i++)
            {
                digits[i] = num_to_split % 10;
                num_to_split /= 10;
            }

            Console.WriteLine("Input a: ");
            int a;
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            } while (a < 0 && a >= 6);
            Console.WriteLine("Input b: ");
            int b;
            do
            {
                b = Convert.ToInt32(Console.ReadLine());
            } while (b < 0 && b >= 6);

            int temp = digits[a];
            digits[a] = digits[b];
            digits[b] = temp;

            for (int i = 0; i < 6; i++)
            {
                Console.Write(digits[i]);
            }
            Console.WriteLine();

            //Task5

            string date;
            Console.WriteLine("Input date: MM.DD.YYYY");
            date = Console.ReadLine() + " 18:44:34";
            DateOnly dt = DateOnly.FromDateTime(Convert.ToDateTime(date));
            Console.Write(dt.DayOfWeek + " ");
            if (dt.Month >= 1 && dt.Month <= 2 || dt.Month == 12)
            {
                Console.WriteLine("Winter");
            }
            else if (dt.Month >= 3 && dt.Month <= 5)
            {
                Console.WriteLine("Spring");
            }
            else if (dt.Month >= 6 && dt.Month <= 8)
            {
                Console.WriteLine("Summer");
            }
            else if (dt.Month >= 9 && dt.Month <= 11)
            {
                Console.WriteLine("Autumn");
            }

            //Task6

            int temperature;
            Console.WriteLine("Input temperature: ");
            temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 - convert to kelvin/0 - convert to celsius");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine(temperature + 273);
            }
            else
            {
                Console.WriteLine(temperature - 273);
            }

            //Task7

            int aa;
            int bb;
            Console.WriteLine("Input aa: ");
            aa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input bb: ");
            bb = Convert.ToInt32(Console.ReadLine());
            int start;
            int stop;
            if (aa <= bb)
            {
                start = aa;
                stop = bb;
            }
            else
            {
                start = bb;
                stop = aa;
            }
            if (start % 2 != 0)
            {
                start++;
            }
            for (int i = start; i <= stop; i += 2)
            {
                Console.WriteLine(i.ToString());
            }

        }
    }
}