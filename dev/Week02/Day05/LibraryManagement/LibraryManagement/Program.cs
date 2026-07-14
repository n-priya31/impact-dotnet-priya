using LibraryManagement;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book{Title="The Alchemist",Author="Paulo Coelho",Genre="Fiction",Year=1988,IsAvailable=true},
                new Book{Title="Brida",Author="Paulo Coelho",Genre="Fiction",Year=1990,IsAvailable=false},
                new Book{Title="Clean Code",Author="Robert Martin",Genre="Programming",Year=2008,IsAvailable=true},
                new Book{Title="Clean Architecture",Author="Robert Martin",Genre="Programming",Year=2017,IsAvailable=true},
                new Book{Title="C# in Depth",Author="Jon Skeet",Genre="Programming",Year=2019,IsAvailable=true},
                new Book{Title="Atomic Habits",Author="James Clear",Genre="Self Help",Year=2018,IsAvailable=true},
                new Book{Title="Deep Work",Author="Cal Newport",Genre="Self Help",Year=2016,IsAvailable=false},
                new Book{Title="Harry Potter",Author="J.K.Rowling",Genre="Fantasy",Year=1997,IsAvailable=true},
                new Book{Title="The Hobbit",Author="J.R.R.Tolkien",Genre="Fantasy",Year=1937,IsAvailable=true},
                new Book{Title="The Lord of the Rings",Author="J.R.R.Tolkien",Genre="Fantasy",Year=1954,IsAvailable=false},
                new Book{Title="The Pragmatic Programmer",Author="Andrew Hunt",Genre="Programming",Year=1999,IsAvailable=true},
                new Book{Title="Think Like a Monk",Author="Jay Shetty",Genre="Self Help",Year=2020,IsAvailable=true},
                new Book{Title="Rich Dad Poor Dad",Author="Robert Kiyosaki",Genre="Finance",Year=1997,IsAvailable=true},
                new Book{Title="The Psychology of Money",Author="Morgan Housel",Genre="Finance",Year=2020,IsAvailable=true},
                new Book{Title="Ikigai",Author="Hector Garcia",Genre="Self Help",Year=2016,IsAvailable=true}
            };

            // 1. Available books by author

            Console.WriteLine("Available Books by Robert Martin\n");

            var availableBooks = books
                .Where(b => b.Author == "Robert Martin" && b.IsAvailable);

            foreach (var book in availableBooks)
            {
                Console.WriteLine(book.Title);
            }

            // 2. Group by Genre

            Console.WriteLine("\nBooks Grouped By Genre\n");

            var groupedBooks = books
                .GroupBy(b => b.Genre);

            foreach (var group in groupedBooks)
            {
                Console.WriteLine($"{group.Key} : {group.Count()} books");
            }

            // 3. Oldest Book

            Console.WriteLine("\nOldest Book\n");

            var oldestBook = books
                .OrderBy(b => b.Year)
                .First();

            Console.WriteLine($"{oldestBook.Title} ({oldestBook.Year})");

            // 4. Books after 2010 sorted by title

            Console.WriteLine("\nBooks After 2010\n");

            var recentBooks = books
                .Where(b => b.Year > 2010)
                .OrderBy(b => b.Title);

            foreach (var book in recentBooks)
            {
                Console.WriteLine($"{book.Title} ({book.Year})");
            }

            Console.ReadKey();
        }
    }
}