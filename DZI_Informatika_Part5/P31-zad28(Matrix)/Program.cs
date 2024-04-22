using System.Reflection.Metadata.Ecma335;

public class Program
{
	static void Main()
	{
		string matrixFileName = @"C:\Users\EliteBook\Desktop\Informatics\DZI_Informatika_Part5\P31-zad28(Matrix)\table.txt";
		string wordsFileName = @"C:\Users\EliteBook\Desktop\Informatics\DZI_Informatika_Part5\P31-zad28(Matrix)\words.txt";

		char[,] matrix =ReadMatrix(matrixFileName);
		List<string> words = ReadWords(wordsFileName);

		foreach (var item in words)
		{
			if (Contains(matrix,item))
			{
                Console.WriteLine(item);
            }
		}
	}
	public static bool Contains(char[,] matrix, string word)
	{
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			string line = string.Empty;
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				line += $"{matrix[i, j]}";
			}
			if (line.Contains(word))
			{
				return true;
			}
			string reversedLine = new string(line.Reverse().ToArray());
			if (reversedLine.Contains(word))
			{
				return true;
			}
		}
		return false;
	}
	public static char[,] ReadMatrix(string fileName)
	{
		string[] fileInfo = File.ReadAllLines(fileName);
		char[,] matrix = new char[fileInfo.Length, fileInfo.Length];
		int squareCount = fileInfo[0].Length;
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			string line = fileInfo[i];
			if (line.Length != squareCount)
			{
				return null;
			}
			for (int j = 0; j < line.Length; j++)
			{
				matrix[i, j] = line[j];
			}
		}
		return matrix;
	}
	public static List<string> ReadWords(string fileName)
	{
		List<string> words = new List<string>();
		try
		{
			string[] fileInfo = File.ReadAllLines(fileName);
			foreach (var line in fileInfo)
			{
				words.Add(line);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		return words;
	}
}