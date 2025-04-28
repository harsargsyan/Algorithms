namespace Algorithms.DynamicProgramming;

/// <summary>
/// Calculate the nth Fibonacci number using recursion with memoization.
/// </summary>
/// <param name="n">The position (n ≥ 0) in the Fibonacci sequence.</param>
/// <returns>The nth Fibonacci number.</returns>
/// <remarks>
/// Time Complexity: O(n) - each Fibonacci number up to n is computed exactly once.
/// Space Complexity: O(n) - due to memoization storage and recursion stack.
/// </remarks>
public class Fibonacci
{
    private static readonly Dictionary<int, long> _memo = new();
    internal static long FibonacciSeq(int n)
    {
        if (n <= 1) return n;

        if (_memo.TryGetValue(n, out var seq)) 
            return seq;

        _memo[n] = FibonacciSeq(n - 1) + FibonacciSeq(n - 2);
        return _memo[n];
    }
}
