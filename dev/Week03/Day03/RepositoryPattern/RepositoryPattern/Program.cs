using System;

class Program
{
    static void Main(string[] args)
    {
        IUnitOfWork unitOfWork = new UnitOfWork();

        unitOfWork.Students.Add(new Student
        {
            Id = 1,
            Name = "Priya"
        });

        unitOfWork.Courses.Add(new Course
        {
            Id = 101,
            Title = "C# Fundamentals"
        });

        unitOfWork.Save();

        Console.WriteLine();

        Console.WriteLine("Students:");

        foreach (var student in unitOfWork.Students.GetAll())
        {
            Console.WriteLine($"{student.Id} - {student.Name}");
        }

        Console.WriteLine();

        Console.WriteLine("Courses:");

        foreach (var course in unitOfWork.Courses.GetAll())
        {
            Console.WriteLine($"{course.Id} - {course.Title}");
        }

        Console.ReadKey();
    }
}