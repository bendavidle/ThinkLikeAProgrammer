using System;

namespace ThinkLikeAProgrammer
{
    internal class SubstitutionCypher
    {
        //{ 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'M', 'N', 'B', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V' }
        private static readonly char[] CipherAlphabet;


        static SubstitutionCypher()
        {
            CipherAlphabet = GenerateRandomCipherKey();
        }

        private static char[] GenerateRandomCipherKey()
        {
            Random rand = new Random();
            int arrayLength = 26;
            char[] key = new char[arrayLength];
            int?[] usedIndexes = new int?[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                int randomIndex = rand.Next(0, arrayLength);
                char randomChar = (char)('A' + i);
                int randomCharIndex = randomChar - 65;


                if (randomCharIndex == randomIndex)
                {
                    randomIndex = rand.Next(0, arrayLength);
                }

                while (usedIndexes[randomIndex] != null)
                {
                    randomIndex = rand.Next(0, arrayLength);
                    if (randomCharIndex == randomIndex)
                    {
                        randomIndex = rand.Next(0, arrayLength);
                    }
                }

                key[randomIndex] = randomChar;
                usedIndexes[randomIndex] = randomIndex;
            }

            return key;
        }

        internal static void Start()
        {
            Console.WriteLine(CipherAlphabet);
            Console.Write("Write something: ");
            string plaintext = Console.ReadLine();
            string decodedtext = Decode(plaintext);
            string ciphertext = Encode(plaintext);
            Console.WriteLine("Encoded: " + ciphertext);
            Console.WriteLine("Decoded: " + decodedtext);
        }

        private static string Encode(string plainText)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                char upper = char.ToUpper(c);
                int charIndex = upper - 65;
                cipherText += CipherAlphabet[charIndex];
            }
            return cipherText;
        }

        private static string Decode(string cipherText)
        {
            string plainText = "";
            foreach (char c in cipherText)
            {
                int charIndex = Array.IndexOf(CipherAlphabet, c);
                char letterInAlphabet = (char)('A' + charIndex);
                plainText += letterInAlphabet;
            }
            return plainText;
        }
    }
}
