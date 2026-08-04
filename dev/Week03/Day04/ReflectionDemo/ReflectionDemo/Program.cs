using System;
using System.Reflection;

class Program
{
    static void Main()
    {
        Type type = typeof(Invoice);

        // Class Name
        Console.WriteLine("Class Name:");
        Console.WriteLine(type.Name);

        Console.WriteLine();

        // Properties
        Console.WriteLine("Properties:");

        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine($"{property.Name} - {property.PropertyType.Name}");
        }

        Console.WriteLine();

        // Methods
        Console.WriteLine("Methods:");

        foreach (MethodInfo method in type.GetMethods())
        {
            if (method.DeclaringType == type)
            {
                Console.WriteLine(method.Name);
            }
        }

        Console.WriteLine();

        // Constructors
        Console.WriteLine("Constructors:");

        foreach (ConstructorInfo constructor in type.GetConstructors())
        {
            Console.Write($"{type.Name}(");

            ParameterInfo[] parameters = constructor.GetParameters();

            for (int i = 0; i < parameters.Length; i++)
            {
                Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");

                if (i < parameters.Length - 1)
                    Console.Write(", ");
            }

            Console.WriteLine(")");
        }

        Console.WriteLine();

        // Create object using Reflection
        object invoice = Activator.CreateInstance(type);

        // Set Property using Reflection
        PropertyInfo customerProperty = type.GetProperty("CustomerName");

        customerProperty.SetValue(invoice, "Priya");

        Console.WriteLine("Object created using Reflection.");

        Console.WriteLine("CustomerName = " +
            customerProperty.GetValue(invoice));

        Console.ReadKey();
    }
}