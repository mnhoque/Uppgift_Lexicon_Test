using System;
using System.Globalization;
using System.IO;

namespace Uppgift_Lexicon_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            print_multiplication();

            //ConsoleKeyInfo c = Console.ReadKey();
            //if (c.Key == ConsoleKey.Tab)
            //{
            //    Console.WriteLine("Tab pressed");
            //}

            Console.ReadLine();
        }
        public static void printHello()
        {
            Console.WriteLine("Hello world");
        }

        public static void userInfo()
        {
            string user_First_Name = Console.ReadLine();
            string user_Last_Name = Console.ReadLine();
            int user_Age = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} {1} {2}", user_First_Name,user_Last_Name,user_Age);
        }

        public static void backgroundColour()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("White on blue.");
            Console.WriteLine("Another line.");

            Console.ResetColor();

        }

        public static void print_Date()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("NOW: " + now);
        }

        public static int checkBigger(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("{0} is bigger than {1}",x,y);
                return x;
                
            }
            else
            {
                Console.WriteLine("{0} is bigger than {1}", y, x);
                return y;
            }
        }

        public static void winner_Or_Looser()
        {
            var rand = new Random();
            var randomNumber = rand.Next(1, 100);
            Console.WriteLine($"Random number between 1 and 100 is {randomNumber}");

            int guess_Number;

            int count = 0;
            bool match = false;

            while (match == false)
            {
                guess_Number = int.Parse(Console.ReadLine());

                if (guess_Number == randomNumber)
                {
                    count++;
                    Console.WriteLine($"You are the winner and tried {count} times");
                    
                    break;
                }
                else
                {
                    if (guess_Number > randomNumber)
                    {
                        Console.WriteLine($"Your gussed number is {guess_Number} and higher than the random number which is {randomNumber} ");
                    }
                    else
                    {
                        Console.WriteLine($"The random number is {randomNumber} and higher than your guessed number which is {guess_Number} ");
                    }
                    count++;
                }
            }

        }

        public static void create_file(string text)
        { 
            //text = Console.ReadLine();
            // WriteAllText creates a file, writes the specified string to the file,
            // and then closes the file.    You do NOT need to call Flush() or Close().
            System.IO.File.WriteAllText(@"C:\Users\nazmu\Desktop\WriteText.txt", text);

        }

        public static void read_file()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\nazmu\Desktop\WriteText.txt");

            // Display the file contents to the console. Variable text is a string.
            System.Console.WriteLine($"Contents of WriteText.txt is {text}" );

        }

        public static void convert_decimal()
        {
            string number = (Console.ReadLine());

            double d1 = double.Parse(number, CultureInfo.InvariantCulture);

            string digit = String.Format("{0:0.00}", d1);

            Console.WriteLine($"{digit}");
        }

        public static void print_multiplication()
        {
            int count = 0;
            ConsoleKeyInfo c = Console.ReadKey();
            if (c.Key == ConsoleKey.Tab)
            {
                Console.WriteLine("Tab pressed");
                count = 1;
            }

            while (count < 11)
            {
                for (int i = 1; i <= 10; i++)
                {
                    int multiplication=count*i;

                    Console.WriteLine($"{count} * {i} = {multiplication}");
                }

                Console.WriteLine();
                Console.WriteLine();

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.Tab)
                {
                    Console.WriteLine($"tab pressed again now the counter is {count+1}");
                    count = count + 1;
                }
            }
            
            
        }

        
    }
}
