using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main()
    {
        List<Book> books = new List<Book>();
        Book b = null;
        while (true)
        {
            string [] bookData = Console.ReadLine().Split(", ").ToArray();
            if (bookData[0]=="End")
            {
                break;
            }
            if (bookData.Length == 6)
            {
                b = new Book(bookData[0], bookData[1], int.Parse(bookData[2]), decimal.Parse(bookData[3]), bookData[4], bookData[5]);
            }
            else
            {
                b = new Book(bookData[0], bookData[1], int.Parse(bookData[2]), decimal.Parse(bookData[3]));
            }
            books.Add(b);
        }
        foreach (var item in books.OrderBy(x=>x.Author))
        {
            Console.WriteLine(item);
        }
    }
}

