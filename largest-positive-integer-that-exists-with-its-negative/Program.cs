using System;
using System.Collections.Generic;

class Program
{
    public static int FindLargestK(int[] nums)
    {
        // Create a hash set to store the elements in the array
        HashSet<int> numSet = new HashSet<int>(nums);
        
        int largestK = -1;

        // Iterate through each number in the array
        foreach (int num in nums)
        {
            // Check if the negative of the current number exists in the set
            if (numSet.Contains(-num) && num > 0)
            {
                // If it does and the number is positive, check if it's the largest k found so far
                if (num > largestK)
                {
                    largestK = num;
                }
            }
        }

        // Return the largest positive integer k, or -1 if none is found
        return largestK;
    }

    static void Main()
    {
        // Test cases
        int[] nums1 = { -1, 2, -3, 3 };
        int[] nums2 = { -1, 10, 6, 7, -7, 1 };
        int[] nums3 = { -10, 8, 6, 7, -2, -3 };

        Console.WriteLine(FindLargestK(nums1)); // Output: 3
        Console.WriteLine(FindLargestK(nums2)); // Output: 7
        Console.WriteLine(FindLargestK(nums3)); // Output: -1
    }
}
