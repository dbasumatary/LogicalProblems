namespace ReverseNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to find reverse of a number

            Console.WriteLine("Enter the number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);
            Console.WriteLine("The original number is " + number);

            int reverse = 0;
            while(number != 0)
            {
                int remainder = number % 10;
                reverse = reverse * 10 + remainder;
                number = number/10;
            }
            Console.WriteLine("The reversed number is " +  reverse);
        }
    }
}