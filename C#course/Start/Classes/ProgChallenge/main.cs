//Using arrays and foreach loop to take an array from user and filter the array for value above 50
Using System
int main()
{
    int n;
    Console.WriteLine("Please enter the number of elements for the array\n");
    n = Console.Read();
    int arr[n];
    for (int i = 0; i <= n; i++)
    {
        arr[i] = Console.Read();
    }
    int new[n], n = 0;
    foreach (i in arr)
    {
        if (i > 50)
        {
            new[n]= i;
        }
        n++;
    }
    Console.WriteLine("The elements greater than 50 are \n" + new);
}