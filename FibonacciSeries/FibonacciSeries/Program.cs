namespace FibonacciSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to print Fibonacci series

            int firstNum = 0, secondNum = 1, nextNum = 0;
            Console.Write("Enter the number up to which to see the Fibonacci series: ");
            string userInput = Console.ReadLine();
            int count = Convert.ToInt32(userInput);

            Console.Write("The Fibonacci series is : " + firstNum +" "+ secondNum);

            for (int i = 2; i < count; i++)
            {
                nextNum = firstNum + secondNum;
                Console.Write(" " + nextNum);
                firstNum = secondNum;
                secondNum = nextNum;

            }
        }
    }
}