using System;

namespace hotelfloors
{
    class Program
    {
        static void Test(char[][] size, int a, int b, ref int guest)
        {
            if (size[a][b] == 'v' || size[a][b] == '#') return;
            if (size[a][b] == '*') guest ++;
            size[a][b] = 'v';
            Test(size, a + 1, b, ref guest);
            Test(size, a - 1, b, ref guest);
            Test(size, a, b + 1, ref guest);
            Test(size, a, b - 1, ref guest);
        }
        static void Main(string[] args)
        {
            int numberoffloors = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberoffloors; i++)
            {
                int guest = 0;
                int room = 0;
                string[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int height = int.Parse(input[0]);
                int width = int.Parse(input[1]);
                char[][] size = new char[height][];
                for (int k = 0; k < height; k++)
                {
                    size[k] = new char[width];
                    size[k] = Console.ReadLine().ToCharArray();
                }
                
                for (int k = 0; k < height; k++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (size[k][j] == '-' || size[k][j] == '*')
                        {
                            room ++;
                            Test(size, k, j, ref guest);
                        }
                    }
                }
                Console.WriteLine((1f * guest / room).ToString("F"));
            }
        }
       
    }
}