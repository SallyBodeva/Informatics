public class Program
{
    public static void Main()
    {
        string encryptedMessage = Console.ReadLine();
        while (true)
        {
            string[] input = Console.ReadLine().Split("|");
            if (input[0]=="Decode")
            {
                Console.WriteLine($"The decrypted message is: {encryptedMessage}");
                Environment.Exit(0);
            }
            string commnad = input[0];
            switch (commnad)
            {
                case "Move":
                    int n = int.Parse(input[1]);
                    string substring = encryptedMessage.Substring(0, n);
                    encryptedMessage = encryptedMessage.Substring(n, encryptedMessage.Length - n) + substring;
;                    break;
                case "Insert":
                    int index = int.Parse(input[1]);
                    string value = input[2];
                    encryptedMessage = encryptedMessage.Insert(index,value);
                    break;
                case "ChangeAll":
                    string oldValue = input[1];
                    string replacement = input[2];

                    encryptedMessage = encryptedMessage.Replace(oldValue,replacement);
                    break;
            }
        }
    }
}
