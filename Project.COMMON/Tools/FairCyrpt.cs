using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Project.COMMON.Tools
{
    public static class FairCyrpt
    {


        public static string Cyrpt(string plainText, int shift)
        {
            if (string.IsNullOrEmpty(plainText))
                return string.Empty;

            shift %= 26; 

            char[] encryptedChars = new char[plainText.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                char ch = plainText[i];

                if (char.IsLetter(ch))
                {
                    char baseChar = char.IsUpper(ch) ? 'A' : 'a';
                    encryptedChars[i] = (char)(((ch - baseChar + shift) % 26) + baseChar);
                }
                else
                {
                    encryptedChars[i] = ch;
                }
            }

            return new string(encryptedChars);
        }

        public static string Decrypt(string encryptedText, int shift)
        {
            return Cyrpt(encryptedText, 26 - shift);
        }
    }



}

