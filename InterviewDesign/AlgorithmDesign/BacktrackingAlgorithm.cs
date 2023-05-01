using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AlgorithmDesign
{
    /*
     * A backtracking algorithm uses brute force approach to find the desired output.
     * The brute force tries all posible solutions. Keep reducing to simpler problems
     * 
     * Components:
     * - state: current state of the posible solution
     * - base case: simplest state problem, stops the recursion
     */
    public class BacktrackingAlgorithm
    {
        /*
         * numbers = [1,2,3,4,2,1], target = 6 => result[[1,2,3],[1,2,2,1],[3,2,1],[4,2]]  
         */
        public List<List<int>> FindTargetSolutions(
            int target,
            List<int> numbers)
        {
            List<List<int>> results = new List<List<int>>();
            RecursiveMethod(target, numbers, 0, 0, new List<int>(), results);

            return results;

        }

        public void RecursiveMethod(
        int target,
        List<int> numbers,
        int sum,
        int index,
        List<int> result,
        List<List<int>> results)
        {
            // base cases
            if (index == numbers.Count)
            {
                results.Add(new List<int>(result));
                return;
            }
            else if (sum > target)
            {
                return;
            }
            else
            {
                for (var i = index; i < numbers.Count; i++)
                {
                    // recursive request
                    sum += numbers[index];
                    result.Add(i);

                    RecursiveMethod(
                        target,
                        numbers,
                        sum,
                        i+1,
                        result,
                        results);
                    
                    // back track
                    result.RemoveAt(results.Count - 1);
                }
            }
        }
    }
}
