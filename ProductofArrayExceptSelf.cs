public class SolutionPA {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] answer = new int[n];

        // Step 1: Compute prefix products
        answer[0] = 1; // First element has no left elements
        for (int i = 1; i < n; i++) {
            answer[i] = answer[i - 1] * nums[i - 1];
        }

        // Step 2: Compute suffix products and multiply with prefix products
        int suffixProduct = 1;
        for (int i = n - 1; i >= 0; i--) {
            answer[i] *= suffixProduct;
            suffixProduct *= nums[i];
        }

        return answer;
    }
}

class Program {
    static void Main() {
        int[] nums = {1,2,3,4};
        var solution = new SolutionPA();
        int[] result = solution.ProductExceptSelf(nums);
        Console.WriteLine($"[{string.Join(", ", result)}]");
    }
}