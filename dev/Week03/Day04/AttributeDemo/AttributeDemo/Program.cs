using System;

class Program
{
    static void Main()
    {
        User user = new User
        {
            Name = "Priyadharshini"
        };

        Validator.Validate(user);

        Console.ReadKey();
    }
}