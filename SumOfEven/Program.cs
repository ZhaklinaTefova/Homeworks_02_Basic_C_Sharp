namespace SumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SumOfEven");

            /*
            Make a console application called SumOfEven. Inside it create an array of 6 integers. 
            Find and print the sum of the even numbers from the array:

             Test Data:
                Enter integer no.1:
                    4
                Enter integer no.1:
                    3
                Enter integer no.1:
                    7
                Enter integer no.1:
                    3
                Enter integer no.1:
                    2
                Enter integer no.1:
                    8
                Expected Output:
                The result is: 14
            */

            int count = 6;
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter your number {i+1}: ");
                string input = Console.ReadLine();
                if(!int.TryParse(input, out int number))
                {
                    Console.WriteLine("Wrong input!");
                    return;
                }
                numbers[i] = number;
            }

            int sum = 0;
            Console.Write("Your numbers are:");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
                sum += i;
            }
            
            Console.WriteLine("\nSum of your numbers is:" + sum);
        }
    }
}