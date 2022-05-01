using System;
public class Program
{
    public static int NextPrime(int num)
    {
        for (int i = 2; i < num; i++)
        {
            if (num % i == 0) { num++; i = 2; }
        }
        return num;
    }
    public static void Main()
    {
        Console.WriteLine("Enter a prime number");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Next prime number is " + NextPrime(num));
    }
}
