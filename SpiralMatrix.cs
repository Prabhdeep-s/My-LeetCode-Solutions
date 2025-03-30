// https://leetcode.com/problems/spiral-matrix/description/

public class SolutionSM {
    public IList<int> SpiralOrder(int[][] matrix) {
        List<int> result = new List<int>();
        if (matrix == null || matrix.Length == 0) return result;

        int m = matrix.Length, n = matrix[0].Length;
        int top = 0, bottom = m - 1, left = 0, right = n - 1;

        while (top <= bottom && left <= right) {
            // Traverse from left to right
            for (int i = left; i <= right; i++) {
                result.Add(matrix[top][i]);
            }
            top++; // Move the top boundary down

            // Traverse from top to bottom
            for (int i = top; i <= bottom; i++) {
                result.Add(matrix[i][right]);
            }
            right--; // Move the right boundary left

            if (top <= bottom) { // Ensure there is a row left
                // Traverse from right to left
                for (int i = right; i >= left; i--) {
                    result.Add(matrix[bottom][i]);
                }
                bottom--; // Move the bottom boundary up
            }

            if (left <= right) { // Ensure there is a column left
                // Traverse from bottom to top
                for (int i = bottom; i >= top; i--) {
                    result.Add(matrix[i][left]);
                }
                left++; // Move the left boundary right
            }
        }

        return result;
    }
}

class Program {
    static void Main() {
        int[][] matrix = [[1,2,3],
          [4,5,6],
          [7,8,9]];
        SolutionSM solution = new SolutionSM();
        IList<int> result = solution.SpiralOrder(matrix);
        Console.WriteLine("Output for matrix1: " + string.Join(", ", result));
    }
}