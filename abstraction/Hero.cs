namespace abstraction
{
    /* This is a class that inherits the interface IHeroTeam. This is a form of abstraction that uses an interface. */
    public class Hero : IHeroTeam
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public void DisplayTeam(string teamName)
        {
            System.Console.WriteLine($"{Name} is part of the {teamName}.");
        }

    }
}