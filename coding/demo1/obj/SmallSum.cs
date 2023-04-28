using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace demo1.obj
{
    public class SmallSum {
    static void Main(string[] args) {
        int[] array1 = {4, 2, -3, 1, 6};
        int minSum = FindSmallestSum(nums);
        Console.WriteLine("Smallest Sum: " + minSum);
    }

    static int FindSmallestSum(int[] array1) {
        int currentSum = array1[0];
        int minSum = array1[0];
        for (int i = 1; i < array1.Length; i++) {
            currentSum = Math.Min(array1[i], currentSum + array1[i]);
            minSum = Math.Min(minSum, currentSum);
        }
        return minSum;
    }
}
}



 