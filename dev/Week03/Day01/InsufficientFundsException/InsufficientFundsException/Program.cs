using Banking;
using System;

class Program
{
    public static void Main()
    {
        Account account = new Account(1000);

        try
        {
            Console.WriteLine("Enter withdrawal amount : ");
            decimal amount = decimal.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        catch(InsufficientFundsException ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine($"Deficit Amount : {ex.DeficitAmount}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid number format.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected Error : {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Withdrawal attempt has been logged.");
        }
    }
}