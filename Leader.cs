using System;

namespace GameWarSimulator
{
    /// <summary>
    /// Represents a leader with attributes for charisma, strategy, leadership, and experience.
    /// Inherits from Human and can influence Soldier attributes.
    /// </summary>
    public class Leader : Human
    {
        /// <summary>
        /// The leader's charisma value.
        /// </summary>
        public int Charisma { get; set; }
        /// <summary>
        /// The leader's strategy value.
        /// </summary>
        public int Strategy { get; set; }
        /// <summary>
        /// The leader's leadership value.
        /// </summary>
        public int Leadership { get; set; }
        /// <summary>
        /// The leader's experience value.
        /// </summary>
        public int Experience { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Leader"/> class with the specified attributes.
        /// </summary>
        /// <param name="name">The leader's name.</param>
        /// <param name="hp">The leader's health points.</param>
        /// <param name="iq">The leader's IQ.</param>
        /// <param name="physicalFitness">The leader's physical fitness.</param>
        /// <param name="charisma">The leader's charisma.</param>
        /// <param name="strategy">The leader's strategy.</param>
        /// <param name="leadership">The leader's leadership.</param>
        /// <param name="experience">The leader's experience.</param>
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

        /// <summary>
        /// Influences a soldier's connection type and attributes based on the leader's stats.
        /// If Charisma + Leadership &gt; 150, sets connection to Horizontal; otherwise, Vertical.
        /// Increases soldier's loyalty, respect, teamwork, IQ, and physical fitness.
        /// </summary>
        /// <param name="soldier">The soldier to influence.</param>
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

        /// <summary>
        /// Prints all leader attributes to the console.
        /// </summary>
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