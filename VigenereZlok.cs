using System;
public class Vigenere_Homework
{
    const string defaultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    readonly string letters;
    public Vigenere_Homework(string alphabet = null)
    {
        letters = string.IsNullOrEmpty(alphabet) ? defaultAlphabet : alphabet;
    }
    private string GetRepeatKey(string s, int n)
    {
        string p = s;
        while (p.Length < n)
        {
            p += p;
        }
        return p.Substring(0, n);
    }
    private string Vigenere(string text, string password, bool encrypting = true)
    {
        string gamma = GetRepeatKey(password, text.Length);
        string retValue = "";
        int q = letters.Length;

        for (int i = 0; i < text.Length; i++)
        {
            int letterIndex = letters.IndexOf(text[i]);
            int codeIndex = letters.IndexOf(gamma[i]);
            if (letterIndex < 0)
            {
                retValue += text[i].ToString();
            }
            else
            {
                retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
            }
        }
        return retValue;
    }
    public string Encrypt(string plainMessage, string password)
    {
        return Vigenere(plainMessage, password);
    }
    public string Decrypt(string encryptedMessage, string password)
    {
        return Vigenere(encryptedMessage, password, false);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vigenere_Homework cipher = new Vigenere_Homework("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
        Console.Write("Введите текст: ");
        string inputText = Console.ReadLine().ToUpper();
        Console.Write("Введите ключ: ");
        string password = Console.ReadLine().ToUpper();
        string encryptedText = cipher.Encrypt(inputText, password);
        Console.WriteLine("Зашифрованное сообщение: {0}", encryptedText);
        Console.WriteLine("Расшифрованное сообщение: {0}", cipher.Decrypt(encryptedText, password));
        Console.ReadLine();
    }
}