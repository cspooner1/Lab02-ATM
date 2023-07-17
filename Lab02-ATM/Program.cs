using System;
namespace Lab02_ATM;

public class Program
{
    public static decimal balance = 0m;

    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        UserInterface();
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
            Console.WriteLine("Insufficient funds. Cannot withdraw more than the balance.");
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
            Console.WriteLine("Invalid amount. Cannot deposit a negative value.");
            return balance;
        }
        else
        {
            return balance += amount;
        }
    }

    public static void UserInterface()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("View Balance");
        Console.WriteLine("Withdraw");
        Console.WriteLine("Deposit");
        Console.WriteLine("Exit");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                Console.WriteLine("Current Balance: $" + ViewBalance());
                break;
            case "2":
                Console.WriteLine("Enter the amount to withdraw: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                {
                    Withdraw(withdrawAmount);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid amount.");
                }
                break;
            case "3":
                Console.WriteLine("Enter the amount to deposit: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                {
                    Deposit(depositAmount);
                }
                else
                {
                    Console.WriteLine("Invalid input. PLease enter a valid amount.");
                }
                break;
            case "4":
                exit = true;
                Console.WriteLine("Thank You!");
                break;
            default:
                Console.WriteLine("Invalid option. Please choose a valid option.");
                break;
        }
    }

}

