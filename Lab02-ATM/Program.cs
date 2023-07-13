using System;
namespace Lab02_ATM;

public class Program
{
    public static decimal balance = 0m;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Console.WriteLine()
    }

    public static decimal ViewBalance()
    {
        return balance;
    }

    public static decimal Withdraw(decimal amount)
    {
        //if ballance - amount < 0
        // else balance -= amount
        if (balance - amount < 0)
        {
            return balance;
        }
        else
        {
            return balance -= amount;
        }
        //or
        //exception
    }

    public static decimal Deposit(decimal amount)
    {
        //if amount < 0
        //else balance += amount
        if (amount < 0)
        {
            return balance;
        }
        else
        {
            return balance += amount;
        }
    }

    public static void UserInterface()
    {
        Console.WriteLine(ViewBalance());
        Console.WriteLine(Deposit(20));
        Console.WriteLine(ViewBalance());
        Console.WriteLine(Withdraw(15m));
        Console.WriteLine(ViewBalance());
    }

}

