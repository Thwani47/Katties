using System;

namespace Skener
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var r = int.Parse(input[0]);
            var c = int.Parse(input[1]);
            var zr = int.Parse(input[2]);
            var zc = int.Parse(input[3]);

            var article = new char[r, c];
            
            for(var i = 0; i < r; i++)
            {
                var line = Console.ReadLine();
                for(var j = 0; j < c; j++)
                {
                    article[i,j] = line[j];
                }
            }
            SkenArticle(article, r, c, zr, zc);
        }

        private static void SkenArticle(char[,] article, int r, int c, int zr, int zc)
        {
            for(var i = 0; i < r; i++)
            {
                for(var k = 0; k < zr; k++)
                {
                    for(var j = 0; j < c; j++)
                    {
                        for(var l = 0; l < zc; l++)
                        {
                            Console.Write(article[i,j]);
                        }
                    }
					Console.WriteLine();
                }
            }
        }
    }
}
