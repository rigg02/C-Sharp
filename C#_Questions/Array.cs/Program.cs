using System;
public class Array
{ 
    public static void Main()
    {
        Console.WriteLine("Please enter the number of elements for the array");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entered value is " + n);
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the value for element " + i);
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] nw = new int[n];
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 50)
            {
                nw[c] = arr[i];
                c++;
            }
        }
        Console.WriteLine("The elements greater than 50 are");
        for (int i = 0; i < c; i++)
        {
            Console.WriteLine(nw[i]);
        }
    }
}