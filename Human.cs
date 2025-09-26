using System.Linq;

namespace Template
{
    /// <summary>
    /// Enum representing different human races.
    /// </summary>
    public enum Race
    {
        Caucasian,
        African,
        Asian,
        Hispanic,
        MiddleEastern,
        NativeAmerican,
        Other
    }

    /// <summary>
    /// The Human class represents a basic human entity with core attributes.
    /// It determines race based on the name and applies race-based attribute modifiers.
    /// 
    /// <para>
    /// <b>Scientific context:</b>
    /// <list type="bullet">
    /// <item>
    /// <description>
    /// Human physical and cognitive traits are influenced by a complex interaction of genetics, environment, and culture.
    /// See: https://www.ncbi.nlm.nih.gov/pmc/articles/PMC1448061/
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// There is no scientific basis for assigning abilities or intelligence by race; this is for simulation/game purposes only.
    /// See: https://www.americananthro.org/ConnectWithAAA/Content.aspx?ItemNumber=2583
    /// </description>
    /// </item>
    /// <item>
    /// <description>
    /// Names can sometimes be associated with cultural or ethnic backgrounds, but this is not deterministic.
    /// See: https://www.ncbi.nlm.nih.gov/pmc/articles/PMC1448061/
    /// </description>
    /// </item>
    /// </list>
    /// </para>
    /// </summary>
    public class Human
    {
        /// <summary>
        /// The name of the human.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Health Points (HP) of the human.
        /// </summary>
        public int HP { get; set; }

        /// <summary>
        /// Intelligence Quotient (IQ) of the human.
        /// </summary>
        public int IQ { get; set; }

        /// <summary>
        /// Physical fitness level of the human.
        /// </summary>
        public int PhysicalFitness { get; set; }

        /// <summary>
        /// The race of the human, determined by name.
        /// </summary>
        public Race Race { get; set; }

        /// <summary>
        /// Constructs a Human object, determines race from name, and applies race-based modifiers.
        /// </summary>
        /// <param name="name">The name of the human.</param>
        /// <param name="hp">Initial health points.</param>
        /// <param name="iq">Initial IQ.</param>
        /// <param name="physicalFitness">Initial physical fitness.</param>
        public Human(string name, int hp, int iq, int physicalFitness)
        {
            Name = name;
            HP = hp;
            IQ = iq;
            PhysicalFitness = physicalFitness;
            Race = GetRaceFromName(name);
            ApplyRaceModifiers();
        }

        /// <summary>
        /// Determines the race of a human based on their name.
        /// This is a simplification for simulation purposes.
        /// </summary>
        /// <param name="name">The name to check.</param>
        /// <returns>The determined Race enum value.</returns>
        public Race GetRaceFromName(string name)
        {
            // Names grouped by race, matching your maleNames array
            string[] caucasianNames = {
                "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles",
                "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua"
            };
            string[] africanNames = {
                "Tyrone", "Jerome", "Darnell", "Malik", "Jamal", "DeShawn", "Darius", "Marquis", "Terrell", "Lamar"
            };
            string[] asianNames = {
                "Bruce", "Alan", "Kenji", "Hiro", "Wei", "Minh", "Sung", "Takeshi", "Jin", "Hao"
            };
            string[] hispanicNames = {
                "Jose", "Juan", "Carlos", "Luis", "Miguel", "Javier", "Pedro", "Diego", "Manuel", "Antonio"
            };
            string[] middleEasternNames = {
                "Ahmed", "Ali", "Omar", "Hassan", "Khalid", "Samir", "Yusuf", "Karim", "Tariq", "Faisal"
            };
            string[] nativeAmericanNames = {
                "Dakota", "Logan", "Cheyenne", "Cody", "Hunter", "Wyatt", "Chase", "Sage", "Sky", "Phoenix"
            };
            string[] otherNames = {
                "Gabriel", "Jordan", "Tyler", "Ethan", "Noah", "Austin", "Mason", "Aiden", "Jayden",
                "Elijah", "Carter", "Lucas", "Isaac", "Owen", "Levi", "Connor", "Aaron", "Julian", "Dominic"
            };

            if (caucasianNames.Contains(name)) return Race.Caucasian;
            if (africanNames.Contains(name)) return Race.African;
            if (asianNames.Contains(name)) return Race.Asian;
            if (hispanicNames.Contains(name)) return Race.Hispanic;
            if (middleEasternNames.Contains(name)) return Race.MiddleEastern;
            if (nativeAmericanNames.Contains(name)) return Race.NativeAmerican;
            if (otherNames.Contains(name)) return Race.Other;

            return Race.Caucasian; // Default
        }

        /// <summary>
        /// Applies race-based attribute modifiers.
        /// These are arbitrary and for simulation/game purposes only.
        /// </summary>
        public virtual void ApplyRaceModifiers()
        {
            switch (Race)
            {
                case Race.Caucasian:
                    IQ += 15;
                    PhysicalFitness -= 10;
                    break;
                case Race.African:
                    PhysicalFitness += 20;
                    IQ -= 10;
                    break;
                case Race.Asian:
                    IQ += 20;
                    HP -= 10;
                    break;
                case Race.Hispanic:
                    HP += 15;
                    PhysicalFitness += 15;
                    break;
                case Race.MiddleEastern:
                    HP += 12;
                    IQ += 12;
                    break;
                case Race.NativeAmerican:
                    PhysicalFitness += 15;
                    IQ += 10;
                    break;
                case Race.Other:
                    HP += 10;
                    IQ += 10;
                    PhysicalFitness += 10;
                    break;
            }
        }
    }
}