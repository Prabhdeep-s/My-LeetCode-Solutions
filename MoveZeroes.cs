//https://leetcode.com/problems/container-with-most-water/

public class SolutionMZ {
    public void MoveZeroes(int[] nums) {
        int j = 0; // Pointer to place the next non-zero element
        
        // Move all non-zero elements to the front
        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] != 0) {
                (nums[i], nums[j]) = (nums[j], nums[i]); // Swap
                j++;
            }
        }
    }
}

class Program {
    static void Main() {
        int[] nums = [0,1,0,3,12];
        SolutionMZ solution = new SolutionMZ();
        solution.MoveZeroes(nums);

        foreach (var num in nums) {
            Console.WriteLine(num);
        }
    }
}