using System;
public class Homework_Caesar
{
    string alfabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
    private string CodeEncode(string input, int k)
    {
        string fullAlfabet = alfabet + alfabet.ToLower();
        int letterQty = fullAlfabet.Length;
        string retVal = "";
        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];
            int index = fullAlfabet.IndexOf(c);
            if (index < 0)
            {
                retVal += c.ToString();
            }
            else
            {
                int codeIndex = (letterQty + index + k) % letterQty;
                retVal += fullAlfabet[codeIndex];
            }
        }
        return retVal;
    }
    public string Encrypt(string plainMessage, int key)
    {
        return CodeEncode(plainMessage, key);
    }
    public string Decrypt(string encryptedMessage, int key)
    {
        return CodeEncode(encryptedMessage, key);
    }
}
class Program
{
    static void Main(string[] args)
    {
        var Cipher = new Homework_Caesar();
        Console.Write("Введите текст: ");
        string message = Console.ReadLine();
        Console.Write("Введите ключ: ");
        int secretKey = Convert.ToInt32(Console.ReadLine());
        string encryptedText = Cipher.Encrypt(message, secretKey);
        Console.WriteLine("Шифровка: {0}", encryptedText);
        Console.ReadLine();
    }
}