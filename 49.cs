// 1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)
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


// 2- Write a program which takes two numbers from the console and displays the maximum of the two.
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers, and I'll tell you which one is bigger!");
            Console.WriteLine("First Number:");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Second Number:");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("{0} is bigger!", a);
            } else if (b > a) { 
                Console.WriteLine("{0} is bigger!", b);
            } else { 
                Console.WriteLine("{0} and {1} are the same!", a, b);
            }

            Console.ReadLine();
        }
    }
}


// 3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the width and height of an image, and I'll tell you if it's landscape or portrait!");
            Console.WriteLine("Width:");
            var w = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Height:");
            var h = Convert.ToInt32(Console.ReadLine());

            if (w > h)
            {
                Console.WriteLine("Landscape");
            } else if (h > w) {
                Console.WriteLine("Portrait");
            } else {
                Console.WriteLine("It's a square!");
            }
            Console.ReadLine();
        }
    }
}