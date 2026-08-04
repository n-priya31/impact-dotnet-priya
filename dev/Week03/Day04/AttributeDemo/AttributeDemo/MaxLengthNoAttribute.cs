using System;

[AttributeUsage(AttributeTargets.Property)]
public class MaxLengthNoAttribute : Attribute
{
    public int Length { get; }

    public MaxLengthNoAttribute(int length)
    {
        Length = length;
    }
}