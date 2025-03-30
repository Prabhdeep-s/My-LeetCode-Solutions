//https://leetcode.com/problems/container-with-most-water/description/

public class SolutionMW {
    public int MaxArea(int[] height) {
        int left = 0, right = height.Length - 1;
        int maxArea = 0;

        while (left < right) {
            int area = (right - left) * Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, area);

            // Move the pointer that points to the shorter height
            if (height[left] < height[right]) {
                left++;
            } else {
                right--;
            }
        }
        return maxArea;
    }
}

class Program {
    static void Main() {
        int[] height = [1,8,6,2,5,4,8,3,7];
        SolutionMW solution = new SolutionMW();
        Console.WriteLine(solution.MaxArea(height));
    }
}