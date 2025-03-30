//https://leetcode.com/problems/remove-duplicates-from-sorted-array/

public class SolutionRD {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0; // Edge case: empty array

        int i = 0; // Pointer for the position of the last unique element

        for (int j = 1; j < nums.Length; j++) {
            if (nums[j] != nums[i]) { // Found a new unique element
                i++; // Move unique pointer
                nums[i] = nums[j]; // Place unique element
            }
        }

        return i + 1; // Number of unique elements
    }
}

class Program {
    static void Main() {
        SolutionRD solution = new SolutionRD();
        int[] nums = {0,0,1,1,1,2,2,3,3,4};
        int result = solution.RemoveDuplicates(nums);
        Console.WriteLine(result);
    }
}