using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float number = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        do
        {
            Console.Write("Enter number: ");
            number = float.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }

        }   while (number != 0);

        float sum = 0;

        foreach (float num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;

        Console.WriteLine($"The average is: {average}");

        float max = numbers[0];

        foreach (float num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");
    }
}