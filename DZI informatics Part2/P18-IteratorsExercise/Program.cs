using System;
using System.Linq;

public class Program
{
    static void Main()
    {
        ListBooks books = new ListBooks();
        Book b1 = new Book() { Title = "The secret of Dior", Year = 2020 };
        Book b2 = new Book() { Title = "Test", Year = 2019 };
        Book b3 = new Book() { Title = "Test 1", Year = 2018 };

        books.Add(b1);
        books.Add(b2);
        books.Add(b3);

        foreach (var item in books)
        {
            Console.WriteLine(item);
        }


    }
}

