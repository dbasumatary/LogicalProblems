namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program to measure time elapsed in a stopwatch

            Console.Write("Enter the start time: ");
            string startInput = Console.ReadLine();
            DateTime startTime = DateTime.Now;
            Console.WriteLine(startTime.ToString());

            Console.Write("Enter the end time: ");
            string endInput = Console.ReadLine();
            DateTime endTime = DateTime.Now;
            Console.WriteLine(endTime.ToString());

            Console.WriteLine();
            TimeSpan elapsedTime = endTime - startTime;
            Console.WriteLine("The elapsed time is " + elapsedTime.TotalSeconds + " seconds");

            /*Console.WriteLine("Enter the starting time (HH:MM:SS)");
            string startInput = Console.ReadLine();
            TimeSpan startTime = TimeSpan.Parse(startInput);

            Console.WriteLine("Enter the ending time (HH:MM:SS)");
            string endInput = Console.ReadLine();
            TimeSpan endTime = TimeSpan.Parse(endInput);

            TimeSpan elapsedTime = endTime - startTime;
            Console.WriteLine("The elapsed time is " + elapsedTime.TotalSeconds + " seconds");*/
        }
    }
}