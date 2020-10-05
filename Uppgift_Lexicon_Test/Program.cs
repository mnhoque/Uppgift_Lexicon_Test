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

            check_Palindom();
            
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
            System.IO.File.WriteAllText(@"C:\Users\nazmu\Desktop\WriteText.txt", text);
        }

        public static void read_file()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\nazmu\Desktop\WriteText.txt");
            
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

        public static void create_Array()
        {
            int[] rollno = new int[10];
            int[] copied_array = new int[rollno.Length]; //New Array and the size of a which is 4

            Random rand = new Random();


            for (int s = 0; s <= 9; s++)
            {
                rollno[s] = rand.Next(1, 100);
                //rollno[s] += 110;

            }

            Array.Sort(rollno);

            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine("In the array {0} numbers is : {1}", j + 1, rollno[j]);
            }

            Array.Copy(rollno, copied_array, rollno.Length);

            for (int j = 0; j <= 9; j++)
            {
                Console.WriteLine("In the coppied array {0} numbers is : {1}", j+1 , copied_array[j]);
            }
            
        }

        public static void check_Palindom()
        {
            string entered_Name = Console.ReadLine();

            int startIndex = 0;
            int lastindex = 0;
            bool match = false;
            int count = 0;

            if (entered_Name.Length==1) 
            {
                Console.WriteLine($"{entered_Name} is palindom. ");
            }
            else
            {
                for (int i = 0; i <= entered_Name.Length - 1; i++)
                {
                    startIndex = i;
                    lastindex = entered_Name.Length - 1 - i;

                    if (entered_Name[startIndex] == entered_Name[lastindex])
                    {
                        count++;
                    }
                    if (count == entered_Name.Length / 2)
                    {
                        match = true;

                    }

                }
                if (match == true)
                {
                    Console.WriteLine($"{entered_Name} is palindom. ");
                }
                else
                {
                    Console.WriteLine($"{entered_Name} is not palindom.");
                }

            } 

            
        }
        
    }
}
