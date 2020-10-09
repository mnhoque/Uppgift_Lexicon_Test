using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading;

namespace Uppgift_Lexicon_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //Person1 person = new Person1("Nazmul");

            //Console.WriteLine(person.Name);

           
            Console.WriteLine("Enter the expected number 0-16");

            //add_elements();

            int caseSwitch = int.Parse(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    printHello();
                    break;
                case 2:
                    userInfo();
                    break;
                case 3:
                    backgroundColour();
                    break;
                case 4:
                    print_Date();
                    break;
                case 5:
                    checkBigger(6, 9);
                    break;
                case 6:
                    winner_Or_Looser();
                    break;
                case 7:
                    create_file("Hello man, How are you?");
                    break;
                case 8:
                    read_file();
                    break;
                case 9:
                    convert_decimal();
                    break;
                case 10:
                    print_multiplication();
                    break;
                case 11:
                    create_Array();
                    break;
                case 12:
                    check_Palindom();
                    break;
                case 13:
                    mellan_Number();
                    break;
                case 14:
                    check_even_odd();
                    break;
                case 15:
                    add_elements();
                    break;
                case 16:
                    Charecter_random();
                    break;
                case 0:
                    Console.WriteLine("The program is terminated"); 
                    break;
            }


            Console.ReadLine();
        }
        public static void printHello()
        {
            Console.WriteLine("Hello world");
        }

        public static void userInfo()
        {
            Console.WriteLine("Enter the firstname of the person ");
            string user_First_Name = Console.ReadLine();

            Console.WriteLine("Enter the last name of the person ");
            string user_Last_Name = Console.ReadLine();

            Console.WriteLine("Enter the age of a the person");
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
        
        public static void mellan_Number()
        {
            Console.WriteLine("Enter the start number ");
            int start_Number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end number ");
            int end_Number = int.Parse(Console.ReadLine());

            for(int i = start_Number; i <= end_Number; i++)
            {
                Console.Write($"{i},");
            }

        }

        private static void check_even_odd()
        {
            string x = Console.ReadLine();

            for(int i = 0; i <= x.Length - 1; i++)
            {
                int result;
                if (int.TryParse(x[i].ToString(), out result))
                {
                    // user input a valid integer
                    // result varaible have the input integer
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{result} is even");
                    }
                    else
                    {
                        Console.WriteLine($"{result} is odd");
                    }
                }
            }
        }

        private static void add_elements()
        {
            string x = Console.ReadLine();
            int sum_of_Number = 0;
            for (int i = 0; i <= x.Length - 1; i++)
            {
                int result;
                
                if (int.TryParse(x[i].ToString(), out result))
                {
                    // user input a valid integer
                    // result varaible have the input integer
                    sum_of_Number = sum_of_Number + result;
                }
            }

            Console.WriteLine($"sum of total element of a number is {sum_of_Number}");
        }

        public static void Charecter_random()
        {
            //Person1 person = new Person1();
            string health = Console.ReadLine();
            string strength = Console.ReadLine();
            string luck = Console.ReadLine();

            //string helath_mot = Console.ReadLine();
            //string strength_mot = Console.ReadLine();
            //string luck_mot = Console.ReadLine();

            Person person = new Person();
           
            var rand = new Random();
            var randomNumber = 0;

            if (health == person.health)
            {
                randomNumber=rand.Next(1, 6);
                person.termsList.Add(randomNumber);
            }
            if (strength == person.strength)
            {
                randomNumber = rand.Next(1, 6);
                person.termsList.Add(randomNumber);
            }
            if (luck == person.luck)
            {
                randomNumber = rand.Next(1, 6);
                person.termsList.Add(randomNumber);
            }

            foreach (var item in person.termsList)
            {
                Console.WriteLine($"The numbers are {item}");
            }

        }
    }

    class Person
    {
        public string health= "Good";
        public string strength="Strong";
        public string luck="Bad";

        public List<int> termsList = new List<int>();

        public Person()
        {

        }

       
    }

   

}
