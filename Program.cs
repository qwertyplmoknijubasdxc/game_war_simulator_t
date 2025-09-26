using System;

namespace GameWarSimulator
{
    class Program
    {
        static string GetRandomName()
        {
            string[] maleNames = new string[]  {
                // Caucasian
                "James", "John", "Robert", "Michael", "William", "David", "Richard", "Joseph", "Thomas", "Charles",
                "Christopher", "Daniel", "Matthew", "Anthony", "Mark", "Donald", "Steven", "Paul", "Andrew", "Joshua",
                // African
                "Tyrone", "Jerome", "Darnell", "Malik", "Jamal", "DeShawn", "Darius", "Marquis", "Terrell", "Lamar",
                // Asian
                "Bruce", "Alan", "Kenji", "Hiro", "Wei", "Minh", "Sung", "Takeshi", "Jin", "Hao",
                // Hispanic
                "Jose", "Juan", "Carlos", "Luis", "Miguel", "Javier", "Pedro", "Diego", "Manuel", "Antonio",
                // MiddleEastern
                "Ahmed", "Ali", "Omar", "Hassan", "Khalid", "Samir", "Yusuf", "Karim", "Tariq", "Faisal",
                // NativeAmerican
                "Dakota", "Logan", "Cheyenne", "Cody", "Hunter", "Wyatt", "Chase", "Sage", "Sky", "Phoenix",
                // Other
                "Gabriel", "Jordan", "Tyler", "Ethan", "Noah", "Austin", "Mason", "Logan", "Aiden", "Jayden",
                "Elijah", "Carter", "Lucas", "Isaac", "Owen", "Levi", "Connor", "Aaron", "Julian", "Dominic"
            };
            string name = maleNames[rand.Next(maleNames.Length)];
            return name;
        }

        static Random rand = new Random();

        static string GetNameFromUser(string prompt, string[] args, int argIndex)
        {
            if (args != null && args.Length > argIndex && !string.IsNullOrWhiteSpace(args[argIndex]))
            {
                return args[argIndex];
            }
            Console.Write($"{prompt} (leave blank for random): ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
                return input;
            return GetRandomName();
        }

        static Soldier GenerateRandomSoldier(string name = null)
        {
            int hp = rand.Next(80, 151);
            int attack = rand.Next(10, 41);
            int defence = rand.Next(10, 41);
            int loyalty = rand.Next(10, 51);
            int respect = rand.Next(10, 51);
            ConnectionType connection = (ConnectionType)rand.Next(0, 2);
            int teamwork = rand.Next(10, 51);
            int iq = rand.Next(90, 151);
            int physicalFitness = rand.Next(50, 101);
            if (string.IsNullOrWhiteSpace(name))
                name = GetRandomName();
            return new Soldier(name, hp, attack, defence, loyalty, respect, connection, teamwork, iq, physicalFitness);
        }

        static void Main(string[] args)
        {
            // Get names for soldiers and leaders from args or dialog
            string s1Name = GetNameFromUser("Enter name for Soldier 1", args, 0);
            string s2Name = GetNameFromUser("Enter name for Soldier 2", args, 1);
            string leader1Name = GetNameFromUser("Enter name for Leader 1", args, 2);
            string leader2Name = GetNameFromUser("Enter name for Leader 2", args, 3);

            // Generate two soldiers with selected names
            Soldier s1 = GenerateRandomSoldier(s1Name);
            Soldier s2 = GenerateRandomSoldier(s2Name);

            // Assign leaders with selected names
            Leader leader1 = new Leader(leader1Name, rand.Next(100, 151), rand.Next(100, 201), rand.Next(70, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(1, 10));
            Leader leader2 = new Leader(leader2Name, rand.Next(100, 151), rand.Next(100, 201), rand.Next(70, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(1, 10));
            leader1.InfluenceSoldier(s1);
            leader2.InfluenceSoldier(s2);

            FightSimulator simulator = new FightSimulator();
            simulator.SimulateFight(s1, s2);

            Console.WriteLine("End of the program");
            Console.ReadLine();
        }
    }
}
