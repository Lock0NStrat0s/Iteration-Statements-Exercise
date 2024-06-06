namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintNumbers1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintNumbers3()
        {
            for (int i = 3; i < 1000; i += 3)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool CheckEqual(int num1, int num2)
        {
            return num1 == num2;
        }
        //Write a method to check whether a given number is even or odd
        public static bool CheckEven(int num)
        {
            return num % 2 == 0;
        }
        //Write a method to check whether a given number is positive or negative
        public static bool CheckPositive(int num)
        {
            return num > 0;
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void CanVote()
        {
            Console.WriteLine("What is your age: ");
            int.TryParse(Console.ReadLine(), out int age);

            if (age >= 18)
            {
                Console.WriteLine("You can vote!");
            }
            else
            {
                Console.WriteLine("You cannot vote.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool CheckRange()
        {
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int num);

            return num >= -10 && num <= 10;
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable()
        {
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int num);

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintNumbers1000();
            //PrintNumbers3();
            //Console.WriteLine(CheckEqual(5, 5));
            //Console.WriteLine(CheckEven(5));
            //Console.WriteLine(CheckPositive(5));
            //CanVote();
            //Console.WriteLine(CheckRange());
            //MultiplicationTable();

        }
    }
}
