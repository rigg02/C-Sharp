using System;
void swap(ref bool A, ref bool B)
{
    bool C;
    C = A;
    A = B;
    B = C;
}
Console.WriteLine("Welcome to the cup swapper game\nFirst put the ball in one of the 3 cups and then swap as many times you like.\nAfter you are done guess in which cup the ball is in if you guess correct great otherwise you lose.\nGot it, lets play\nPress any button to continue");
System.Console.ReadKey();
choice:
Console.Clear();
Console.WriteLine("Enter the cup the ball would be in\n1 for cup A\n2 for cup B\n3 for cup C");
int choice = Convert.ToInt32(Console.ReadLine());
bool A = false, B = false, C = false;
switch (choice)
{
    case 1: { A = true; break; }
    case 2: { B = true; break; }
    case 3: { C = true; break; }
    default: { Console.WriteLine("Hey... It looks like you don't know what 1 to 3 means so can you try again correctly this time"); goto choice; System.Console.ReadKey(); }
}
//Start Swapping
bool flag = true;
Console.WriteLine("Now we can start with switching the cups around");
while (flag == true)
{
choice1:
    Console.WriteLine("Enter the first cup to be switched\n1 for cup A\n2 for cup B\n3 for cup C");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
            choice2:
                Console.WriteLine("Enter the second cup to be switched\n1 for cup B\n2 for cup C");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: { swap(ref A, ref B); Console.WriteLine("Swap successful"); break; }
                    case 2: { swap(ref A, ref C); Console.WriteLine("Swap successful"); break; }
                    default: { Console.WriteLine("Hey... It looks like you don't know what 1 or 2 means so can you try again correctly this time"); goto choice2; System.Console.ReadKey(); }
                }
                break;
            }
        case 2:
            {
            choice3:
                Console.WriteLine("Enter the second cup to be switched\n1 for cup A\n2 for cup C");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: { swap(ref B, ref A); Console.WriteLine("Swap successful"); break; }
                    case 2: { swap(ref B, ref C); Console.WriteLine("Swap successful"); break; }
                    default: { Console.WriteLine("Hey... It looks like you don't know what 1 or 2 means so can you try again correctly this time"); goto choice3; System.Console.ReadKey(); }
                }
                break;
            }
        case 3:
            {
            choice4:
                Console.WriteLine("Enter the second cup to be switched\n1 for cup A\n2 for cup B");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1: { swap(ref C, ref A); Console.WriteLine("Swap successful"); break; }
                    case 2: { swap(ref C, ref B); Console.WriteLine("Swap successful"); break; }
                    default: { Console.WriteLine("Hey... It looks like you don't know what 1 or 2 means so can you try again correctly this time"); goto choice4; System.Console.ReadKey(); }
                }
                break;
            }
        default: { Console.WriteLine("Hey... It looks like you don't know what 1 to 3 means so can you try again correctly this time"); goto choice1; System.Console.ReadKey(); }
    }
    Console.WriteLine("To stop swapping press 1");
    choice = Convert.ToInt32(Console.ReadLine());
    if (choice == 1)
    {
        flag = false;
    }
}
//Time to guess
Console.Clear();
choice5:
Console.WriteLine("Finally it's time to guess the cup\nEnter your guess\n1 for cup A\n2 for cup B\n3 for cup C");
choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        {
            if (A == true)
            {
                Console.WriteLine("Great you guessed right");
            }
            else
            {
                Console.WriteLine("Sorry you guessed wrong");
                if (B == true)
                {
                    Console.WriteLine("The ball was in cup B");
                }
                else
                {
                    Console.WriteLine("The ball was in cup C");
                }
            }
            break;
        }
    case 2:
        {
            if (B == true)
            {
                Console.WriteLine("Great you guessed right");
            }
            else
            {
                Console.WriteLine("Sorry you guessed wrong");
                if (A == true)
                {
                    Console.WriteLine("The ball was in cup A");
                }
                else
                {
                    Console.WriteLine("The ball was in cup C");
                }
            }
            break;
        }
    case 3:
        {
            if (C == true)
            {
                Console.WriteLine("Great you guessed right");
            }
            else
            {
                Console.WriteLine("Sorry you guessed wrong");
                if (A == true)
                {
                    Console.WriteLine("The ball was in cup A");
                }
                else
                {
                    Console.WriteLine("The ball was in cup B");
                }
            }
            break;
        }
    default: { Console.WriteLine("Hey... It looks like you don't know what 1 to 3 means so can you try again correctly this time"); goto choice5; System.Console.ReadKey(); }
}
Console.WriteLine("Thanks for tring out the game");