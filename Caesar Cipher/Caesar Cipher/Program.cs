using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string Message = Encrypt("Cheese Please!", 15, 20);
            Console.WriteLine(Message);
            Console.WriteLine(Decrypt(Message, 15, 20));
            Console.ReadKey();
        }
        public static string Encrypt(string plaintext, int key1, int key2)
        {
            string tempChars = "";
            for (int i = 0; i < plaintext.Length; i++)
            {
                int asciiCode = (int)plaintext[i];
                if (char.IsUpper(plaintext[i]))
                {
                    asciiCode = asciiCode - 65;
                    asciiCode = asciiCode + KeySelector(key1, key2, i, asciiCode);
                    asciiCode = asciiCode % 26;
                    asciiCode = asciiCode + 65;
                }
                else if (char.IsLower(plaintext[i]))
                {
                    asciiCode = asciiCode - 97;
                    asciiCode = asciiCode + KeySelector(key1, key2, i, asciiCode);
                    asciiCode = asciiCode + 26;
                    asciiCode = asciiCode % 26;
                    asciiCode = asciiCode + 97;
                }
                tempChars = tempChars + (char)asciiCode;
            }
            return tempChars;
        }
        public static string Decrypt(string cipherText, int key1, int key2)
        {
            string tempChars = "";
            for (int i = 0; i < cipherText.Length; i++)
            {
                int asciiCode = (int)cipherText[i];
                if (char.IsUpper(cipherText[i]))
                {
                    asciiCode = asciiCode - 65;
                    asciiCode = asciiCode - KeySelector(key1, key2, i, asciiCode);
                    asciiCode = asciiCode + 26;
                    asciiCode = asciiCode % 26;
                    asciiCode = asciiCode + 65;

                }
                else if (char.IsLower(cipherText[i]))
                {
                    asciiCode = asciiCode - 97;
                    asciiCode = asciiCode - KeySelector(key1, key2, i, asciiCode);
                    asciiCode = asciiCode + 26;
                    asciiCode = asciiCode % 26;
                    asciiCode = asciiCode + 97;
                }
                tempChars = tempChars + (char)asciiCode;
            }
            return tempChars;
        }
        public static int KeySelector(int key1, int key2, int i, int asciiCode)
        {
            int key;
            if (i % 2 == 0)
            {
                key = key1;
            }
            else
            {
                key = key2;
            }
            return key;
        }
    }
}
