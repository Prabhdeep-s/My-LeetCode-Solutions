// https://leetcode.com/problems/two-sum/

using System;
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numIndices = new Dictionary<int, int>();

        for (int i=0; i<nums.Length; i++) {
            int complement = target - nums[i];

            if (numIndices.ContainsKey(complement)) {
                return new int[] {numIndices[complement], i};
            }

            if (!numIndices.ContainsKey(nums[i])) {
                numIndices[nums[i]] = i;
            }
        }
        return new int[0];
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = solution.TwoSum(nums, target);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}