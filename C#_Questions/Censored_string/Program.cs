using System;
public class Censored_String
{
    public static void Main()
    {
        Console.WriteLine("Enter the censored string");
        string str = Console.ReadLine();
        Console.WriteLine("Enter the string of censored letters");
        string cor = Console.ReadLine();
        foreach (char ch in cor)
        {
            int a = str.IndexOf('*');
            Console.WriteLine(a);
            str = str.Remove(a, 1).Insert(a, ch.ToString());
        }
        Console.WriteLine(str);
    }
}