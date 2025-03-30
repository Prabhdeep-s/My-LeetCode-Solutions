// https://leetcode.com/problems/merge-intervals/description/

using System;
using System.Collections.Generic;

public class SolutionMI {
    public int[][] Merge(int[][] intervals) {
        if (intervals.Length == 0) return new int[0][];

        // Step 1: Sort intervals by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();

        // Step 2: Merge overlapping intervals
        foreach (var interval in intervals) {
            if (merged.Count == 0 || merged[merged.Count - 1][1] < interval[0]) {
                // No overlap, add the interval
                merged.Add(interval);
            } else {
                // Overlap, merge intervals
                merged[merged.Count - 1][1] = Math.Max(merged[merged.Count - 1][1], interval[1]);
            }
        }

        return merged.ToArray();
    }
}

class Program {
    static void Main() {
        int[][] intervals = [[1,3],[2,6],[8,10],[15,18]];
        SolutionMI solution = new SolutionMI();
        int[][] result = solution.Merge(intervals);

        foreach (var interval in result) {
            Console.WriteLine($"[{interval[0]}, {interval[1]}]");
        }
    }
}