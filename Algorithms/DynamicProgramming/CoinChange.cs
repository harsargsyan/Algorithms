namespace Algorithms.DynamicProgramming;

/// <summary>
/// Provides a method to solve the Coin Change problem using bottom-up dynamic programming.
/// 
/// Time Complexity: O(amount × n)
///   - 'amount' is the target value.
///   - 'n' is the number of coin denominations.
///   - For each amount from 1 to 'amount', we iterate over all 'n' coins.
///
/// Space Complexity: O(amount)
///   - We use a one-dimensional DP array of size (amount + 1) to store subproblem results.
/// </summary>
public class CoinChangeSolver
{
    public static int CoinChange(int[] coins, int amount)
    {
        int[] dp = new int[amount + 1];
        Array.Fill(dp, amount + 1);
        dp[0] = 0;

        for (int i = 1; i <= amount; i++)
        {
            foreach (int coin in coins)
            {
                if (i >= coin)
                {
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

        return dp[amount] > amount ? -1 : dp[amount];
    }
}
