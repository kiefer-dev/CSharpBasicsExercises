namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number between 1 and 10");
            var inputNum = Convert.ToInt32(Console.ReadLine());

            if (inputNum >= 1 && inputNum <= 10)
            {
                Console.WriteLine("Valid");
            } else {
                Console.WriteLine("Invalid");
            }
            Console.ReadLine();
        }
    }
}