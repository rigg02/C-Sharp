using System;
int pull(int sticks, int pull)
{
    sticks -= pull;
    return sticks;
}
int sticks = 21, user, comp,i=1;
Console.WriteLine("Hey there, welcome to the game of 21 sticks try beat my unbeatable computer if you dare.\nRules \n1) You go first\n2)One to pick the last stick looses\n3)You can only pull 1 to 4 sticks in one turn\nSimple right, so lets start.\nPress any button to start");
System.Console.ReadKey();
do
{
pull: 
    Console.Clear();
    Console.WriteLine("Round "+i+"\nRemaining Sticks = " + sticks + "\nUser's turn\nEnter the number of sticks you want to pull");
    user = Convert.ToInt32(Console.ReadLine());
    if (user < 1 || user > 4)
    {
        Console.WriteLine("Oops, looks like you entered the wrong numbers lets try again");
        System.Console.ReadKey();
        goto pull;
    }
    sticks = pull(sticks, user);
    if (sticks <= 0)
    {
        Console.WriteLine("Computer Wins");
        break;
    }
    comp = 5 - user;
    sticks = pull(sticks, comp);
    if (sticks <= 0)
    {
        Console.WriteLine("User Wins..... huh I never expected this to happen AGAIN YOU MUST HAVE CHEATED");
        break;
    }
    i++;
} while (true);