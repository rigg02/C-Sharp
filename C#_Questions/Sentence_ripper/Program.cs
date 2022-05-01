using System;
public class Sentence_ripper
{
    public static void Main()
    {
        Console.WriteLine("Enter a sentence");
        string str = Console.ReadLine();
        foreach (char ch in str)
        {
            if (ch == ' ')
            {
                Console.Write("\n");
            }
            else
            {
                Console.Write(ch);
            }
        }
    }
}
