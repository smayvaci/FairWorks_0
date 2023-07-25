using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Cryptology
{
    public class FairCyrpt
    {
        // Caesar Şifreleme Anahtar Değeri
        private int key;

        public FairCyrpt(int key)
        {
            this.key = key;
        }

        // Metni şifrelemek için kullanılır
        public string Crypt(string text)
        {
            StringBuilder encryptedText = new StringBuilder();//dilinde metin manipülasyonu için kullanılan bir sınıftır. 

            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(c + key);

                    if (char.IsLower(c))
                    {
                        if (encryptedChar > 'z')
                            encryptedChar = (char)(encryptedChar - 26);
                    }
                    else if (char.IsUpper(c))
                    {
                        if (encryptedChar > 'Z')
                            encryptedChar = (char)(encryptedChar - 26);
                    }

                    encryptedText.Append(encryptedChar);// append metodu stringbuilder içerisinde metin eklemek veya metinleri birleştirmek için kullanılır.Metinleri birleştirme işlemleri için daha verimli bir yöntem olduğu için bu kullanıldı
                }
                else
                {
                    encryptedText.Append(c);
                }
            }

            return encryptedText.ToString();
        }

        // Şifrelenmiş metni çözmek için kullanılır
        public string Decrypt(string encryptedText)
        {
            StringBuilder decryptedText = new StringBuilder();

            foreach (char c in encryptedText)
            {
                if (char.IsLetter(c))
                {
                    char decryptedChar = (char)(c - key);

                    if (char.IsLower(c))
                    {
                        if (decryptedChar < 'a')
                            decryptedChar = (char)(decryptedChar + 26);
                    }
                    else if (char.IsUpper(c))
                    {
                        if (decryptedChar < 'A')
                            decryptedChar = (char)(decryptedChar + 26);
                    }

                    decryptedText.Append(decryptedChar);
                }
                else
                {
                    decryptedText.Append(c);
                }
            }

            return decryptedText.ToString();
        }
    }

}
}
