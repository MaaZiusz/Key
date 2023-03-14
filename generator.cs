using System;
using System.Text;

class Program
{
    static void Main()
    {
        int length = 18; // długość generowanego ciągu znaków
        string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        StringBuilder sb = new StringBuilder();
        Random rand = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rand.Next(chars.Length);
            sb.Append(chars[index]);
        }

        string randomString = sb.ToString();
        Console.WriteLine(randomString);
    }
}
