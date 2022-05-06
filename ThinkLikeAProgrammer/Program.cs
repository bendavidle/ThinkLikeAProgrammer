using System;
using System.Collections.Generic;

namespace ThinkLikeAProgrammer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Twoone(false);
            //Twotwo();
            //Twothree();

            //WordCounter.Start();
            //SubstitutionCipher.Start();
            int[] numbers = new int[] { 1, 2, 2, 2, 2, 3, 1, 1, 1 };
            //Console.WriteLine(IsArraySorted(numbers));
            IntMode(numbers);
        }

        private static bool IsArraySorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static void IntMode(int[] numbers)
        {
            Dictionary<int, int> counts = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (counts.ContainsKey(numbers[i]))
                {
                    counts[numbers[i]]++;
                }
                else
                {
                    counts.Add(numbers[i], 1);
                }
            }

            int max = 0;
            Dictionary<int, int> modes = new Dictionary<int, int>();
            foreach (KeyValuePair<int, int> kvp in counts)
            {
                if (kvp.Value >= max)
                {
                    modes.Add(kvp.Key, kvp.Value);
                    max = kvp.Value;
                }
            }

            foreach (KeyValuePair<int, int> kvp in modes)
            {
                Console.WriteLine("Number: {0} appeared {1} times.", kvp.Key, kvp.Value);
            }
        }

        private static void Twoone(bool inverted)
        {
            /*
                 ########
                  ######
                   ####
                    ##
                        */
            int length = 8;
            int height = 4;

            if (inverted)
            {
                length = 2;
                for (int j = 0; j < height; j++)
                {

                    DrawBlank((8 - length) / 2);
                    DrawHash(length);
                    NewLine();
                    length += 2;
                }
            }
            else
            {
                for (int j = 0; j < height; j++)
                {

                    DrawBlank((8 - length) / 2);
                    DrawHash(length);
                    NewLine();
                    length -= 2;
                }

            }

        }

        private static void Twotwo()
        {
            Twoone(true);
            Twoone(false);
        }

        private static void Twothree()
        {
            /*
                #            #
                 ##        ## 
                  ###    ###
                   ########
                   ########
                  ###    ###
                 ##        ##
                #            # 
            */
            int length = 14;
            int[] spaces = new int[] { 0, 1, 2, 3, 3, 2, 1, 0 };

            foreach (int space in spaces)
            {
                DrawBlank(space);
                DrawHash(space + 1);
                DrawBlank(length - 4 * space - 2);
                DrawHash(space + 1);
                NewLine();
            }


        }

        private static void DrawHash(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('#');
            }

        }

        private static void DrawBlank(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(' ');
            }
        }

        private static void NewLine()
        {
            Console.WriteLine();
        }
    }
}
