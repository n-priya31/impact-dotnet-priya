using System;
using System.Collections.Generic;

class Repository<T> where T : class, new()
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Update(int index, T item)
    {
        if (index >= 0 && index < items.Count)
        {
            items[index] = item;
        }
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < items.Count)
        {
            items.RemoveAt(index);
        }
    }

    public List<T> GetAll()
    {
        return items;
    }
}

class Student
{
    public string Name { get; set; }

    public Student()
    {
    }
}

class Product
{
    public string ProductName { get; set; }

    public Product()
    {
    }
}

class Program
{
    static void Main()
    {
        // Student Repository
        Repository<Student> studentRepo = new Repository<Student>();

        studentRepo.Add(new Student { Name = "Priya" });
        studentRepo.Add(new Student { Name = "Rahul" });

        Console.WriteLine("Students");

        foreach (var student in studentRepo.GetAll())
        {
            Console.WriteLine(student.Name);
        }

        Console.WriteLine();

        // Product Repository
        Repository<Product> productRepo = new Repository<Product>();

        productRepo.Add(new Product { ProductName = "Laptop" });
        productRepo.Add(new Product { ProductName = "Mouse" });

        Console.WriteLine("Products");

        foreach (var product in productRepo.GetAll())
        {
            Console.WriteLine(product.ProductName);
        }
    }
}