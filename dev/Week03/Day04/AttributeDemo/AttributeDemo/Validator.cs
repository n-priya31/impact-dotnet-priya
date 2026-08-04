using System;
using System.Reflection;

public class Validator
{
    public static void Validate(object obj)
    {
        Type type = obj.GetType();

        foreach (PropertyInfo property in type.GetProperties())
        {
            MaxLengthNoAttribute attribute =
                property.GetCustomAttribute<MaxLengthNoAttribute>();

            if (attribute != null)
            {
                string value = property.GetValue(obj)?.ToString();

                if (value != null && value.Length > attribute.Length)
                {
                    Console.WriteLine(
                        $"Warning: {property.Name} exceeds maximum length of {attribute.Length}.");
                }
            }
        }
    }
}