//K Matabane
//2017285772
//17 June 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemALG004r
{
    public class ProblemALG004r
    {
        public void drawMagic(int n = 7, int rotation = 0)
        {
            int[,] square = new int[n, n];
            // Initialize position for 1
            int i = 0;
            int j = n / 2;

            // One by one put all values in magic square
            for (int num = 1; num <= n * n;)
            {
                if (i == -1 && j == n)
                {
                    j = n - 1;
                    i = 0;
                }
                else
                {
                    if (j == n)
                        j = 0;
                    if (i < 0)
                        i = n - 1;
                }

                if (square[i, j] != 0)
                {
                    if (i == 0 && j == n - 1)
                    {
                        i++;
                    }
                    else
                    {
                        i += 2;
                        j--;
                    }
                    continue;
                }
                else
                    // set number
                    square[i, j] = num++;

                j++;
                i--;
            }
            switch (rotation)
            {
                case 1:
                    square = Rotate(square);
                    break;
                case 2:
                    square = Rotate(Rotate(square));
                    break;
                case 3:
                    square = Rotate(Rotate(Rotate(square)));
                    break;
            }
            Console.WriteLine($"A solution to a {n} X {n} Magic Square is: \n");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                    Console.Write((square[i, j] + "|").PadLeft(3, ' '));
                Console.WriteLine();
            }
        }

        public int[,] Rotate(int[,] arry)
        {
            int n = arry.GetLength(0);
            int j = 0;
            int p = 0;
            int q = 0;
            int i = n - 1;
            int[,] rotatedArr = new int[n, n];

            for (int k = 0; k < n; k++)
            {

                while (i >= 0)
                {
                    rotatedArr[p, q] = arry[i, j];
                    q++;
                    i--;
                }
                j++;
                i = n - 1;
                q = 0;
                p++;

            }
            return rotatedArr;

        }
    }
}
