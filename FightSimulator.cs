using System;

namespace GameWarSimulator
{
    /// <summary>
    /// Provides functionality to simulate a fight between two <see cref="Soldier"/> objects
    /// and determine the winner based on their combined attribute scores.
    /// </summary>
    public class FightSimulator
    {
        /// <summary>
        /// Simulates a fight between two soldiers and returns the winner.
        /// Calculates each soldier's total score using their attributes.
        /// Displays each soldier's attributes and total score.
        /// Returns the winning <see cref="Soldier"/> object, or <c>null</c> if the result is a draw.
        /// </summary>
        /// <param name="soldier1">The first soldier.</param>
        /// <param name="soldier2">The second soldier.</param>
        /// <returns>The winning <see cref="Soldier"/>, or <c>null</c> if it's a draw.</returns>
        public Soldier SimulateFight(Soldier soldier1, Soldier soldier2)
        {
            int score1 = CalculateScore(soldier1);
            int score2 = CalculateScore(soldier2);

            Console.WriteLine("Soldier 1:");
            soldier1.DisplayAttributes();
            Console.WriteLine("Total Score: " + score1);

            Console.WriteLine("\nSoldier 2:");
            soldier2.DisplayAttributes();
            Console.WriteLine("Total Score: " + score2);

            if (score1 > score2)
            {
                Console.WriteLine("\nSoldier 1 wins!");
                return soldier1;
            }
            else if (score2 > score1)
            {
                Console.WriteLine("\nSoldier 2 wins!");
                return soldier2;
            }
            else
            {
                Console.WriteLine("\nIt's a draw!");
                return null;
            }
        }

        /// <summary>
        /// Calculates the total attribute score for a soldier by summing
        /// HP, Attack, Defence, Loyalty, Respect, Teamwork, IQ, and PhysicalFitness.
        /// </summary>
        /// <param name="soldier">The soldier whose score to calculate.</param>
        /// <returns>The total score as an integer.</returns>
        private int CalculateScore(Soldier soldier)
        {
            return soldier.HP +
                   soldier.Attack +
                   soldier.Defence +
                   soldier.Loyalty +
                   soldier.Respect +
                   soldier.Teamwork +
                   soldier.IQ +
                   soldier.PhysicalFitness;
        }
    }
}