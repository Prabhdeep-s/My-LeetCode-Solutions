// https://leetcode.com/problems/rotate-array/description/

public class SolutionRA {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k %= n; // Handle cases where k > n

        Reverse(nums, 0, n - 1);   // Step 1: Reverse entire array
        Reverse(nums, 0, k - 1);   // Step 2: Reverse first k elements
        Reverse(nums, k, n - 1);   // Step 3: Reverse remaining elements

        Console.WriteLine("{0}", string.Join(", ", nums));
    }

    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            (nums[start], nums[end]) = (nums[end], nums[start]); // Swap elements
            start++;
            end--;
        }
    }
}

class Program {
    static void Main() {
        SolutionRA solution = new SolutionRA();
        int[] nums = [1,2,3,4,5,6,7];
        int k = 3;
        solution.Rotate(nums, k);
    }
}