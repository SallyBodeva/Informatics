using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Book
{
    public Book(string title, string auhtor, int pubDate, decimal price, string publisher = "Unknown", string discount = "Unavailable")
    {
        Title = title;
        Auhtor = auhtor;
        PubDate = pubDate;
        Price = price;
        Publisher = publisher;
        Discount = discount;
    }

    public string Title { get; set; }
    public string Auhtor { get; set; }

    public int PubDate { get; set; }
    public decimal Price { get; set; }
    public string Publisher { get; set; }
    public string Discount { get; set; }
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Title: {this.Title}");
        sb.AppendLine($" Author: {this.Auhtor}");
        sb.AppendLine($" Publication Date: {this.PubDate}");
        sb.AppendLine($" Publisher: {this.Publisher}");
        sb.AppendLine($" Discount: {this.Discount}");

        return sb.ToString().TrimEnd(); 
    }
}
