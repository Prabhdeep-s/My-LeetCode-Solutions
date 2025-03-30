public class SolutionMS {
    public (int, int[]) MaxSubArray(int[] nums) {
        int maxSum = nums[0]; 
        int currentSum = nums[0]; 
        int start = 0, end = 0, tempStart = 0; // To track the subarray indices

        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] > currentSum + nums[i]) {
                currentSum = nums[i];
                tempStart = i; // Start new subarray
            } else {
                currentSum += nums[i];
            }

            if (currentSum > maxSum) {
                maxSum = currentSum;
                start = tempStart; // Update start index
                end = i; // Update end index
            }
        }

        // Extract the subarray
        int[] subArray = new int[end - start + 1];
        Array.Copy(nums, start, subArray, 0, end - start + 1);

        return (maxSum, subArray);
    }
}

class Program {
    static void Main() {
        int[] nums = {-2,1,-3,4,-1,2,1,-5,4};
        var solution = new SolutionMS();
        var result = solution.MaxSubArray(nums);
        Console.WriteLine($"Max Sum: {result.Item1}");
        Console.WriteLine($"Subarray: [{string.Join(", ", result.Item2)}]");

    }
}