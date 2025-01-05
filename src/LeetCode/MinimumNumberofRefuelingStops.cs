// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace LeetCode;

// public class MinimumNumberofRefuelingStops
// {
//     public int MinRefuelStops(int target, int startFuel, int[][] stations)
//     {
//         int[][] dp = new int[target + 1][stations.Length];
//         int currentPosition = 0;
//         int remainingFuel = startFuel;

//         for (int i = 1; i < target + 1; i++ )
//         {
//             remainingFuel--;

//             for (int s = 0; s < stations.Length; s++)
//             {
//                 if ( stations[s][0] <= remainingFuel + i)
//                 {
//                     dp[i] = Math.Min(dp[i], dp[i - 1] + 1);
//                 }
//         }
//     }
// }
// }