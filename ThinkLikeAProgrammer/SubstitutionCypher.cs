using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThinkLikeAProgrammer
{
    internal class SubstitutionCypher
    {
        private static readonly char[] CipherAlphabet = { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'M', 'N', 'B', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V' };
        
        internal static void Start()
        {
            Console.Write("Write something: ");
            string plaintext = Console.ReadLine();
            string decodedtext = Decode(plaintext);
            string ciphertext = Encode(plaintext);
            Console.WriteLine(ciphertext);
            Console.WriteLine(decodedtext);
        }

        private static string Encode(string plainText)
        {

            string cipherText = "";
            foreach (char c in plainText)
            {
                if (c > 65 && c < 91)
                {
                    int charIndex = c - 65;
                    cipherText += CipherAlphabet[charIndex];
                }
                    
            }
            return cipherText;
        }

        private static string Decode(string cipherText)
        {
            string plainText = "";
            foreach (char c in cipherText)
            {
                if (c > 65 && c < 91)
                {
                    int charIndex = Array.IndexOf(CipherAlphabet, c);
                    char letterInAlphabet = (char)(65 + charIndex);
                    plainText += letterInAlphabet;
                }
                
            }
            return plainText;
        }
    }
}
