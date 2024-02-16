namespace P14_RandomPassword
{
    public class Program
    {
        static void Main()
        {
            Random r= new Random();
            int length = r.Next(8, 17);
            char[] password = new char[length];
            char capitalLetter = (char)r.Next('A', 'Z');
            char notCapitalLetter = (char)r.Next('a', 'z');
            char[] specialSumbols = { '#', '$', '%', '&' };
            for (int i = 0; i < password.Length; i++)
            {
                password[r.Next(0,length-1)] = 
            }

            //TODO

        }
    }
}
