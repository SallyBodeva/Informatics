public class Program
{
	static void Main()
	{
		Dictionary<string, int> filesExtensions = new Dictionary<string, int>();
		string path = @"C:\Users\EliteBook\Desktop\Нова папка";


		var names = Directory.EnumerateFiles(path);
		foreach (var item in names)
		{
			string extension = Path.GetExtension(item);
			if (filesExtensions.ContainsKey(extension))
			{
				filesExtensions[extension]++;
			}
			else
			{
				filesExtensions.Add(extension, 1);
			}
        }
		foreach (var item in filesExtensions)
		{
            Console.WriteLine($"{item.Key} - {item.Value}");
        }
    }
}