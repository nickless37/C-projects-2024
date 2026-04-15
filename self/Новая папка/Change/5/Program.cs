using System;
using System.Collections.Generic;

public static class Change
{
    public static int[] FindFewestCoins(int[] coins, int target)
    {
        if (target < 0)
        {
            throw new ArgumentException("Target amount must be a positive integer.");
        }
/*        else if (target == 0)
        {
            throw new ArgumentException("Target amount must be a positive integer.");
        }*/
        int[] dp = new int[target + 1];
        int[] lastCoin = new int[target + 1];


        Array.Fill(dp, int.MaxValue);
        dp[0] = 0; 


        for (int amount = 1; amount <= target; amount++)
        {
            foreach (int coin in coins)
            {
                if (amount >= coin && dp[amount - coin] != int.MaxValue)
                {
                    if (dp[amount] > dp[amount - coin] + 1)
                    {
                        dp[amount] = dp[amount - coin] + 1;
                        lastCoin[amount] = coin;
                    }
                }
            }
        }
        if (dp[target] == int.MaxValue)
        {
            throw new ArgumentException("Exact change cannot be made with the provided coin denominations.");
        }


        List<int> result = new List<int>();
        int remaining = target;
        while (remaining > 0)
        {
            int coin = lastCoin[remaining];
            result.Add(coin);
            remaining -= coin;
        }

        return result.ToArray();
    }
}
static class Program
{
    public static void Main()
    {
        var coins = new[]
        {
            2
        };
        int target = int.Parse(Console.ReadLine());
        int[] result = Change.FindFewestCoins(coins, target);
        Console.WriteLine($"Coins: {string.Join(", ", result)}");   
    }
}
    