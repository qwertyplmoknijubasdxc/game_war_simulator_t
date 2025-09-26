using System;

namespace Template
{
    public enum ConnectionType
    {
        Vertical,
        Horizontal
    }

    public class Soldier : Human
    {
        public int Attack { get; set; }
        public int Defence { get; set; }
        public int Loyalty { get; set; }
        public int Respect { get; set; }
        public ConnectionType Connection { get; set; }
        public int Teamwork { get; set; }

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