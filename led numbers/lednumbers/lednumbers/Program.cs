using System;

namespace lednumbers
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

            for (int i = 0; i < inputValues.Length; i++)
            {

                switch (inputValues[i])
                {
                    case '1':
                        Console.Write($"{jeden[0, 0]}{jeden[0, 1]}{jeden[0, 2]}");
                        break;
                    case '2':
                        Console.Write($"{dwa[0, 0]}{dwa[0, 1]}{dwa[0, 2]}");
                        break;
                    case '3':
                        Console.Write($"{trzy[0, 0]}{trzy[0, 1]}{trzy[0, 2]}");
                        break;
                    case '4':
                        Console.Write($"{cztery[0, 0]}{cztery[0, 1]}{cztery[0, 2]}");
                        break;
                    case '5':
                        Console.Write($"{piec[0, 0]}{piec[0, 1]}{piec[0, 2]}");
                        break;
                    case '6':
                        Console.Write($"{szesc[0, 0]}{szesc[0, 1]}{szesc[0, 2]}");
                        break;
                    case '7':
                        Console.Write($"{siedem[0, 0]}{siedem[0, 1]}{siedem[0, 2]}");
                        break;
                    case '8':
                        Console.Write($"{osiem[0, 0]}{osiem[0, 1]}{osiem[0, 2]}");
                        break;
                    case '9':
                        Console.Write($"{dziewiec[0, 0]}{dziewiec[0, 1]}{dziewiec[0, 2]}");
                        break;
                    case '0':
                        Console.Write($"{zero[0, 0]}{zero[0, 1]}{zero[0, 2]}");
                        break;
                }
            }
                Console.WriteLine();
                for (int i = 0; i < inputValues.Length; i++)
                {


                    switch (inputValues[i])
                    {
                        case '1':
                            Console.Write($"{jeden[1, 0]}{jeden[1, 1]}{jeden[1, 2]}");
                            break;
                        case '2':
                            Console.Write($"{dwa[1, 0]}{dwa[1, 1]}{dwa[1, 2]}");
                            break;
                        case '3':
                            Console.Write($"{trzy[1, 0]}{trzy[1, 1]}{trzy[1, 2]}");
                            break;
                        case '4':
                            Console.Write($"{cztery[1, 0]}{cztery[1, 1]}{cztery[1, 2]}");
                            break;
                        case '5':
                            Console.Write($"{piec[1, 0]}{piec[1, 1]}{piec[1, 2]}");
                            break;
                        case '6':
                            Console.Write($"{szesc[1, 0]}{szesc[1, 1]}{szesc[1, 2]}");
                            break;
                        case '7':
                            Console.Write($"{siedem[1, 0]}{siedem[1, 1]}{siedem[1, 2]}");
                            break;
                        case '8':
                            Console.Write($"{osiem[1, 0]}{osiem[1, 1]}{osiem[1, 2]}");
                            break;
                        case '9':
                            Console.Write($"{dziewiec[1, 0]}{dziewiec[1, 1]}{dziewiec[1, 2]}");
                            break;
                        case '0':
                            Console.Write($"{zero[1, 0]}{zero[1, 1]}{zero[1, 2]}");
                            break;
                    }
                }
                Console.WriteLine();
                for (int i = 0; i < inputValues.Length; i++)
                {

                    switch (inputValues[i])
                    {

                        case '1':
                            Console.Write($"{jeden[2, 0]}{jeden[2, 1]}{jeden[2, 2]}");
                            break;
                        case '2':
                            Console.Write($"{dwa[2, 0]}{dwa[2, 1]}{dwa[2, 2]}");
                            break;
                        case '3':
                            Console.Write($"{trzy[2, 0]}{trzy[2, 1]}{trzy[2, 2]}");
                            break;
                        case '4':
                            Console.Write($"{cztery[2, 0]}{cztery[2, 1]}{cztery[2, 2]}");
                            break;
                        case '5':
                            Console.Write($"{piec[2, 0]}{piec[2, 1]}{piec[2, 2]}");
                            break;
                        case '6':
                            Console.Write($"{szesc[2, 0]}{szesc[2, 1]}{szesc[2, 2]}");
                            break;
                        case '7':
                            Console.Write($"{siedem[2, 0]}{siedem[2, 1]}{siedem[2, 2]}");
                            break;
                        case '8':
                            Console.Write($"{osiem[2, 0]}{osiem[2, 1]}{osiem[2, 2]}");
                            break;
                        case '9':
                            Console.Write($"{dziewiec[2, 0]}{dziewiec[2, 1]}{dziewiec[2, 2]}");
                            break;
                        case '0':
                            Console.Write($"{zero[2, 0]}{zero[2, 1]}{zero[2, 2]}");
                            break;

                    }
                }
               
            }
          
        }
    }

