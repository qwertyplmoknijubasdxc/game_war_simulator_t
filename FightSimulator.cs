using System;

namespace Template
{
    public class FightSimulator
    {
        // Simulate a fight between two soldiers and return the winner
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

        // Calculate the total attribute score for a soldier
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