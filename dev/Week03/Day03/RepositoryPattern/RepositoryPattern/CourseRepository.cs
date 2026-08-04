using System;
using System.Collections.Generic;
using System.Linq;

public class CourseRepository : IRepository<Course>
{
    private readonly List<Course> courses = new();

    public List<Course> GetAll()
    {
        return courses;
    }

    public Course GetById(int id)
    {
        return courses.FirstOrDefault(c => c.Id == id);
    }

    public void Add(Course course)
    {
        courses.Add(course);
        Console.WriteLine($"Course '{course.Title}' added.");
    }

    public void Update(Course course)
    {
        var existing = GetById(course.Id);

        if (existing != null)
        {
            existing.Title = course.Title;
            Console.WriteLine($"Course '{course.Title}' updated.");
        }
    }

    public void Delete(int id)
    {
        var course = GetById(id);

        if (course != null)
        {
            courses.Remove(course);
            Console.WriteLine($"Course '{course.Title}' deleted.");
        }
    }
}