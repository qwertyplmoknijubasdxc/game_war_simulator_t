using System;

namespace Template
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

        static Soldier GenerateRandomSoldier()
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
            string name = GetRandomName();
            return new Soldier(name,hp, attack, defence, loyalty, respect, connection, teamwork, iq, physicalFitness);
        }

        static void Main(string[] args)
        {
            // Generate two random soldiers
            Soldier s1 = GenerateRandomSoldier();
            Soldier s2 = GenerateRandomSoldier();
            
            // Optionally, assign random leaders and influence soldiers
            string name1 = GetRandomName();
            string name2 = GetRandomName();
            Leader leader1 = new Leader(name1,rand.Next(100, 151), rand.Next(100, 201), rand.Next(70, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(1, 10));
            Leader leader2 = new Leader(name2,rand.Next(100, 151), rand.Next(100, 201), rand.Next(70, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(50, 101), rand.Next(1, 10));
            leader1.InfluenceSoldier(s1);
            leader2.InfluenceSoldier(s2);

            FightSimulator simulator = new FightSimulator();
            simulator.SimulateFight(s1, s2);

            Console.WriteLine("End of the program");
            Console.ReadLine();
        }
    }
}
