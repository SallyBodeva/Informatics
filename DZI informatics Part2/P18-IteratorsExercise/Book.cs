using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    public string Title { get; set; }

    public int Year { get; set; }

    public List<string> Authors { get; set; }

    public override string ToString()
    {
        return $"Book- \"{this.Title}\" - {this.Year}";
    }
}

