using System;
using System.Collections.Generic;
using System.Text;

namespace SBANK_Sorting_Bank_Account
{
    public static class SBANK
    {
        public static void Logic(int accountCount, StringBuilder output)
        {
            var Accounts = new SortedSet<string>();
            var AccountCount = new Dictionary<string, int>();

            while (accountCount-- > 0)
            {
                string account = Console.ReadLine();

                int Counted;
                if (AccountCount.TryGetValue(account, out Counted))
                {
                    AccountCount[account] = Counted +1;
                }
                else
                {
                    AccountCount[account] = 1;
                    Accounts.Add(account);
                }
            }
            Console.ReadLine();

            foreach (var account in Accounts)
            {
                output.AppendLine($"{account} {AccountCount[account]}");
            }
            output.AppendLine();
        }
    }
    public static class Program
    {
        private static void Main()
        {
            var output = new StringBuilder();
            int Tests = int.Parse(Console.ReadLine());
            while (Tests-- > 0)
            {
                SBANK.Logic(
                    accountCount: int.Parse(Console.ReadLine()),
                    output: output);
            }
            Console.Write(output);
        }
    }
}
