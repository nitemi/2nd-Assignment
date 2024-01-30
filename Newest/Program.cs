using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        write();
        for (int row = 1; row < 11; row++)
        {
            for (char column = 'a'; column < 'k'; column++)
            {
                Console.WriteLine($"The cell is ({row}, {column})");
            }
        }
        write();
    }
    //write C# code to find the sum of all integers 1 through 20 that are divisible by 3.
    public static void write()
    {

        int sum = 0;
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0)
            {

                sum += i;
            }

            Console.WriteLine(sum);
        }
    }
}
