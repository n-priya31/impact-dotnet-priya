using System;

public class AccessModifierDemo
{
    public string PublicValue = "Public - Accessible Everywhere";
    private string PrivateValue = "Private - Only inside class";
    protected string ProtectedValue = "Protected - Inherited classes only";
    internal string InternalValue = "Internal - Same project only";

    public void ShowAccess()
    {
        Console.WriteLine(PublicValue);
        Console.WriteLine(PrivateValue);
        Console.WriteLine(ProtectedValue);
        Console.WriteLine(InternalValue);
    }
}