public class Program
{
    public static void Main()
    {
        List<Book> bookd = new List<Book>();
        while (true)
        {
            string[] input = Console.ReadLine().Split(", ");
            if (input[0] == "End")
            {
                foreach (var item in bookd.OrderBy(x=>x.Auhtor))
                {
                    Console.WriteLine(item);
                }
                Environment.Exit(0);
            }
            string title = input[0];
            string author = input[1];
            int pubDate = int.Parse(input[2]);
            decimal price = decimal.Parse(input[3]);
            string publisher = null;
            string discount = null;
            Book book = null;
            book = new Book(title, author, pubDate, price);
            if (input.Length>4)
            {
                publisher = input[4];
                book = new Book(title, author, pubDate, price, publisher);
                if (input.Length>5)
                {
                    if (publisher != null)
                    {
                        discount = input[5];
                        book = new Book(title, author, pubDate, price, publisher, discount);
                    }
                }
            }
            bookd.Add(book);
        }
    }
}
