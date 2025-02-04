using System;
using System.Runtime.InteropServices;


public class changeCalculator
{
    public static void Main()
    {

        Console.Write("Please enter the dollar amount that the customer owes: ");

        decimal amountOwed;

        amountOwed = decimal.Parse(Console.ReadLine());

        Console.Write("Please enter the amount tended by the customer: ");

        decimal amountTended;

        amountTended = decimal.Parse(Console.ReadLine());

        decimal changeOwed;

        changeOwed = (amountTended - amountOwed);
        Console.WriteLine($"\n\nTotal change due: ${changeOwed}");

        decimal totalCents = (int) (changeOwed * 100);

        int dollars = (int)(totalCents / 100);
        Console.WriteLine($"Dollars: {dollars}");

        int remainingCents = (int) (totalCents % 100);

        int quarters = (remainingCents%100/25);
        Console.WriteLine($"Quarters: {quarters}");

        int dimes = ((remainingCents%25/10));
        Console.WriteLine($"Dimes: {dimes}");

        int nickels = ((remainingCents%10/5));
        if (quarters == 1 || quarters == 3)
        {
            Console.WriteLine("Nickels :0");
        }

        else
        {
            Console.WriteLine($"Nickels: {nickels}");
        }
        Console.WriteLine($"Nickels: {nickels}");

        int pennies = ((remainingCents%5)/1);
        Console.WriteLine($"Pennies: {pennies}");






    }








}

