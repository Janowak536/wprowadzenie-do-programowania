using System;

class Test
{
    public static void Main()
    {
        string tempString1;
        string tempString2;
        string tempString3;
        string result = "";
        int checker = 0;
        while ((tempString1 = Console.ReadLine()) != null)
        {
            char[] firstLine = tempString1.ToCharArray();
            int howMany = tempString1.Length;
            tempString2 = Console.ReadLine();

            if (tempString2 == null)
                break;

            char[] secondLine = tempString2.ToCharArray();
            int howMany2 = tempString2.Length;
            tempString3 = Console.ReadLine();

            if (tempString3 == null)
                break;

            char[] thirdLine = tempString3.ToCharArray();
            int howMany3 = tempString3.Length;
            int tempLenght = 0;
            int charAmount = 0;

            while ((tempLenght <= howMany) && (tempLenght <= howMany2) && (tempLenght <= howMany3))
            {
                tempLenght += 4;
                if ((howMany > 3) && (howMany2 > 3) && (howMany3 > 3))
                    charAmount++;
            }
            if (charAmount > 0)
            {
                for (int i = 0; i <= charAmount; ++i)
                {
                    if (i == 0)
                        checker = result.Length;

                    int notSoEasy = i * 3;
                    if ((firstLine.Length >= (2 + i * 3)) && (secondLine.Length >= (2 + i * 3)) && (thirdLine.Length >= (2 + i * 3)))
                    {
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == '|' && secondLine[1 + notSoEasy] == ' ' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == '|' && thirdLine[1 + notSoEasy] == '_' && thirdLine[2 + notSoEasy] == '|')
                            result += 0;
                        if (firstLine[1 + notSoEasy] == ' ' && secondLine[0 + notSoEasy] == ' ' && secondLine[1 + notSoEasy] == ' ' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == ' ' && thirdLine[1 + notSoEasy] == ' ' && thirdLine[2 + notSoEasy] == '|')
                            result += 1;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == ' ' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == '|' && thirdLine[1 + notSoEasy] == '_' && thirdLine[2 + notSoEasy] == ' ')
                            result += 2;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == ' ' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == ' ' && thirdLine[1 + notSoEasy] == '_' && thirdLine[2 + notSoEasy] == '|')
                            result += 3;
                        if (firstLine[1 + notSoEasy] == ' ' && secondLine[0 + notSoEasy] == '|' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == ' ' && thirdLine[1 + notSoEasy] == ' ' && thirdLine[2 + notSoEasy] == '|')
                            result += 4;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == '|' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == ' ' && thirdLine[0 + notSoEasy] == ' ' && thirdLine[1 + notSoEasy] == '_' && thirdLine[2 + notSoEasy] == '|')
                            result += 5;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == '|' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == ' ' && thirdLine[0 + notSoEasy] == '|' && thirdLine[1 + notSoEasy] == '_' && thirdLine[2 + notSoEasy] == '|')
                            result += 6;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == ' ' && secondLine[1 + notSoEasy] == ' ' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == ' ' && thirdLine[1 + notSoEasy] == ' ' && thirdLine[2 + notSoEasy] == '|')
                            result += 7;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == '|' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == '|' && thirdLine[1 + notSoEasy] == '_' && thirdLine[2 + notSoEasy] == '|')
                            result += 8;
                        if (firstLine[1 + notSoEasy] == '_' && secondLine[0 + notSoEasy] == '|' && secondLine[1 + notSoEasy] == '_' && secondLine[2 + notSoEasy] == '|' && thirdLine[0 + notSoEasy] == ' ' && thirdLine[1 + notSoEasy] == ' ' && thirdLine[2 + notSoEasy] == '|')
                            result += 9;
                    }
                }
                if (result.Length > checker)
                    result += Environment.NewLine;
            }
        }
        Console.WriteLine(result);
    }
}