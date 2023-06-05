using MethodTimer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksProblem
{
    public static class Problem
    {
        [Time]
        public static int MaxPages(int n, int x, int[] c, int[] s)
        {
            int[,] dp = new int[n+1,x+1];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= x; j++)
                {
                    if (i== 0 || j == 0)
                    {
                        dp[i, j] = 0;
                    }
                    else if (c[i - 1] <= j)
                    {
                        dp[i, j] = Math.Max(s[i - 1] + dp[i-1,j - c[i-1]], dp[i-1,j]);
                    }
                    else
                    {
                        dp[i, j] = dp[i - 1, j];
                    }
                }
            }
            return dp[n, x];
        }
    }
}
