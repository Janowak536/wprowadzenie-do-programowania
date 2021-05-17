using System;

namespace hotelfloors
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberoffloors = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberoffloors; i++)
            {
                int guest = 0;
                int room = 0;
                string[] size = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                int height = int.Parse(size[0]);
                int width = int.Parse(size[1]);
                char[][] pattern = new char[width][];  
                for (int k = 0; k < height; k++)
                {
                    pattern[k] = new char[width];
                    pattern[k] = Console.ReadLine().ToCharArray();
                }
                for (int j = 0; j < height; j++)
                {
                    for (int l = 0; l < width; l++)
                    {
                        if (pattern[j][l] == '-' || pattern[j][l] == '*')
                        {
                            room+=1;
                            Test(pattern, j, l, ref guest);
                        }
                    }
                }
                Console.WriteLine((1f * guest / room).ToString("F"));
            }
        }
        public static void Test(char[][] pattern, int a, int b, ref int guest)
        {
            if (pattern[a][b] == 'x' || pattern[a][b] == '#') return;
            if (pattern[a][b] == '*') guest++;
            pattern[a][b] = 'x';
            Test(pattern, a + 1, b, ref guest);
            Test(pattern, a - 1, b, ref guest);
            Test(pattern, a, b + 1, ref guest);
            Test(pattern, a, b - 1, ref guest);
        }
    }
}
