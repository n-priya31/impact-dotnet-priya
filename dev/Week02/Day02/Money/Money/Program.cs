using System;

class Money
{
    public decimal Amount { get; set; }
    public string Currency { get; set; }

    public Money(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    // + Operator Overloading
    public static Money operator +(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
        {
            throw new Exception("Currency mismatch! Cannot add different currencies.");
        }

        return new Money(m1.Amount + m2.Amount, m1.Currency);
    }

    // == Operator Overloading
    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount && m1.Currency == m2.Currency;
    }

    // != Operator Overloading
    public static bool operator !=(Money m1, Money m2)
    {
        return !(m1 == m2);
    }

    // > Operator Overloading
    public static bool operator >(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new Exception("Currency mismatch!");

        return m1.Amount > m2.Amount;
    }

    // < Operator Overloading
    public static bool operator <(Money m1, Money m2)
    {
        if (m1.Currency != m2.Currency)
            throw new Exception("Currency mismatch!");

        return m1.Amount < m2.Amount;
    }

    // Required when == and != are overloaded
    public override bool Equals(object obj)
    {
        if (obj is Money money)
        {
            return Amount == money.Amount && Currency == money.Currency;
        }

        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
}

class Program
{
    static void Main()
    {
        Money m1 = new Money(1000, "INR");
        Money m2 = new Money(500, "INR");

        Money total = m1 + m2;

        Console.WriteLine($"Total : {total.Amount} {total.Currency}");

        Console.WriteLine(m1 == m2);
        Console.WriteLine(m1 != m2);
        Console.WriteLine(m1 > m2);
        Console.WriteLine(m1 < m2);

        // Uncomment to observe the exception

        // Money m3 = new Money(100, "USD");
        // Money result = m1 + m3;
    }
}