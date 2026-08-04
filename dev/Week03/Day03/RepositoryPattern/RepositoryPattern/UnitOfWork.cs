using System;

public class UnitOfWork : IUnitOfWork
{
    public IRepository<Student> Students { get; }

    public IRepository<Course> Courses { get; }

    public UnitOfWork()
    {
        Students = new StudentRepository();
        Courses = new CourseRepository();
    }

    public void Save()
    {
        Console.WriteLine("All changes saved successfully.");
    }
}