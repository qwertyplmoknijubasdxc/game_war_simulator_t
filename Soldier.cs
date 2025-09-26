using System;

namespace GameWarSimulator
{
    /// <summary>
    /// Specifies the type of connection a soldier has.
    /// Vertical: Focuses on individual strength and loyalty.
    /// Horizontal: Focuses on teamwork and respect.
    /// </summary>
    public enum ConnectionType
    {
        Vertical,
        Horizontal
    }

    /// <summary>
    /// Represents a soldier with combat, loyalty, and teamwork attributes.
    /// Inherits from Human.
    /// </summary>
    public class Soldier : Human
    {
        /// <summary>
        /// The soldier's attack strength.
        /// </summary>
        public int Attack { get; set; }
        /// <summary>
        /// The soldier's defense capability.
        /// </summary>
        public int Defence { get; set; }
        /// <summary>
        /// The soldier's loyalty level.
        /// </summary>
        public int Loyalty { get; set; }
        /// <summary>
        /// The soldier's respect level.
        /// </summary>
        public int Respect { get; set; }
        /// <summary>
        /// The soldier's connection type (vertical or horizontal).
        /// </summary>
        public ConnectionType Connection { get; set; }
        /// <summary>
        /// The soldier's teamwork ability.
        /// </summary>
        public int Teamwork { get; set; }

        /// <summary>
        /// Initializes a new Soldier with the specified attributes.
        /// Adjusts attributes based on the ConnectionType.
        /// </summary>
        /// <param name="name">The soldier's name.</param>
        /// <param name="hp">The soldier's health points.</param>
        /// <param name="attack">The soldier's attack value.</param>
        /// <param name="defence">The soldier's defense value.</param>
        /// <param name="loyalty">The soldier's loyalty value.</param>
        /// <param name="respect">The soldier's respect value.</param>
        /// <param name="connection">The soldier's connection type.</param>
        /// <param name="teamwork">The soldier's teamwork value.</param>
        /// <param name="iq">The soldier's IQ.</param>
        /// <param name="physicalFitness">The soldier's physical fitness.</param>
        public Soldier(
            string name,
            int hp,
            int attack,
            int defence,
            int loyalty,
            int respect,
            ConnectionType connection,
            int teamwork,
            int iq,
            int physicalFitness)
            : base(name, hp, iq, physicalFitness)
        {
            Attack = attack;
            Defence = defence;
            Loyalty = loyalty;
            Respect = respect;
            Connection = connection;
            Teamwork = teamwork;

            // Adjust attributes based on connection type
            if (Connection == ConnectionType.Horizontal)
            {
                // Increase: Teamwork, Respect, IQ, PhysicalFitness
                Teamwork += 10;
                Respect += 10;
                IQ += 10;
                PhysicalFitness += 10;
                // Decrease: Attack, Defence, Loyalty, HP
                Attack -= 10;
                Defence -= 10;
                Loyalty -= 10;
                HP -= 10;
            }
            else if (Connection == ConnectionType.Vertical)
            {
                // Increase: Attack, Defence, Loyalty, HP
                Attack += 10;
                Defence += 10;
                Loyalty += 10;
                HP += 10;
                // Decrease: Teamwork, Respect, IQ, PhysicalFitness
                Teamwork -= 10;
                Respect -= 10;
                IQ -= 10;
                PhysicalFitness -= 10;
            }
        }

        /// <summary>
        /// Prints all soldier attributes to the console.
        /// </summary>
        public void DisplayAttributes()
        {
            Console.WriteLine("Soldier Attributes:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defence: {Defence}");
            Console.WriteLine($"Loyalty: {Loyalty}");
            Console.WriteLine($"Respect: {Respect}");
            Console.WriteLine($"Connection: {Connection}");
            Console.WriteLine($"Teamwork: {Teamwork}");
            Console.WriteLine($"IQ: {IQ}");
            Console.WriteLine(Race);
            Console.WriteLine($"Physical Fitness: {PhysicalFitness}");
        }
    }
}