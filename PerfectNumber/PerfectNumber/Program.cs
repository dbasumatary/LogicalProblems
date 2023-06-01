namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to check if the number entered is perfect or not

            Console.WriteLine("Enter the number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);

            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                //Checking perfectly divisible numbers
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }

            if (sum == number)
            {
                Console.WriteLine(number + " is a perfect number");
            }
            else { Console.WriteLine(number + " is NOT a perfect number"); }
        }
    }
}