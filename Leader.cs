using System;

namespace Template
{
    public class Leader : Human
    {
        public int Charisma { get; set; }
        public int Strategy { get; set; }
        public int Leadership { get; set; }
        public int Experience { get; set; }

        public Leader(
            string name,
            int hp,
            int iq,
            int physicalFitness,
            int charisma,
            int strategy,
            int leadership,
            int experience)
            : base(name, hp, iq, physicalFitness)
        {
            Charisma = charisma;
            Strategy = strategy;
            Leadership = leadership;
            Experience = experience;
        }

        public void InfluenceSoldier(Soldier soldier)
        {
            // Influence connection type based on leader's charisma and leadership
            if (Charisma + Leadership > 150)
            {
                soldier.Connection = ConnectionType.Horizontal;
            }
            else
            {
                soldier.Connection = ConnectionType.Vertical;
            }

            // Increase soldier's attributes based on leader's stats
            soldier.Loyalty += Leadership / 5;
            soldier.Respect += Charisma / 5;
            soldier.Teamwork += Strategy / 5;
            soldier.IQ += IQ / 10;
            soldier.PhysicalFitness += PhysicalFitness / 10;
        }

        public void DisplayAttributes()
        {
            
            Console.WriteLine("Leader Attributes:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"IQ: {IQ}");
            Console.WriteLine($"Physical Fitness: {PhysicalFitness}");
            Console.WriteLine($"Charisma: {Charisma}");
            Console.WriteLine($"Strategy: {Strategy}");
            Console.WriteLine($"Leadership: {Leadership}");
            Console.WriteLine($"Experience: {Experience}");
        }
    }
}