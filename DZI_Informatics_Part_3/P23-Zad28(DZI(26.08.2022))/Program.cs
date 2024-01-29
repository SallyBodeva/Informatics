namespace P23_Zad28_DZI_26._08._2022__
{
    internal class Program
    {
        static void Main()
        {

            char[,] matrix = ReadMatrix(@"C:\Users\EliteBook\Desktop\matrix.txt");
            List<string> words = ReadWords(@"C:\Users\EliteBook\Desktop\words.txt");

            foreach (var item in words)
            {
                if (Contains(matrix,item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        public static List<string> ReadWords(string fileName)
        {
            List<string> lines = new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                using (streamReader)
                {
                    string line = string.Empty;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                return lines;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static char[,] ReadMatrix(string fileName)
        {
            List<string> lines= new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                using (streamReader)
                {
                    string line = string.Empty;
                    while ((line= streamReader.ReadLine())!=null)
                    {
                        lines.Add(line);
                    }
                }
                int firstElementLength = lines.FirstOrDefault().Length;
                char[,] matrix = new char[lines.Count, firstElementLength];
                int insertRowIndex = 0;
                foreach (var item in lines)
                {
                    if (item.Length!=firstElementLength)
                    {
                        return null;
                    }
                    
                    for (int i = 0; i < item.Length; i++)
                    {
                        matrix[insertRowIndex, i] = item[i];
                    }
                    insertRowIndex++;
                }
                return matrix;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static bool Contains(char[,] matrix, string target)
        {
            List<char> line = new List<char>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    line.Add(matrix[i, j]);
                }
                string lineAsWord = new string(line.ToArray());
                line.Reverse();
                string reversedWord = new string(line.ToArray());
                if (lineAsWord.Contains(target) || reversedWord.Contains(target) )
                {
                    return true;
                }
                line = new List<char>();
            }
            return false;
        }
        static void PrintCharMatrix(char[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
