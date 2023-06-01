namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            string userInput = Console.ReadLine();
            int number = Convert.ToInt32(userInput);

            bool isPrime = true;

            for(int i = 2; i < number/2; i++) {
                if(number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(isPrime)
            {
                Console.WriteLine(number + " is a Prime number");
            }
            else { Console.WriteLine(number + " is not a Prime number"); }
        }
    }
}