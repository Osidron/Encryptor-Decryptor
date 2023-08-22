using System.Net.Security;

namespace Encryptor
{
    internal class Program
    {
        public static List<char> Encryption(List<char> Cipher, int Step)
        {
            if (Step >= 0) 
            {
                for (int i = 0; i < Cipher.Count; i++)
                {
                    for (int j = 0; j < Step; j++)
                    {
                        Cipher[i] = ++Cipher[i];
                    }
                }
                return Cipher; 
            }
            else
            {
                Step = Step * -1;
                for (int i = 0; i < Cipher.Count; i++)
                {
                    for (int j = 0; j < Step; j++)
                    {
                        Cipher[i] = --Cipher[i];
                    }
                }
                return Cipher;
            }
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите шаг шифра (допускается отрицательный) и нажмите Enter");
            string strStep = Console.ReadLine();
            Boolean isParsed = int.TryParse(strStep, out var Step);
            if (!isParsed)
            {
                Console.WriteLine("Введен некорректный шаг");
            }
        Console.WriteLine("Введите текст для зашифровки/расшифровки и нажмите Enter");
        List<char> Text = new List<char>(Console.ReadLine());
        Text = Encryption(Text, Step);
        for (int i = 0; i < Text.Count; i++)
            {
                Console.Write(Text[i]);
            }
        }
    }
}