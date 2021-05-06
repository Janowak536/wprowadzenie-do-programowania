using System;

namespace ledy
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] jeden = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };

            char[,] dwa = new char[3, 3] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { '|', '_', ' ' } };

            char[,] trzy = new char[3, 3] { { ' ', '_', ' ' }, { ' ', '_', '|' }, { ' ', '_', '|' } };

            char[,] cztery = new char[3, 3] { { ' ', ' ', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            char[,] piec = new char[3, 3] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { ' ', '_', '|' } };

            char[,] szesc = new char[3, 3] { { ' ', '_', ' ' }, { '|', '_', ' ' }, { '|', '_', '|' } };

            char[,] siedem = new char[3, 3] { { ' ', '_', ' ' }, { ' ', ' ', '|' }, { ' ', ' ', '|' } };

            char[,] osiem = new char[3, 3] { { ' ', '_', ' ' }, { '|', '_', '|' }, { '|', '_', '|' } };

            char[,] dziewiec = new char[3, 3] { { ' ', '_', ' ' }, { '|', '_', '|' }, { ' ', ' ', '|' } };

            char[,] zero = new char[3, 3] { { ' ', '_', ' ' }, { '|', ' ', '|' }, { '|', '_', '|' } };

            string inputValues = Console.ReadLine();

            for (int j = 0; j < inputValues.Length; j++)
            {
                for (int i = 0; i < inputValues.Length; i++)
                {
                    for (int k = 0; k < inputValues.Length; k++)
                    {

                        switch (inputValues[k])
                        {
                            case '1':
                                Console.Write($"{jeden[i, 0]}{jeden[i, 1]}{jeden[i, 2]}");
                                break;
                            case '2':
                                Console.Write($"{dwa[i, 0]}{dwa[i, 1]}{dwa[i, 2]}");
                                break;
                            case '3':
                                Console.Write($"{trzy[i, 0]}{trzy[i, 1]}{trzy[i, 2]}");
                                break;
                            case '4':
                                Console.Write($"{cztery[i, 0]}{cztery[i, 1]}{cztery[i, 2]}");
                                break;
                            case '5':
                                Console.Write($"{piec[i, 0]}{piec[i, 1]}{piec[i, 2]}");
                                break;
                            case '6':
                                Console.Write($"{szesc[i, 0]}{szesc[i, 1]}{szesc[i, 2]}");
                                break;
                            case '7':
                                Console.Write($"{siedem[i, 0]}{siedem[i, 1]}{siedem[i, 2]}");
                                break;
                            case '8':
                                Console.Write($"{osiem[i, 0]}{osiem[i, 1]}{osiem[i, 2]}");
                                break;
                            case '9':
                                Console.Write($"{dziewiec[i, 0]}{dziewiec[i, 1]}{dziewiec[i, 2]}");
                                break;
                            case '0':
                                Console.Write($"{zero[i, 0]}{zero[i, 1]}{zero[i, 2]}");
                                break;
                        }
                        
                    }
                    Console.WriteLine();
                }

            }





        }
    }
}