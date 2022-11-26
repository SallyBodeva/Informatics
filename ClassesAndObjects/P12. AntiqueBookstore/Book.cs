using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;


public class Book
{
    public Book(string title, string author, int pubDate, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.PubDate = pubDate;
        this.Price = price;
        this.Publisher = "Unknown";
        this.Discount ="Unavailable";
    }
    public Book(string title, string author, int pubDate, decimal price, string publisher,string discount):this(title,author,pubDate,price)
    {
        this.Publisher = publisher;
        this.Discount = discount;
    }


    public string Title { get; private set; }
    public string Author { get; private set; }
    public int PubDate { get; private set; }
    public decimal Price { get; private set; }
    public string Publisher { get; private set; }
    public string Discount { get; private set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($"   Author: {this.Author}");
        sb.AppendLine($"    Publication Date: {this.PubDate}");
        sb.AppendLine($"    Price: {this.Price}");
        sb.AppendLine($"     Publisher: {this.Publisher}");
        sb.AppendLine($"     Discount: {this.Discount}");
        return sb.ToString().TrimEnd(); 
    }
}