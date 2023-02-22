namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MIN_DAYS = 0, MAX_DAYS = 31;

            int numberOfDays = GetNumber("Please enter the number of days you exercised this month ", MIN_DAYS, MAX_DAYS);

            
        }

        public static int GetNumber(string msg, int min, int max)
        {
            int number;

            Console.Write(msg);
            bool valid = int.TryParse(Console.ReadLine(), out number);

            while (!valid || number < min || number > max)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("$Error invalid number: {msg}");
                Console.ForegroundColor = ConsoleColor.White;
                valid = int.TryParse(Console.ReadLine(), out number);

            }

            return number;
        }

    }
}