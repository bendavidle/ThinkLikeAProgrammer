using System;

namespace ThinkLikeAProgrammer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //twoone(false);
            //twotwo();
            //twothree();

            //WordCounter.Start();
            SubstitutionCypher.Start();
        }

        private static void twoone(bool inverted)
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

                    drawBlank((8 - length) / 2);
                    drawHash(length);
                    newLine();
                    length += 2;
                }
            }
            else
            {
                for (int j = 0; j < height; j++)
                {

                    drawBlank((8 - length) / 2);
                    drawHash(length);
                    newLine();
                    length -= 2;
                }

            }

        }

        private static void twotwo()
        {
            twoone(true);
            twoone(false);
        }

        private static void twothree()
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
            int[] spaces = new int[] {0, 1, 2, 3, 3, 2, 1, 0};

            foreach (int space in spaces)
            {
                drawBlank(space);
                drawHash(space + 1);
                drawBlank(length - 4 * space - 2);
                drawHash(space + 1);
                newLine();
            }


        }

        private static void drawHash(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write('#');
            }

        }

        private static void drawBlank(int i)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(' ');
            }
        }

        private static void newLine()
        {
            Console.WriteLine();
        }
    }
}
