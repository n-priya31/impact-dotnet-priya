using System;
using System.Collections.Generic;
using System.Linq;

public class StudentRepository : IRepository<Student>
{
    private readonly List<Student> students = new();

    public List<Student> GetAll()
    {
        return students;
    }

    public Student GetById(int id)
    {
        return students.FirstOrDefault(s => s.Id == id);
    }

    public void Add(Student student)
    {
        students.Add(student);
        Console.WriteLine($"Student '{student.Name}' added.");
    }

    public void Update(Student student)
    {
        var existing = GetById(student.Id);

        if (existing != null)
        {
            existing.Name = student.Name;
            Console.WriteLine($"Student '{student.Name}' updated.");
        }
    }

    public void Delete(int id)
    {
        var student = GetById(id);

        if (student != null)
        {
            students.Remove(student);
            Console.WriteLine($"Student '{student.Name}' deleted.");
        }
    }
}