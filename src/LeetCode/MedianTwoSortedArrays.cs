using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeetCode;

public class MedianTwoSortedArrays
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int [] mergeArray = new int[ nums1.Length + nums2.Length ];

        int i = 0, j = 0;

        // merge the arrays first sorted.
        int c = 0;
        while (i < nums1.Length && j < nums2.Length)
        {
            if (nums1[i] < nums2[j])
            {
                mergeArray[c] = nums1[i];
                i++;
            }
            else
            {
                mergeArray[c] = nums2[j];
                j++;
            }
            c++;
        }

        while ( i < nums1.Length)
        {
            mergeArray[c] = nums1[i];
            i++;
            c++;
        }

        while (j < nums2.Length)
        {
            mergeArray[c] = nums2[j];
            j++;
            c++;
        }

        if (mergeArray.Length % 2 == 0)
        {
            return (mergeArray[mergeArray.Length / 2] + mergeArray[(mergeArray.Length - 2) / 2]) / 2.0;
        }
        else
        {
            return mergeArray[(mergeArray.Length - 1) / 2];
        }
    }
}
