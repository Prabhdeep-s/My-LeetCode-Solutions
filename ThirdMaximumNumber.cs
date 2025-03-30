// https://leetcode.com/problems/third-maximum-number/

public class SolutionTM {
    public int ThirdMax(int[] nums) {
        int? first = null, second = null, third = null;

        foreach (int num in nums) {
            // Skip if already present in first, second, or third
            if (num == first || num == second || num == third) {
                continue;
            }

            if (first == null || num > first) {
                third = second;
                second = first;
                first = num;
            } else if (second == null || num > second) {
                third = second;
                second = num;
            } else if (third == null || num > third) {
                third = num;
            }
        }

        return third ?? first.Value; // Return third if it exists, else return first (maximum number)
    }
}

class Program {
    static void Main() {
        int[] nums = [2,2,3,1,5,6];
        SolutionTM solution = new SolutionTM();
        Console.WriteLine(solution.ThirdMax(nums));
    }
}