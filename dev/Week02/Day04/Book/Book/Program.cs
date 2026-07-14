using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public string Title { get; set; }
}

class BookCollection : IEnumerable<Book>
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public IEnumerator<Book> GetEnumerator()
    {
        foreach (Book book in books.OrderBy(b => b.Title))
        {
            yield return book;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

class Program
{
    // Yield Return Example
    static IEnumerable<int> GetEvenNumbers(int max)
    {
        for (int i = 2; i <= max; i += 2)
        {
            yield return i;
        }
    }

    static void Main()
    {
        Console.WriteLine("Even Numbers:");

        foreach (int number in GetEvenNumbers(10))
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();

        BookCollection library = new BookCollection();

        library.AddBook(new Book { Title = "C# Programming" });
        library.AddBook(new Book { Title = "Algorithms" });
        library.AddBook(new Book { Title = "ASP.NET Core" });

        Console.WriteLine("Books (Alphabetical Order):");

        foreach (Book book in library)
        {
            Console.WriteLine(book.Title);
        }
    }
}