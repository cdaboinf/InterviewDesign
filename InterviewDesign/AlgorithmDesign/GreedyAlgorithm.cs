using System;
namespace InterviewDesign.AlgorithmDesign
{
    public class GreedyAlgorithm
    {
        /*
         * A greedy algorithm is an approach for solving a problem 
         * by selecting the best option available at the moment. 
         * It doesn't worry whether the current best result will 
         * bring the overall optimal result.
         */
        public GreedyAlgorithm()
        {
        }

        /*
         * Greedy Algorithm
         * 1 - To begin with, the solution set (containing answers) is empty.
         * 2 - At each step, an item is added to the solution set until a solution is reached.
         * 3 - If the solution set is feasible, the current item is kept.
         * 4 - Else, the item is rejected and never considered again.
         */

        /*
         *  Problem: You have to make a change of an amount using the smallest 
            possible number of coins.

            Amount: $18

            Available coins are
              $5 coin
              $2 coin
              $1 coin
            There is no limit to the number of each coin you can use.
         */
        public int SmallestNumberOfCoins(int [] coins, int sum) {
            var amount = 0;
            var i = 0;
            var change = 0;

            while(i< coins.Length)
            {
                if(amount + coins[i] <= sum)
                {
                    amount += coins[i];
                    change++;
                }
                else
                {
                    i++;
                }
            }

            return change;
        }

    }
}
