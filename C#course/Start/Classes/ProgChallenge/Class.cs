using System;
class Bank
{
    protected int bal;
    protected string owner;
    public Bank()
    {
        Console.WriteLine("Enter the acoount owners name");
        owner = Console.ReadLine();
        Console.WriteLine("Enter the acount balance");
        bal = Console.Read();
    }
    public void Deposit()
    {
        int deposit;
        Console.WriteLine("Enter the amount you want to deposit");
        deposit = Console.Read();
        bal += deposit;
    }
    public void Check()
    {
        Console.WriteLine(owner + ",s balance is " + bal);
    }
    public void Withdraw(int withdraw)
    {
        bal-=withdraw;
        Console.WriteLine("\nMoney withdrawn successfully");
    }
}
class Debit : Bank
{
    public void Withdraw()
    {
        int withdraw;
        Console.WriteLine("\nThe the amount you want to withdraw");
        withdraw = Console.Read();
        if (bal - withdraw < 0)
        {
            Console.WriteLine("\nSince the account does not have enough balance extra charge of 35$ will be added");
            Withdraw(withdraw+35);
        }
        else
        {
            Withdraw(withdraw);
        }
    }
}
class Saving : Bank
{

    protected int rate;
    public void Interest()
    {
        rate = bal + (5 / 100);
        bal += rate;
        Console.WriteLine("\nInterest of 5% successfully applied");
    }
    public void Withdraw()
    {
        
    }
}